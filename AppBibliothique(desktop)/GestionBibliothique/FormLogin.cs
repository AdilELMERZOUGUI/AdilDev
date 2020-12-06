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
    public partial class FormLogin : Form
    {
        int val = 0;
        int moveX;
        int moveY;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            moveX = this.Location.X;
            moveY = this.Location.Y;
        }

        private void buttonEntrer_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) from utilisateur where username=@user and pw=@pw", cn);
                cmd.Parameters.AddWithValue("@user", textBoxUser.Text);
                cmd.Parameters.AddWithValue("@pw", textBoxPw.Text);
                cn.Open();
                int n = (int)cmd.ExecuteScalar();

                if (n > 0)
                {
                    if (chekBoxSave.Checked)
                    {
                        this.Hide();
                        FormHome f = new FormHome();
                        f.Show();

                        
                    }
                    else
                    {
                        this.Hide();
                        FormHome f = new FormHome();
                        f.Show();
                        textBoxUser.Clear();
                        textBoxPw.Clear();
                        
                    }

                    
                    
                }
                else
                {
                    MessageBox.Show("Vérifier Votre informations");
                }

                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == 1)
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            moveX = e.X;
            moveY = e.Y;
            val = 1;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            val = 0;
        }

    

       

      
    }
}
