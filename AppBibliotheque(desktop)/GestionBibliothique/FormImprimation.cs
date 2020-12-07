using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothique
{
    public partial class FormImprimation : Form
    {
        public FormImprimation()
        {
            InitializeComponent();
        }

        private void FormImprimation_Load(object sender, EventArgs e)
        {

            RemplirCombo();
            EtatRappelTous();
        }

        void EtatRappelTous()
        {
            DataSetBib ds = new DataSetBib();
            DataSetBibTableAdapters.eleveTableAdapter daEleve = new DataSetBibTableAdapters.eleveTableAdapter();
            DataSetBibTableAdapters.demandeTableAdapter daDem = new DataSetBibTableAdapters.demandeTableAdapter();
            DataSetBibTableAdapters.classeTableAdapter daClass = new DataSetBibTableAdapters.classeTableAdapter();
            DataSetBibTableAdapters.livreTableAdapter daLivre = new DataSetBibTableAdapters.livreTableAdapter();
            daEleve.Fill(ds.eleve);
            daLivre.Fill(ds.livre);
            daClass.Fill(ds.classe);
            daDem.Fill(ds.demande);

            CrystalReportRappelEleve repEleve = new CrystalReportRappelEleve();
            repEleve.SetDataSource(ds);
            crystalReportViewerTousEleves.ReportSource = repEleve;
        }
        void EtatRappel()
        {
            int id = int.Parse(comboEleve.SelectedValue.ToString());
            DataSetBib ds = new DataSetBib();
            DataSetBibTableAdapters.eleveTableAdapter daEleve = new DataSetBibTableAdapters.eleveTableAdapter();
            DataSetBibTableAdapters.demandeTableAdapter daDem = new DataSetBibTableAdapters.demandeTableAdapter();
            DataSetBibTableAdapters.classeTableAdapter daClass = new DataSetBibTableAdapters.classeTableAdapter();
            DataSetBibTableAdapters.livreTableAdapter daLivre = new DataSetBibTableAdapters.livreTableAdapter();
            daEleve.Fill(ds.eleve);
            daLivre.Fill(ds.livre);
            daClass.Fill(ds.classe);
            daDem.FillBy(ds.demande,id);

            CrystalReportRappelEleve repEleve = new CrystalReportRappelEleve();
            repEleve.SetDataSource(ds);
            crystalReportViewerRappelEleve.ReportSource = repEleve;
        }

        void RemplirCombo()
        {
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT eleve.id, eleve.nom + ' ' + eleve.prenom AS nomc, demande.date_retour
                                                FROM eleve INNER JOIN demande ON eleve.id = demande.id_eleve
                                                WHERE (demande.valide_Retour = 0)
                                                AND (DATEDIFF(day, demande.date_retour, GETDATE()) > 0)", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboEleve.DataSource = dt;
                comboEleve.ValueMember = "id";
                comboEleve.DisplayMember = "nomc";

            }
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            EtatRappel();
        }
    }
}
