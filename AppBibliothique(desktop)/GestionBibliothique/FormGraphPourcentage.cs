using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothique
{
    public partial class FormGraphPourcentage : Form
    {
        public FormGraphPourcentage()
        {
            InitializeComponent();
        }

        private void FormGraphPourcentage_Load(object sender, EventArgs e)
        {

            DataSetBib ds = new DataSetBib();
            DataSetBibTableAdapters.categorieTableAdapter dacat = new DataSetBibTableAdapters.categorieTableAdapter();
            DataSetBibTableAdapters.livreTableAdapter dalivre = new DataSetBibTableAdapters.livreTableAdapter();
            dacat.Fill(ds.categorie);
            dalivre.Fill(ds.livre);

            CrystalReportGraph rep = new CrystalReportGraph();
            rep.SetDataSource(ds);
            crystalReportViewerGraph.ReportSource = rep;

        }
    }
}
