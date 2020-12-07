using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothique
{
    public partial class FormGestionDesEleves : Form
    {
        BindingSource bs = new BindingSource();
        public FormGestionDesEleves()
        {
            InitializeComponent();
        }

        private void FormGestionDesEleves_Load(object sender, EventArgs e)
        {
          
            RemplirCombo();

            RemplirGrid();
            
      
        }

        public  DataTable Get(string sqlcmd)
        {

            SqlConnection cn = new SqlConnection(Program.strcn);
            SqlCommand cmd = new SqlCommand(sqlcmd, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            cn.Close();


            for (int i = 0; i < dt.Columns.Count-2; i++)
            {
                comboBoxTri.Items.Add(dt.Columns[i].ColumnName);
            }
           

            return dt;

        }

        void RemplirGrid()
        {
            

            bs.DataSource = Get(@"SELECT eleve.id, eleve.nom, eleve.prenom, eleve.datenaiss,id_classe,'Confirmer' as Confirmer,'Supprimer' as Supprimer FROM  eleve  ");
            dataGridViewEleve.DataSource = bs;
        }

        void RemplirCombo()
        {

            DataTable dt1 = Get("select id as id_classe , nom from classe");
            ComboClasse.DataSource = dt1;
            ComboClasse.DisplayMember = "nom";
            ComboClasse.ValueMember = "id_classe";

            DataTable dt = Get("select id as id_classe , nom from classe");
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Tous Les Classes";
            dt.Rows.InsertAt(row, 0);
            
          comboFilter.DataSource = dt;
          comboFilter.DisplayMember = "nom";
          comboFilter.ValueMember = "id_classe";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                    Application.OpenForms[i].Close();
                else
                    Application.OpenForms[i].Show();
            }
        
        }

        private void btnCherch_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Find("id", txtCherch.Text);
        }

        private void comboBoxTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.Sort = comboBoxTri.Text;
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (comboFilter.SelectedIndex != 0)
                    bs.Filter = "id_classe=" + comboFilter.SelectedValue.ToString() ;
                else
                    bs.Filter = "";
            }
            catch (Exception)
            {


            }
            
        }

        private void dataGridViewEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    int id = int.Parse(dataGridViewEleve.CurrentRow.Cells[0].Value.ToString());
                    string nom = dataGridViewEleve.CurrentRow.Cells[1].Value.ToString();
                    string prenom = dataGridViewEleve.CurrentRow.Cells[2].Value.ToString();
                    DateTime dn = DateTime.Parse(dataGridViewEleve.CurrentRow.Cells[3].Value.ToString());
                    int id_classe = int.Parse(dataGridViewEleve.CurrentRow.Cells[4].Value.ToString());
                    using (SqlConnection cn = new SqlConnection(Program.strcn))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "confirmer";
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@dn", dn);
                        cmd.Parameters.AddWithValue("@id_classe", id_classe);
                        cmd.Parameters.AddWithValue("@id", id);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bien Confirmer");
                        RemplirGrid();
                         
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    int id = int.Parse(dataGridViewEleve.CurrentRow.Cells[0].Value.ToString());
                     DialogResult rep =MessageBox.Show("Suppression","Voulez vous Supprimer ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                     if (rep == DialogResult.Yes)
                     {
                         using (SqlConnection cn = new SqlConnection(Program.strcn))
                         {
                             SqlCommand cmd = new SqlCommand();
                             cmd.Connection = cn;
                             cmd.CommandText = "Delete from eleve where id=@id";
                             cmd.Parameters.AddWithValue("@id", id);
                             cn.Open();
                             cmd.ExecuteNonQuery();
                             bs.RemoveCurrent();
                             MessageBox.Show("Bien Supprimer");
                             RemplirGrid();
                         }
                     }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        { 
            if (btnAddCat.Text == "+")
            {
                comboFilter.Visible = false;

                btnAddCat.Font = new Font(btnAddCat.Font.Name, 10.25F,FontStyle.Bold);
                btnAddCat.Text = "Ajouter";
                
                Size s = new System.Drawing.Size(88, 29);
                btnAddCat.Size = s;
                buttonDelClasse.Visible = false;

            }
            else
            {
                if (txtClasse.Text != "")
                {
                    addClasse();
                    comboFilter.Visible = true;
                    btnAddCat.Font = new Font(btnAddCat.Font.Name, 14.25F, FontStyle.Bold);
                    btnAddCat.Text = "+";
                    Size s = new System.Drawing.Size(32, 29);
                    buttonDelClasse.Visible = true;
                    btnAddCat.Size = s;
                    RemplirCombo();
                    RemplirGrid();
                    txtClasse.Text = "";

                }
                else
                {
                    comboFilter.Visible = true;
                    btnAddCat.Font = new Font(btnAddCat.Font.Name, 14.25F, FontStyle.Bold);
                    btnAddCat.Text = "+";
                    Size s = new System.Drawing.Size(32, 29);
                    buttonDelClasse.Visible = true;
                    btnAddCat.Size = s;

                    MessageBox.Show("Operation Annuler");
                }

            }
        }

        private void addClasse()
        {
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into classe(nom) values (@nom) ";
                cmd.Parameters.AddWithValue("@nom", txtClasse.Text);
               cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Bien Ajouter");
                
                RemplirCombo();
                RemplirGrid();
                
            }
        }

        private void dataGridViewEleve_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dataGridViewEleve_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void dataGridViewEleve_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[5].Value = "Confirmer";
            e.Row.Cells[6].Value = "Supprimer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboFilter.SelectedIndex!=0)
            {
                
           

            int id = int.Parse(comboFilter.SelectedValue.ToString());
            DialogResult rep = MessageBox.Show("Suppression", "Voulez vous Supprimer cette classe ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                using (SqlConnection cn = new SqlConnection(Program.strcn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "Delete from classe where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Bien Supprimer");
                    RemplirCombo();
                    RemplirGrid();

                }
            }
        }

       }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
