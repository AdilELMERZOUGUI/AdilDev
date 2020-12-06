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
using DevApp1.Properties;

namespace DevApp1.Forms
{
    public partial class Modifier_RDV : DevExpress.XtraEditors.XtraForm
    {
        private int id_rdv;
        private RdvDao rdvDao = new RdvDao();
        public Modifier_RDV()
        {
            InitializeComponent();
        }

        public Modifier_RDV(int id_rdv)
        {
            InitializeComponent();
            this.id_rdv = id_rdv;
        }

        private void Modifier_RDV_Load(object sender, EventArgs e)
        {
            var rdv = rdvDao.Find(id_rdv);
            comboPeriode.Text = rdv.seance;
            dateRDV.DateTime = DateTime.Parse(rdv.date_rdv);
            checkTrait.Checked = Convert.ToBoolean(rdv.traiter);
            checkTerminer.Checked = Convert.ToBoolean(rdv.terminer);
            ckboxDisponible.Checked = Convert.ToBoolean(rdv.disponible);
            lblNom.Text = rdv.patient.nom + " " + rdv.patient.prenom;
            getNbRDV();

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var rdv = rdvDao.Find(id_rdv);

                rdv.date_rdv = dateRDV.DateTime.ToString("yyyy-MM-dd");
                rdv.seance = comboPeriode.Text;
                rdv.terminer = Convert.ToInt32(checkTerminer.Checked);
                rdv.traiter = Convert.ToInt32(checkTrait.Checked);
                rdv.disponible = Convert.ToInt32(ckboxDisponible.Checked);

                rdvDao.Update(rdv);

                string toastID = "ce7b449f-6666-467e-a98c-12e0817abd0a";
                toastEdit.ShowNotification(toastID);
                Application.OpenForms["Historique_RDV"].Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
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