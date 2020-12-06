using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DevApp1.Repository;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevApp1.Forms
{
    public partial class Consultation_Patient : DevExpress.XtraEditors.XtraForm
    {
        private ConsultationDao consultationDao = new ConsultationDao();
        private PatientDao patientDao = new PatientDao();
        private RdvDao rdvDao = new RdvDao();
        private int id_RDV;
        private long id_pat;
        

        public Consultation_Patient()
        {
            InitializeComponent();
        }

      

        public Consultation_Patient(int id_RDV, long id_pat) 
        {
            InitializeComponent();
            this.id_RDV = id_RDV;
            this.id_pat = id_pat;
        }

       

        private void Consultation_Patient_Load(object sender, EventArgs e)
        {
            getConsultation();
            
        }

        private void getConsultation()
        {
          
            gridSalleTr.DataSource = consultationDao.consultations.Where(c=>c.rendez_vous.id_patient==id_pat).ToList().Select(p => new {
              ID = p.id_conslt,
              Date = p.rendez_vous.date_rdv,
              Acte = p.acte.titre_acte,
              Details= p.details,
              Total_Payer = p.payement.montant +" DH",
              Total_recu = p.payement.avance + " DH",
              Reste =p.payement.montant - p.payement.avance +" DH" 
              
            }).OrderByDescending(r => r.Date).ToList();

            var pat = patientDao.Find(Convert.ToInt32(id_pat));
            lblNom.Text = pat.nom;
            lblPrenom.Text = pat.prenom;
            lblTel.Text = pat.tel;
            lblMutuel.Text = pat.mutuel;
            lbl_adress.Text = pat.adresse;
            lbl_observ.Text = pat.observation;

           
        }

        private void UpdatePayement()
        {
            double num = 0;

            var res = consultationDao.consultations.ToList()
                       .Where(r =>r.rendez_vous.id_patient==id_pat)
                       .GroupBy(x => x.rendez_vous.id_patient)
                       .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
            foreach (var item in res)
            {
                num += item.total.Value;
            }

            var rdv = rdvDao.Find(id_RDV);
            

            if (num >0)
            {
                rdv.payer = 0;
            }
            else
            {
                rdv.payer = 1;
            }

            rdvDao.Update(rdv);

        }

        private void btn_Add_Consultation_Click(object sender, EventArgs e)
        {

            var Frm = new Ajouter_Consultation(id_RDV, id_pat);
            Frm.ShowDialog();
        }

        private void Consultation_Patient_Activated(object sender, EventArgs e)
        {
            getConsultation();
            UpdatePayement();
        }

        private int GetID_Consult()
        {
            try
            {
                int[] selectedRows = gridViewConsult.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewConsult.GetRowCellValue(rowHandle, "ID");
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

            private void btnComboConsult_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index==1)
            {
                var Frm = new Modifier_Consultation(GetID_Consult() , id_pat);
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
                        consultationDao.Delete(GetID_Consult());
                        string toastID = "ff3f8021-4b59-4919-b8e3-0d66a6960203";
                        toastDel.ShowNotification(toastID);
                        getConsultation();
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