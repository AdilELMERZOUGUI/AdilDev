using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevApp1.Repository;
using DevApp1.Models;
using DevExpress.XtraBars.ToastNotifications;
using System.Globalization;
using System.Threading;

namespace DevApp1.Forms
{
    public partial class Ajouter_Patient : DevExpress.XtraEditors.XtraForm
    {
        PatientDao patientDao = new PatientDao();

        public Ajouter_Patient()
        {
            InitializeComponent();
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                patient pat = new patient
                {
                    nom = txtNom.Text.ToUpper(),
                    prenom = textInfo.ToTitleCase(txtPrenom.Text),
                    tel = txtTel.Text,
                    adresse = txtAdress.Text,
                    mutuel=comboMutuel.Text,
                    observation = txtObserv.Text
                };

                patientDao.Add(pat);
                string toastID = "3a7b24ab-1309-425c-9c61-99b619d93192";
                toastAdd.ShowNotification(toastID);
                Application.OpenForms["Home"].Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
            }
           


        }
    }
}