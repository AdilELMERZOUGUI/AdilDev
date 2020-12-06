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
    public partial class Ajouter_Consultation : DevExpress.XtraEditors.XtraForm
    {
        private int id_RDV;
        private long id_pat;
        private ConsultationDao consultationDao = new ConsultationDao();
        private PatientDao patientDao = new PatientDao();
        private ActeDao acteDao = new ActeDao();
        private PayementDao payementDao = new PayementDao();

        public Ajouter_Consultation()
        {
            InitializeComponent();
        }

        public Ajouter_Consultation(int id_RDV, long id_pat)
        {
            InitializeComponent();
            this.id_RDV = id_RDV;
            this.id_pat = id_pat;
        }

    
        private void Ajouter_Consultation_Load(object sender, EventArgs e)
        {
            GetActes();
        }

        private void Ajouter_Consultation_Activated(object sender, EventArgs e)
        {
            GetActes();
        }

        private void GetActes()
        {
            comboActe.DataSource = acteDao.Get();
            comboActe.DisplayMember = "titre_acte";
            comboActe.ValueMember = "id_acte";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                consultation consult = new consultation
                {
                    id_acte = Convert.ToInt32(comboActe.SelectedValue) ,
                    id_rdv=id_RDV,
                    id_user=1,
                    details=txtDetail.Text,
                    payement=new payement
                    {
                        id_pay=id_RDV,
                        avance=double.Parse(txtMont_recu.Text),
                        montant= double.Parse(txtMont_paye.Text)
                    }


            };

            consultationDao.Add(consult);
            string toastID = "ce7b449f-6666-467e-a98c-12e0817abd0a";
            toastAdd.ShowNotification(toastID);
            Application.OpenForms["Consultation_Patient"].Activate();
            this.Close();
        }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
}

        private void linkAddActe_Click(object sender, EventArgs e)
        {
            var Frm = new Ajouter_Acte();
            Frm.ShowDialog();
        }
    }
}