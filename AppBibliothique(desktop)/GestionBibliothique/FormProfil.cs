using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionBibliothique
{
    public partial class FormProfil : Form
    {
       
        FormHome f=new FormHome();
        public FormProfil()
        {
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            RemplirChamps();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
            
        }

       

        void RemplirChamps()
        {
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand("Select * from utilisateur where id=1", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                txtNom.Text = dt.Rows[0][1].ToString();
                txtPrenom.Text = dt.Rows[0][2].ToString();
                txtUser.Text = dt.Rows[0][3].ToString();
                txtPw.Text = dt.Rows[0][4].ToString();
                pictureBoxPhotoUser.ImageLocation = dt.Rows[0][5].ToString();




            }

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Program.strcn))
                {
                    SqlCommand cmd = new SqlCommand("update utilisateur set nom=@nom ,prenom=@prenom,username=@user,pw=@pw,photo=@photo where id=1", cn);

                    cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@pw", txtPw.Text);

                    cmd.Parameters.AddWithValue("@photo", pictureBoxPhotoUser.ImageLocation);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    Program.photo = pictureBoxPhotoUser.ImageLocation;

                    MessageBox.Show("Bien Modifier");

                    FormHome f = new FormHome();
                    f.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                ofd.Multiselect = false;
                DialogResult rep = ofd.ShowDialog();
                if (rep == DialogResult.OK)
                {
                    FileInfo f = new FileInfo(ofd.FileName);
                    string path = "photo_admin" + f.Name;
                    f.CopyTo(path, true);
                    pictureBoxPhotoUser.ImageLocation = path;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "FormProfil")
                    {
                        Application.OpenForms[i].Hide();
                        FormHome f = new FormHome();
                        f.ShowDialog();

                    }



                }

            }
        
            catch (Exception )
            {
                
             
            }
        }
        }
}
       

        

     

       
