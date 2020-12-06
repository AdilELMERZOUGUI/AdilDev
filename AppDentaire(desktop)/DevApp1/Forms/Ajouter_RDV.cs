using System;
using DevApp1.Forms;
using DevApp1.Models;
using DevApp1.Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevApp1.Properties;

namespace DevApp1.Forms
{
    public partial class Ajouter_RDV : DevExpress.XtraEditors.XtraForm
    {
        private PatientDao patientDao = new PatientDao();
        private RdvDao rdvDao = new RdvDao();
        private int iD_patient;

        public Ajouter_RDV()
        {
            InitializeComponent();
        }

        public Ajouter_RDV(int iD_patient)
        {
            InitializeComponent();
            this.iD_patient = iD_patient;
        }

        private void Ajouter_RDV_Load(object sender, EventArgs e)
        {
            var pat = patientDao.Find(iD_patient);
            lblNom.Text = pat.nom + " " + pat.prenom;
            dateRDV.DateTime = DateTime.Now;
            getNbRDV();



        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                rendez_vous rdv = new rendez_vous
                {
                    id_patient = iD_patient,
                    date_rdv = dateRDV.DateTime.ToString("yyyy-MM-dd"),
                    seance = comboPeriode.Text,
                    id_user = 2,
                    disponible = Convert.ToInt32(ckboxDisponible.Checked),
                    traiter = 0,
                    payer = 0 ,
                    terminer = 0
                };

                rdvDao.Add(rdv);
                string toastID = "3cc53fe8-e357-4b86-b11f-493dc4e86bec";
                toastAdd.ShowNotification(toastID);
                getNbRDV();
                Application.OpenForms["Home"].Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
            }

        }

        private void getNbRDV()
        {
            DateTime Date = dateRDV.DateTime;
            string periode = comboPeriode.Text;

            var Nbrdv = rdvDao.rendez_vouss
                .ToList()
                .Where(r => DateTime.Parse(r.date_rdv).Date == Date.Date && r.seance == periode)
                .ToList()
                .Count();
            if (periode == "Matin")
            {
                lblNbRDV.Text = Nbrdv + "/" + Settings.Default.MaxMatin;
            }
            else
                lblNbRDV.Text = Nbrdv + "/" + Settings.Default.MaxSoir;
        }

        private void dateRDV_EditValueChanged(object sender, EventArgs e)
        {

            getNbRDV();

        }

        private void comboPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNbRDV();
        }
    }
}