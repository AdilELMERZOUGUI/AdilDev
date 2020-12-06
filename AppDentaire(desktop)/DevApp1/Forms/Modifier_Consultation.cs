using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using DevApp1.Repository;
using DevApp1.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevApp1.Forms
{
    public partial class Modifier_Consultation : DevExpress.XtraEditors.XtraForm
    {
        private int id_consult;
        private long id_pat;
        private ConsultationDao consultationDao = new ConsultationDao();
        private PatientDao patientDao = new PatientDao();
        private ActeDao acteDao = new ActeDao();
        private PayementDao payementDao = new PayementDao();

        public Modifier_Consultation()
        {
            InitializeComponent();
        }

        public Modifier_Consultation(int id_consult, long id_pat)
        {
            InitializeComponent();
            this.id_consult = id_consult;
            this.id_pat = id_pat;
        }

    
        private void Ajouter_Consultation_Load(object sender, EventArgs e)
        {
            GetActes();

        }



        private void GetActes()
        {
            //Remplir Combo
            comboActe.DataSource = acteDao.Get();
            comboActe.DisplayMember = "titre_acte";
            comboActe.ValueMember = "id_acte";

            //Remplir Labels
            var pat = patientDao.patients.FirstOrDefault(p => p.id_patient == id_pat);
            lblNom.Text = pat.nom;
            lblNom.Text += " " + pat.prenom;
            lbl_titre.Text = lbl_titre.Text.ToUpper();

            //Remplir infos
            var consult = consultationDao.Find(id_consult);
            comboActe.SelectedValue = consult.id_acte;
            txtDetail.Text = consult.details;
            txtMont_paye.Text = consult.payement.montant.ToString();
            txtMont_recu.Text = consult.payement.avance.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var consult = consultationDao.Find(id_consult);

                consult.id_acte = Convert.ToInt32(comboActe.SelectedValue);
                consult.details = txtDetail.Text;
                consult.payement.avance = double.Parse(txtMont_recu.Text);
                consult.payement.montant = double.Parse(txtMont_paye.Text);

            consultationDao.Update(consult);

            string toastID = "ce7b449f-6666-467e-a98c-12e0817abd0a";
            toastEdit.ShowNotification(toastID);
            Application.OpenForms["Consultation_Patient"].Activate();
            this.Close();
        }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

     
    }
}