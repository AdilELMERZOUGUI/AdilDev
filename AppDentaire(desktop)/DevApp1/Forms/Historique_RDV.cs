using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevApp1.DataAccessObject;
using DevApp1.Forms;
using DevApp1.Models;
using DevApp1.Repository;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevApp1.Forms
{
    public partial class Historique_RDV : DevExpress.XtraEditors.XtraForm
    {
        private PatientDao patientDao = new PatientDao();
        private RdvDao rdvDao = new RdvDao();
        private int iD_patient;

        public Historique_RDV()
        {
            InitializeComponent();
        }

        public Historique_RDV(int iD_patient)
        {
            InitializeComponent();
            this.iD_patient = iD_patient;
        }

        private void Historique_RDV_Load(object sender, EventArgs e)
        {
            GetRDV();
        }

        public void GetRDV()
        {
            gridHistorique.DataSource = rdvDao.rendez_vouss
                .Where(r=>r.id_patient==iD_patient)
                .Select(r=>new { 
                    ID = r.id_rdv ,
                    Date =r.date_rdv,
                    Periode=r.seance,
                    Passe = r.traiter== 0 ? "Non" :"Oui"
                    
                    }).OrderByDescending(r=>r.Date).ToList();
            var pat = patientDao.Find(iD_patient);
            lblNom.Text = pat.nom + " " + pat.prenom;
            
        }

        private int GetID_Rdv()
        {
            try
            {
                int[] selectedRows = gridViewhistorique.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewhistorique.GetRowCellValue(rowHandle, "ID");
                }

                int ID = int.Parse(cellValue.ToString());
                return ID;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
                return 0;
            }
        }

        private void btnComboRdv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var Frm = new Modifier_RDV(GetID_Rdv());
                Frm.ShowDialog();
            }
            else if (e.Button.Index == 2)
            {
                try
                {
                    string msg = "Voulez-vous supprimer ce patient ? ";
                    var Dialog = XtraMessageBox.Show(msg, "Suppression", MessageBoxButtons.YesNo);

                    if (Dialog == DialogResult.Yes)
                    {
                        rdvDao.Delete(GetID_Rdv());
                        string toastID = "ff3f8021-4b59-4919-b8e3-0d66a6960203";
                        toastDel.ShowNotification(toastID);
                        GetRDV();
                    }



                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }
            }
        }
    }
}