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

namespace DevApp1.Forms
{
    public partial class repairSource : DevExpress.XtraEditors.XtraForm
    {
        public repairSource()
        {
            InitializeComponent();
        }

        SaveData saveData = new SaveData();

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
                if (rep == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, ex.Message);

            }
        }
    }
}