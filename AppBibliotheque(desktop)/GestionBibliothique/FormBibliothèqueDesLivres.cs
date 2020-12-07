using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace GestionBibliothique
{
    public partial class FormBibliothèqueDesLivres : Form
    {
        string strcn = Program.strcn;
        SqlConnection cn =new SqlConnection();
        DataTable dt=new DataTable();
        BindingSource bs=new BindingSource();
        SqlDataAdapter da;
        
        


        public FormBibliothèqueDesLivres()
        {
            InitializeComponent();
        }
        private void FormBibliothèqueDesLivres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBib.livre' table. You can move, or remove it, as needed.
            this.livreTableAdapter.Fill(this.dataSetBib.livre);
            RemplirBind();
            Bind();
            RemplirCombo();

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        void Bind()
        {
            txtID.DataBindings.Add("Text", bs, "id",true);
            txtTitre.DataBindings.Add("Text", bs, "titre",true);
            txtAuteur.DataBindings.Add("Text", bs, "auteur",true);
            txtEdition.DataBindings.Add("Text", bs, "edition",true);
            pictureBoxPhoto.DataBindings.Add("ImageLocation", bs, "photo");
            
            checkboxDisponible.DataBindings.Add("Checked", bs, "disponibilite", true);
            comboCat.DataBindings.Add("SelectedValue", bs, "id_cat",true);
            numericUpDownQtt.DataBindings.Add("Value", bs, "quantite", true);
            
           
        }
        void RemplirCombo() {
            using (SqlConnection cn =new SqlConnection(strcn))
            {
                SqlCommand cmd = new SqlCommand("Select * from categorie",cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr);
 
                comboCat.DataSource = dt2;
                comboCat.DisplayMember = "nom";
                comboCat.ValueMember = "id";
                
            }
            using (SqlConnection cn = new SqlConnection(strcn))
            {
                SqlCommand cmd = new SqlCommand("Select * from categorie", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr);

                DataRow row = dt2.NewRow();
                row[0] = 0;
                row[1] = "Tous Les Catégories";
                dt2.Rows.InsertAt(row, 0);

                comboGroupBy.DataSource = dt2;
                comboGroupBy.DisplayMember = "nom";
                comboGroupBy.ValueMember = "id";
            }
                

        }
        void RemplirBind(){


            cn.ConnectionString = strcn;
                da = new SqlDataAdapter("select * from livre", cn);
                cn.Open();
                da.Fill(dt);
                SqlCommandBuilder cmdbuild = new SqlCommandBuilder(da);
                bs.DataSource = dt;
                dgvLivre.DataSource = bs;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    comboTri.Items.Add(dt.Columns[i].ColumnName);
                }

        }
      

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            if (btnNouveau.Text == "Nouveau")
            {
                btnNouveau.Text = "Ajouter";
                bs.AddNew();
                txtID.Text = bs.Count.ToString();
                numericUpDownQtt.Value = 1;
                checkboxDisponible.Checked = true;
            }
            else
            {
                btnNouveau.Text = "Nouveau";
                bs.EndEdit();
                MessageBox.Show("Bien Ajouter (Sans Enregister)");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            MessageBox.Show("Bien Modifier (Sans Enregister)");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep =MessageBox.Show("Suppression","Voulez vous Supprimer ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                bs.RemoveCurrent();
                MessageBox.Show("Bien Modifier (Sans Enregister)");
            }
           
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            MessageBox.Show("Bien Enregister");
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofd.Multiselect = false;
            DialogResult rep = ofd.ShowDialog();
            if (rep == DialogResult.OK)
            {
               
                FileInfo f = new FileInfo(ofd.FileName);
                string Path = @"photo_livre\" + f.Name;
                f.CopyTo( Path,true);
                pictureBoxPhoto.ImageLocation = Path;

            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPreviews_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
           int pos= bs.Find("id", txtCherch.Text);
           bs.Position = pos;
        }

        private void comboTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.Sort = comboTri.Text;
        }

        private void comboGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboGroupBy.SelectedIndex != 0)
                    bs.Filter = "id_cat=" + comboGroupBy.SelectedValue.ToString();
                else
                    bs.Filter = "";
            }
            catch (Exception)
            {
                
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnAddCat.Text == "+")
            {
                comboCat.Visible = false;
                btnAddCat.Text = "Ajouter";
                Size s = new System.Drawing.Size(88, 29);
                btnAddCat.Size = s;
                buttonDelCat.Visible = false;
            }
            else
            {
                if (txtcategorie.Text != "")
                {
                    addCategorie();
                    comboCat.Visible = true;
                    btnAddCat.Text = "+";
                    Size s = new System.Drawing.Size(23, 29);
                    btnAddCat.Size = s;
                   
                    buttonDelCat.Visible = true;
                    txtcategorie.Text = "";
                }
                else
                {
                    comboCat.Visible = true;
                    btnAddCat.Text = "+";
                    Size s = new System.Drawing.Size(23, 29);
                    btnAddCat.Size = s;
                    MessageBox.Show("Operation Annuler");
                    buttonDelCat.Visible = true;
                }

            }
            
        }

        private void addCategorie()
        {
            using (SqlConnection cn =new SqlConnection(strcn) )
            {
                 SqlCommand cmd = new SqlCommand("insert into categorie(nom) values (@nom)", cn);
                 cmd.Parameters.AddWithValue("@nom", txtcategorie.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bien Ajouter");
                    RemplirCombo();
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
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

        private void numericUpDownQtt_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownQtt.Value == 0)
            {
                checkboxDisponible.Checked = false;
            }
            else
            {
                checkboxDisponible.Checked = true;

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboCat.SelectedIndex != 0)
            {

                int id = int.Parse(comboCat.SelectedValue.ToString());
                DialogResult rep = MessageBox.Show("Suppression", "Voulez vous Supprimer ce categorie ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    using (SqlConnection cn = new SqlConnection(Program.strcn))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = cn;
                        cmd.CommandText = "Delete from categorie where id=@id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bien Supprimer");
                        RemplirCombo();
                        

                    }
                }
            }
        }

      

        


       

        
    }
}
