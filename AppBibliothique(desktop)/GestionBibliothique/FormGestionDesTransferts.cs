using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionBibliothique
{
    public partial class FormGestionDesTransferts : Form
    {
        BindingSource bs = new BindingSource();
       static DateTime dateR ;
        public FormGestionDesTransferts()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestionDesTransferts_Load(object sender, EventArgs e)
        {

            remplirGrid();
            RemplirCombo();
            Bind();
            getQuantite();
            dateR = dateTimePikerRetour.Value;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                    Application.OpenForms[i].Close();
                else
                    Application.OpenForms[i].Show();
            }
        }

        void remplirGrid()
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                var demandes = context.demandes.Select(c => new
                {

                    Nom_Eleve = c.eleve.nom + " " + c.eleve.prenom,
                    Titre_Livre = c.livre.titre,
                    Date_Prise = c.date_prise,
                    Date_Retour = c.date_retour,
                    Validation_Retour = c.valide_Retour,

                }).ToList();

                bs.DataSource = demandes;

                ComboBoxTri.Items.Clear();

                for (int i = 0; i < dataGridViewTransfert.Columns.Count - 1; i++)
                {

                    ComboBoxTri.Items.Add(dataGridViewTransfert.Columns[i].Name);
                }

                dataGridViewTransfert.DataSource = bs;
            }


        }

        void RemplirCombo()
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                var eleves = context.eleves.Select(c => new
                {

                    id = c.id,
                    Nom_Eleve = c.nom + " " + c.prenom
                });
                comboEleve.DataSource = eleves.ToList();
                comboEleve.DisplayMember = "Nom_Eleve";
                comboEleve.ValueMember = "id";

                var livres = context.livres.Where(c => c.disponibilite == true && c.quantite > 0).Select(c => new
                {
                    id = c.id,
                    Titre_Livre = c.titre
                });
                comboLivre.DataSource = livres.ToList();
                comboLivre.DisplayMember = "Titre_Livre";
                comboLivre.ValueMember = "id";

            }

        }



        private void btnNouveau_Click(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                demande d = new demande();
                d.id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                d.id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                d.date_prise = dateTimePikerPrise.Value;
                d.date_retour = dateTimePikerRetour.Value;
                d.valide_Retour = checkboxValidation.Checked;

                context.demandes.Add(d);
                context.SaveChanges();
                MessageBox.Show("Bien Ajouter");


            }
        }

        private void Bind()
        {


            comboEleve.DataBindings.Add("Text", bs, "Nom_Eleve", true);
            comboLivre.DataBindings.Add("Text", bs, "Titre_Livre", true);
            dateTimePikerPrise.DataBindings.Add("Value", bs, "Date_Prise", true);
            dateTimePikerRetour.DataBindings.Add("Value", bs, "Date_Retour", true);
            checkboxValidation.DataBindings.Add("Checked", bs, "Validation_Retour", true);
        }

        //Methode Ajouter Entity framework
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                demande d = new demande();
                d.id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                d.id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                d.date_prise = dateTimePikerPrise.Value;
                d.date_retour = dateTimePikerRetour.Value;
                d.valide_Retour = checkboxValidation.Checked;

                var dem = context.demandes.FirstOrDefault(c => c.id_eleve == d.id_eleve && c.id_livre == d.id_livre);

                if (dem == null)
                {
                    context.demandes.Add(d);
                    context.SaveChanges();
                    MessageBox.Show("Bien Ajouter");
                    remplirGrid();
                    RemplirCombo();
                }
                else
                {
                    MessageBox.Show("Cette Demande existe déja");
                }


            }
        }

        //Methode Supprimer Entity framework
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                int id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                int id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                var dem = context.demandes.FirstOrDefault(c => c.id_eleve == id_eleve && c.id_livre == id_livre);

                if (dem != null)
                {
                    DialogResult rep = MessageBox.Show("Annulation", "Voulez vous Annuler ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        context.demandes.Remove(dem);
                        context.SaveChanges();
                        MessageBox.Show("Bien Annuler");
                        remplirGrid();
                        RemplirCombo();
                    }
                }
                else
                {
                    MessageBox.Show("Cette Demande n'existe pas ");
                }
            }

        }

        //Methode Modifier Entity framework
        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                int id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                int id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                var dem = context.demandes.FirstOrDefault(c => c.id_eleve == id_eleve && c.id_livre == id_livre);

                if (dem != null)
                {
                    dem.id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                    dem.id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                    dem.date_prise = dateTimePikerPrise.Value;
                    dem.date_retour = dateTimePikerRetour.Value;
                    dem.valide_Retour = checkboxValidation.Checked;

                    context.SaveChanges();
                    bs.EndEdit();
                    MessageBox.Show("Bien Modifier");
                    remplirGrid();
                    RemplirCombo();
                }
                else
                {
                    MessageBox.Show("Cette Demande n'existe pas ");
                }
            }
        }

        private void ComboBoxTri_SelectedIndexChanged(object sender, EventArgs e)
        {


            using (BiblioEntities context = new BiblioEntities())
            {

                var demandes = context.demandes.Select(c => new
               {
                   Nom_Eleve = c.eleve.nom + " " + c.eleve.prenom,
                   Titre_Livre = c.livre.titre,
                   Date_Prise = c.date_prise,
                   Date_Retour = c.date_retour,
                   Validation_Retour = c.valide_Retour,

               }).ToList();



                switch (ComboBoxTri.SelectedIndex)
                {
                    case 0:
                        var dem0 = demandes.OrderBy(c => c.Nom_Eleve).ToList();
                        bs.DataSource = dem0;
                        break;
                    case 1:
                        var dem1 = demandes.OrderBy(c => c.Titre_Livre).ToList();
                        bs.DataSource = dem1;
                        break;

                    case 2:
                        var dem2 = demandes.OrderByDescending(c => c.Date_Prise).ToList();
                        bs.DataSource = dem2;
                        break;
                    case 3:
                        var dem3 = demandes.OrderByDescending(c => c.Date_Retour).ToList();
                        bs.DataSource = dem3;
                        break;

                    default:
                        bs.DataSource = demandes;
                        break;
                }
            }

            dataGridViewTransfert.DataSource = bs;
        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {

                bool val;

                if (ComboBoxFilter.Text == "Validé")
                {
                    val = true;

                }

                else if (ComboBoxFilter.Text == "Non Validé")
                {
                    val = false;
                }
                else
                {
                    remplirGrid();
                    return;
                }

                var demandes = context.demandes.Where(c => c.valide_Retour == val).Select(c => new
                {
                    Nom_Eleve = c.eleve.nom + " " + c.eleve.prenom,
                    Titre_Livre = c.livre.titre,
                    Date_Prise = c.date_prise,
                    Date_Retour = c.date_retour,
                    Validation_Retour = c.valide_Retour,

                }).ToList();

                bs.DataSource = demandes;
                dataGridViewTransfert.DataSource = bs;
            }
        }

        private void txteleve_TextChanged_1(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                string txt = txteleve.Text;
                if (txt == "") { RemplirCombo(); return; }
                var eleves = context.eleves.Where(c => c.nom.Contains(txt) || c.prenom.Contains(txt)).Select(c => new
                {

                    id = c.id,
                    Nom_Eleve = c.nom + " " + c.prenom
                });
                comboEleve.DataSource = eleves.ToList();
                comboEleve.DisplayMember = "Nom_Eleve";
                comboEleve.ValueMember = "id";



            }
        }

        private void txtliivre_TextChanged_1(object sender, EventArgs e)
        {
            using (BiblioEntities context = new BiblioEntities())
            {
                string txt = txtliivre.Text;
                if (txt == "") { RemplirCombo(); return; }
                var livres = context.livres.Where(c => c.titre.Contains(txt)).Select(c => new
                {
                    id = c.id,
                    Titre_Livre = c.titre
                });
                comboLivre.DataSource = livres.ToList();
                comboLivre.DisplayMember = "Titre_Livre";
                comboLivre.ValueMember = "id";

            }
        }

        private void comboLivre_SelectedIndexChanged(object sender, EventArgs e)
        {

            getQuantite();


        }

        void getQuantite()
        {
            try
            {
                int code = int.Parse(comboLivre.SelectedValue.ToString());
                using (BiblioEntities context = new BiblioEntities())
                {
                    var livre = context.livres.FirstOrDefault(c => c.id == code);

                    txtQtt.Text = livre.quantite + "";

                }
            }
            catch (Exception)
            {


            }

        }

        private void checkboxValidation_CheckedChanged(object sender, EventArgs e)
        {


             

            if (checkboxValidation.Checked == true)
            {


                dateTimePikerRetour.Value = DateTime.Now;
               

            }
            else
            {
                dateTimePikerRetour.Value = dateR;
            
            }

            using (BiblioEntities context = new BiblioEntities())
            {
                int id_eleve = int.Parse(comboEleve.SelectedValue.ToString());
                int id_livre = int.Parse(comboLivre.SelectedValue.ToString());
                var dem = context.demandes.FirstOrDefault(c => c.id_eleve == id_eleve && c.id_livre == id_livre);

                if (dem != null)
                {

                    dem.date_retour = dateTimePikerRetour.Value;

                    bs.EndEdit();
                    context.SaveChanges();

                    
                   

                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}