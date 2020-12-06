using DevApp1.DataAccessObject;
using DevApp1.Forms;
using DevApp1.Models;
using DevApp1.Properties;
using DevApp1.Repository;
using DevExpress.CodeParser;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DevApp1
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        PatientDao patientDao = new PatientDao();
        RdvDao rdvDao = new RdvDao();
        ConsultationDao consultationDao = new ConsultationDao();
        UserDao userDao = new UserDao();
        Statistique statistique = new Statistique();
        SaveData saveData = new SaveData();
        readonly string[] toastID = {"fa658bf3-67ee-4983-97c8-b6d2471fb086",
                                     "1f257936-d64c-4ed6-8d1a-fdb915a692df",
                                     "064d6f36-a386-443b-9cb7-3618783874d1",
                                     "e59397b0-ffcc-4382-b07d-3998d942fea6",
                                     "3d16a244-f7b7-4618-992f-5aaa307d8ccb",
                                     "6d3fbca3-8bea-4b70-9537-7facf80e288b",
                                     "b78789ce-5210-45da-8c5a-15759bdb3d0a"
                                    };


        public Home()
        {
            InitializeComponent();
            
        }

        private void getUser()
        {
            var user = userDao.Find(Program.ID_user);

            if (user != null && user.role!= "Medecin")
            {
                MenuDoctor.Enabled = false;
                MenuDoctor.Expanded = false;
            }
            else
            {
                MenuDoctor.Enabled = true;
                MenuDoctor.Expanded = true;
            }

        }

        private void GetAll()
        {
            getUser();
            GetPatients();
            GetRendezVous();
            GetPresence();
            GetVisiteurs();
            GetStatistiques();
            GetUsers();
            GetDossier();
            
        }

        private void taps_Selecting(object sender, DevExpress.XtraTab.TabPageCancelEventArgs e)
        {
            if (e.Page == pat_tap) { GetAll(); }
            else if (e.Page == rdv_tap) { GetAll(); }
            else if (e.Page == salle_tap) { GetAll(); }
            else if (e.Page == salleTr_tap) { GetAll(); }
            else if (e.Page == users_tap) { }
            else { }

            
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            GetAll();
            datePrdv.DateTime = DateTime.Now;
            taps.SelectedTabPage = home_tap;
            lbl_titre.Text = "accueil".ToUpper();
            Application.OpenForms["Login"].Hide();
            labelNameApp.Text = Settings.Default.Name;
            timerLoad.Start();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            GetAll();
        }

        //------------------------ Sidebar Menu -------------------------\\
        //---------------------------------------------------------------\\

       
        private void home_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = home_tap;
            lbl_titre.Text = "accueil".ToUpper();
        }

        private void pat_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = pat_tap;
            lbl_titre.Text = "Patients".ToUpper();
        }

        private void rdv_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = rdv_tap;
            lbl_titre.Text = "Rendez-vous".ToUpper();
        }

        private void salle_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = salle_tap;
            lbl_titre.Text = "Salle d'attends".ToUpper();
        }

        private void user_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = users_tap;
            lbl_titre.Text = "Utilisateurs".ToUpper();
        }

        private void dossier_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = dossier_tab;
            lbl_titre.Text = "Dossier médical".ToUpper();
            
        }

        private void statics_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = statics_tap;
            lbl_titre.Text = "statistiques".ToUpper();
        }
        
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = salleTr_tap;
            lbl_titre.Text = "Salle du Traitement".ToUpper();
        }

        private void settings_page_Click(object sender, EventArgs e)
        {
            taps.SelectedTabPage = settings_tap;
            lbl_titre.Text = "Paramètres".ToUpper();
        }



        //---------------------------------------------------------------\\


        //------------------------ Gestion des Patients -------------------------\\


        private void txtFilter_MouseEnter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "chercher ...")
            {
                txtFilter.Text = "";

                txtFilter.Focus();
            }
        }

        private void txtFilter_MouseLeave(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {

                txtFilter.Text = "chercher ...";

                btnAddPatient.Focus();
            }
        }


        private void GetPatients()
        {
            gridPatients.DataSource = patientDao.Get();
            lblTotal.Text = patientDao.Get().Count.ToString();
            txtFilter.Text = "chercher ...";


        }

        private int GetID_Patient()
        {
            try
            {
                int[] selectedRows = gridViewPatients.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewPatients.GetRowCellValue(rowHandle, "id_patient");
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var form = new Ajouter_Patient();
            
            form.ShowDialog();
        }

        private void txtFilter_EditValueChanged(object sender, EventArgs e)
        {
            string nom = txtFilter.Text;
            if (nom.Equals("chercher ...")) return ;
            var patients = patientDao.patients.Where(p => p.nom.Contains(nom) || p.prenom.Contains(nom) || p.mutuel.Contains(nom)).ToList();
            gridPatients.DataSource = patients;
            lblTotal.Text = patients.Count.ToString();
        }

        


        private void btnActionCombo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            int ID_patient = GetID_Patient();

            if (e.Button.Index == 1)
            {

                try
                {
                    var Frm = new Historique_RDV(ID_patient);
                    Frm.ShowDialog();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }

            }

            else if(e.Button.Index == 2)
            {
                try
                {
                    var Frm = new Modifier_Patient(ID_patient);
                    Frm.ShowDialog();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }

            }
            else if (e.Button.Index == 3)
            {
                try
                {
                    string msg = "Voulez-vous supprimer ce patient ? ";
                    var Dialog = XtraMessageBox.Show(msg, "Suppression",MessageBoxButtons.YesNo);

                    if (Dialog == DialogResult.Yes)
                    {
                    patientDao.Delete(ID_patient);
                    toast.ShowNotification(toastID[0]);
                        GetPatients();
                    }
                    
                   
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
                }

            }
            else if (e.Button.Index == 4)
            {
                try
                {
                    var Frm = new Ajouter_RDV(ID_patient);
                    Frm.ShowDialog();
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }

            }
            else { }
        }

        //-----------------------------------------------------------------------\\

        //------------------------ Gestion des Rendez-vous -------------------------\\
        

        private void GetRendezVous()
        {
            string dateRdv = datePrdv.DateTime.ToString("yyyy-MM-dd");
            string periode = comboPeriode.Text;

            gridRdvs.DataSource = rdvDao.rendez_vouss.Where(r => r.date_rdv.Equals(dateRdv) && r.seance.Equals(periode) && r.traiter == 0 && r.disponible==0 && r.terminer == 0).Select(p => new {
                ID = p.id_rdv,
                Nom = p.patient.nom + " " + p.patient.prenom,
                Tel = p.patient.tel,
                
            }).ToList();

        }

        private int GetID_Rdv()
        {
            try
            {
                int[] selectedRows = gridViewRdv.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewRdv.GetRowCellValue(rowHandle, "ID");
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

        private void datePrdv_EditValueChanged(object sender, EventArgs e)
        {
            GetRendezVous();
           
        }

        private void comboPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRendezVous();
            
        }

      

        private void gridViewRdv_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
            
           
        }

       

        private void BtnLinkDisponible_Click(object sender, EventArgs e)
        {

            var id_RDV = GetID_Rdv();



            try
            {

                string msg = "Voulez-vous que ce patient soit présent ? ";
                var Dialog = XtraMessageBox.Show(msg, "Validation", MessageBoxButtons.YesNo);

                if (Dialog == DialogResult.Yes)
                {
                    var rdv = rdvDao.Find(id_RDV);

                    rdv.disponible = 1;
                    rdvDao.Update(rdv);
                    toast.ShowNotification(toastID[1]);
                    GetAll();
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
            }
        }

        //-----------------------------------------------------------------------\\

        //------------------------ Gestion De Salle d'Attends -------------------------\\
        

        private void GetPresence()
        {
            string dateRdv = datePrdv.DateTime.ToString("yyyy-MM-dd");
            string periode = comboPeriode.Text;

            gridSalleAtt.DataSource = rdvDao.rendez_vouss.Where(r => r.date_rdv.Equals(dateRdv) && r.seance.Equals(periode) && r.traiter == 0 && r.disponible == 1 && r.terminer == 0).Select(p => new {
                ID = p.id_rdv,
                Nom = p.patient.nom + " " + p.patient.prenom,
                Tel = p.patient.tel
            }).ToList();

        }

        private int GetID_SalleAtt()
        {
            try
            {
                int[] selectedRows = gridViewSalleAtt.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewSalleAtt.GetRowCellValue(rowHandle, "ID");
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

        private void btnLinkSalleAtt_Click(object sender, EventArgs e)
        {
            var id_RDV = GetID_SalleAtt();


            try
            {

                string msg = "Ce patient entrera-t-il dans la salle de traitement ?";

                var Dialog = XtraMessageBox.Show(msg, "Validation", MessageBoxButtons.YesNo);

                if (Dialog == DialogResult.Yes)
                {
                    var rdv = rdvDao.Find(id_RDV);

                    rdv.traiter =  1;
                    rdvDao.Update(rdv);
                    toast.ShowNotification(toastID[2]);
                    GetAll();
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
            }
        }

        //----------------------------------------------------------------------\\
        
        //------------------------ Gestion des Visiteurs -------------------------\\
        private void GetVisiteurs()
        {
            string dateRdv = datePrdv.DateTime.ToString("yyyy-MM-dd");
            string periode = comboPeriode.Text;


            gridSalleTr.DataSource = rdvDao.rendez_vouss.Where(r => r.date_rdv.Equals(dateRdv) && r.seance.Equals(periode) && r.traiter == 1 && r.disponible == 1 && r.terminer == 0).Select(p => new {
                ID = p.id_rdv,
                Nom = p.patient.nom + " " + p.patient.prenom,
                Tel = p.patient.tel,
                Payement = p.payer == 0 ? "incomplet" : "complet"

            }).ToList();
            
        }

        private int GetID_SalleTr()
        {
            try
            {
                int[] selectedRows = gridViewSalleTr.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewSalleTr.GetRowCellValue(rowHandle, "ID");
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

       

        private void btnComboVisit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id_RDV = GetID_SalleTr();

            if (e.Button.Index == 1)
            {
                try
                {
                    var rdv = rdvDao.Find(id_RDV);

                    long id_pat = rdv.id_patient;

                    var Frm = new Consultation_Patient(id_RDV,id_pat);
                   Frm.ShowDialog();

                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }

            }

            else if (e.Button.Index == 2)
            {
                try
                {
                    string msg = "Ce patient a-t-il mis fin à la visite ?";

                    var Dialog = XtraMessageBox.Show(msg, "Validation", MessageBoxButtons.YesNo);

                    if (Dialog == DialogResult.Yes)
                    {
                        var rdv = rdvDao.Find(id_RDV);
                        rdv.terminer = 1;
                        rdvDao.Update(rdv);
                        toast.ShowNotification(toastID[3]);
                        GetAll();
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

                }

            }
        }

        private void UpdatePayement()
        {
            if (GetID_SalleTr() == 0) return;
            double num = 0;
            var rdv = rdvDao.Find(GetID_SalleTr());
            var id_pat = rdv.id_patient;

            var res = consultationDao.consultations.ToList()
                       .Where(r => r.rendez_vous.id_patient == id_pat)
                       .GroupBy(x => x.rendez_vous.id_patient)
                       .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
            foreach (var item in res)
            {
                num += item.total.Value;
            }

            if (num > 0)
            {
                rdv.payer = 0;
            }
            else
            {
                rdv.payer = 1;
            }

            rdvDao.Update(rdv);

        }


        //----------------------------------------------------------------------\\

        //------------------------ Gestion des Statistique -------------------------\\

        private void labelClick(string labelName)
        {
            foreach (Control x in this.panel6.Controls)
            {
                if (x is LabelControl)
                {
                    if (!x.Name.Equals(labelName))
                    {
                        x.ForeColor = Color.FromArgb(124, 173, 177);


                    }
                    else
                    {
                        x.ForeColor = Color.Black;
                      
                    }
                }
            }


        }
        
        private void GetStatistiques()
        {
            labelClick("lblToday");

            lblAttends.Text = statistique.GetNbAttends(comboPeriode.Text, datePrdv.DateTime);
            lblPatients.Text = statistique.GetNbPatient(0).ToString();
            lblVisites.Text = statistique.GetNbVisite(0).ToString();
            lblRevenu.Text = statistique.GetNbRevenu(0).ToString() + " DH";
            lblDette.Text = statistique.GetNbDette(0).ToString() + " DH";

        }
        private void lblToday_Click(object sender, EventArgs e)
        {

            try
            {
                labelClick("lblToday");

                lblPatients.Text = statistique.GetNbPatient(0).ToString();
                lblVisites.Text = statistique.GetNbVisite(0).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(0).ToString() + " DH";
                lblDette.Text = statistique.GetNbDette(0).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }

        }

        private void lblYesterday_Click(object sender, EventArgs e)
        {
            try
            {
                labelClick("lblYesterday");

                lblPatients.Text = statistique.GetNbPatient(1).ToString();
                lblVisites.Text = statistique.GetNbVisite(1).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(1).ToString() + " DH";
                lblDette.Text = statistique.GetNbDette(1).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void lblWeek_Click(object sender, EventArgs e)
        {
            try
            {
                
                labelClick("lblWeek");

                lblPatients.Text = statistique.GetNbPatient(2).ToString();
                lblVisites.Text = statistique.GetNbVisite(2).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(2).ToString() + " DH";
                lblDette.Text = statistique.GetNbDette(2).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void lblMois_Click(object sender, EventArgs e)
        {
            try
            {
                labelClick("lblMois");

                lblPatients.Text = statistique.GetNbPatient(3).ToString();
                lblVisites.Text = statistique.GetNbVisite(3).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(3).ToString() + " DH";
                lblDette.Text = statistique.GetNbDette(3).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void lblYear_Click(object sender, EventArgs e)
        {
            try
            {
                labelClick("lblYear");

                lblPatients.Text = statistique.GetNbPatient(4).ToString();
                lblVisites.Text = statistique.GetNbVisite(4).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(4).ToString() + " DH";
                lblDette.Text = statistique.GetNbDette(4).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void lblAllday_Click(object sender, EventArgs e)
        {
            try
            {
                labelClick("lblAllday");

                lblPatients.Text = statistique.GetNbPatient(5).ToString();
                lblVisites.Text = statistique.GetNbVisite(5).ToString();
                lblRevenu.Text = statistique.GetNbRevenu(5).ToString()+" DH";
                lblDette.Text = statistique.GetNbDette(5).ToString() + " DH";
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }
        //-------------------------------------------------------------------------\\

        //------------------------ Gestion des Utilisateurs -------------------------\\
        
        private void GetUsers()
        {
            var users = userDao.utilisteurs.Select(u => new { 
            ID = u.id_user,
            Nom = u.nom +" "+ u.prenom,
            Tel = u.tel,
            Role = u.role,
            }).ToList();

            gridUsers.DataSource = users;
        }

        private int GetID_User()
        {
            try
            {
                int[] selectedRows = gridViewUsers.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewUsers.GetRowCellValue(rowHandle, "ID");
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

        private void gridViewUsers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var user = userDao.Find(GetID_User());

              txtNom.Text= user.nom;
              txtPrenom.Text= user.prenom;
              txtTel.Text= user.tel;
              txtPw.Text = user.password;
              comboRole.Text= user.role;
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            try
            {
                var user = new utilisteur
                {
                    nom = txtNom.Text.ToUpper(),
                    prenom = textInfo.ToTitleCase(txtPrenom.Text),
                    tel = txtTel.Text,
                    password=txtPw.Text,
                    role=comboRole.Text,

                };

                userDao.Add(user);
                toast.ShowNotification(toastID[4]);
                GetAll();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);
               
            }
        }



        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                var user = userDao.Find(GetID_User());

                user.nom = txtNom.Text.ToUpper();
                user.prenom = textInfo.ToTitleCase(txtPrenom.Text);
                user.tel = txtTel.Text;
                user.password = txtPw.Text;
                user.role = comboRole.Text;

                
                userDao.Update(user);
                toast.ShowNotification(toastID[5]);
                GetAll();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Voulez-vous supprimer ce utilisateur ? ";
                var Dialog = XtraMessageBox.Show(msg, "Suppression", MessageBoxButtons.YesNo);

                if (Dialog == DialogResult.Yes)
                {
                    patientDao.Delete(GetID_User());
                    toast.ShowNotification(toastID[6]);
                    GetAll();

                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        //-------------------------------------------------------------------------\\

        //------------------------ Gestion de Dossier Medical -------------------------\\

        private void GetDossier()
        {
            var consults = consultationDao.consultations
                .Select(c => new {
            
            ID = c.id_rdv,
            Nom = c.rendez_vous.patient.nom +" "+ c.rendez_vous.patient.prenom ,
            Tel = c.rendez_vous.patient.tel,
            Payer = c.rendez_vous.payer== 1 ?"complet" : "incomplet" 

                }).Distinct().ToList();

            gridDossier.DataSource = consults;


            lblTotalConsult.Text = consults.Count.ToString();
        }

        private int GetID_Dossier()
        {
            try
            {
                int[] selectedRows = gridViewDossier.GetSelectedRows();
                object cellValue = null;
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        cellValue = gridViewDossier.GetRowCellValue(rowHandle, "ID");
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





        private void btnDetails_Click(object sender, EventArgs e)
        {
            int id_rdv = GetID_Dossier();
            long id_pat = rdvDao.Find(id_rdv).id_patient;
            
            var frm = new Consultation_Patient(id_rdv,id_pat);
            frm.ShowDialog();
        }

        private void btnCherch_Click(object sender, EventArgs e)
        {
          

        }

        private void txtCherch_EditValueChanged(object sender, EventArgs e)
        {
            string text = txtCherch.Text;

            var consults = consultationDao.consultations
               .Where(c => c.rendez_vous.patient.nom.Contains(text) || c.rendez_vous.patient.prenom.Contains(text) || c.rendez_vous.patient.tel.Contains(text))
               .Select(c => new {

                   ID = c.id_rdv,
                   Nom = c.rendez_vous.patient.nom + " " + c.rendez_vous.patient.prenom,
                   Tel = c.rendez_vous.patient.tel,
                   Payer = c.rendez_vous.payer == 1 ? "complet" : "incomplet"

               }).Distinct().ToList();

            gridDossier.DataSource = consults;


            lblTotalConsult.Text = consults.Count.ToString();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void lbl_titre_Click(object sender, EventArgs e)
        {
            

            lbl_titre.Text = Settings.Default.Name;
        }

        private void GetSettings()
        {
            txtNomCabinet.Text = Settings.Default.Name;
            labelNameApp.Text = Settings.Default.Name;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Settings.Default.Name = txtNomCabinet.Text;
            Settings.Default.Save();
            labelNameApp.Text = Settings.Default.Name;
        }

        private void btnMaxMatin_Click(object sender, EventArgs e)
        {
            Settings.Default.Name = txtMaxMatin.Text;
            Settings.Default.Save();
        }

        private void btnMaxSoir_Click(object sender, EventArgs e)
        {
            Settings.Default.Name = txtMaxSoir.Text;
            Settings.Default.Save();
            
        }

        private void gridViewUsers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void txtExportDB_Click(object sender, EventArgs e)
        {
            txtExportDB.Clear();
            var folderBrowserDialog1 = new FolderBrowserDialog();
           
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtExportDB.Text = folderBrowserDialog1.SelectedPath;
               
                
            }
                
            }
        private void btnExportDB_Click(object sender, EventArgs e)
        {
            try
            {
            saveData.ExportData(txtExportDB.Text);
            System.Diagnostics.Process.Start(txtExportDB.Text);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }

        }

        private void txtImportDB_Click(object sender, EventArgs e)
        {
            txtImportDB.Clear();
            var openFileDialog = new OpenFileDialog();
            
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                txtImportDB.Text = openFileDialog.FileName;

            }

        }
        private void btnImportDB_Click(object sender, EventArgs e)
        {
            try
            {
                saveData.ImportData(txtImportDB.Text);
                string msg = "Base de données importé avec succés";
               var rep = XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, msg);
                if (rep==DialogResult.OK)
                {
                    Application.Restart();
                }
            
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void txtExportJson_Click(object sender, EventArgs e)
        {
            txtExportJson.Clear();
            var folderBrowserDialog1 = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtExportJson.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void btnExportToJson_Click(object sender, EventArgs e)
        {
            try
            {
                saveData.ExportToJson(txtExportJson.Text);
                System.Diagnostics.Process.Start(txtExportJson.Text);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.divmer.com");
            }
            catch (Exception)
            {


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            try
            {
                System.Diagnostics.Process.Start("http://www.divmer.com");
            }
            catch (Exception)
            {


            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                 System.Diagnostics.Process.Start("mailto:mail@divmer.com");
            }
            catch (Exception)
            {

                
            }
           
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            GetAll();
        }
    }
    }

