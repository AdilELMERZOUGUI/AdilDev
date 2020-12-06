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
    public partial class Modifier_Patient : DevExpress.XtraEditors.XtraForm
    {
        PatientDao patientDao = new PatientDao();
        private int iD_patient;

        public Modifier_Patient()
        {
            InitializeComponent();
            
        }

        public Modifier_Patient(int iD_patient)
        {
            InitializeComponent();
            this.iD_patient = iD_patient;
        }


        private void Modifier_Patient_Load(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            
               
            var pat = patientDao.patients.FirstOrDefault(p => p.id_patient == iD_patient);

             txtNom.Text = pat.nom.ToUpper();
             txtPrenom.Text = textInfo.ToTitleCase(pat.prenom);
             txtTel.Text = pat.tel ;
             txtAdress.Text = pat.adresse ;
             comboMutuel.Text = pat.mutuel;
             txtObserv.Text = pat.observation;


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                var pat = patientDao.patients.FirstOrDefault(p => p.id_patient == iD_patient);

                pat.nom = txtNom.Text.ToUpper();
                pat.prenom = textInfo.ToTitleCase(txtPrenom.Text);
                pat.tel = txtTel.Text;
                pat.adresse = txtAdress.Text;
                pat.mutuel = comboMutuel.Text;
                pat.observation = txtObserv.Text;
                
                
                string toastID = "3a7b24ab-1309-425c-9c61-99b619d93192";
                toastEdit.ShowNotification(toastID);
                patientDao.Update(pat);
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