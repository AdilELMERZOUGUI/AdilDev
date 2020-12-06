using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevApp1.Repository;
using DevApp1.Models;
using DevExpress.XtraEditors;

namespace DevApp1.Forms
{
    public partial class Ajouter_Acte : DevExpress.XtraEditors.XtraForm
    {
        private ActeDao acteDao = new ActeDao();

        public Ajouter_Acte()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                acte act = new acte
                {
                    titre_acte = txtActe.Text
                };

                acteDao.Add(act);
                string toastID = "ff3f8021-4b59-4919-b8e3-0d66a6960203";
                toastAdd.ShowNotification(toastID);
                Application.OpenForms["Ajouter_Consultation"].Activate();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }
    }
}