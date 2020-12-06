using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevApp1.Forms;
using DevApp1.Models;
using DevApp1.Repository;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Reflection;
using DevApp1.Properties;

namespace DevApp1.Forms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        UserDao userDao = new UserDao(); 
        RdvDao rdvDao = new RdvDao(); 

        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

            GetLogin();



        }

        private void Login_Activated(object sender, EventArgs e)
        {
            GetLogin();
        }

        private void GetLogin()
        {
            try
            {
                if (testConnecton())
                {
                    var users = userDao.utilisteurs.Select(u => new
                    {
                        ID = u.id_user,
                        Nom = u.nom.ToUpper() + " " + u.prenom.ToUpper()
                    });

                    comboUsers.DataSource = users.ToList();
                    comboUsers.ValueMember = "ID";
                    comboUsers.DisplayMember = "Nom";
                    labelTest.Text = "Connecté";
                    labelTest.ForeColor = Color.LimeGreen;
                    progressPanel1.Hide();
                }

                else
                {
                    {

                        progressPanel1.Hide();
                        labelTest.Text = "Déconnecté";
                        labelTest.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
                timer1.Stop();
                progressPanel1.Hide();
            }
        }

        

        private void Setlogin()
        {
            try
            {


                var id = Convert.ToInt32(comboUsers.SelectedValue);
                var pw = txtPw.Text;
                var user = userDao.utilisteurs.FirstOrDefault(u => u.id_user == id && u.password == pw);
                if (user != null)
                {
                    Program.ID_user = id;

                    var Frm = new Home();

                    Frm.Show();

                }
                else
                {
                    timer1.Stop();
                    progressPanel1.Hide();
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "Mot de passe incorrect !");
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
                timer1.Stop();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            progressPanel1.Show();
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Setlogin();
            timer1.Stop();
        }

         private bool testConnecton()
        {
            var con = ConfigurationManager.ConnectionStrings["mainEntities"].ConnectionString;
           
            //MessageBox.Show(con);

            using (mainEntities dbContext = new mainEntities())
            {
                return dbContext.Database.Exists();
            }



        }

        private void labelTest_DoubleClick(object sender, EventArgs e)
        {
            var frm = new repairSource();
            frm.ShowDialog();
        }

       
    }
}