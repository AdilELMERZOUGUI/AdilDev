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
    public partial class FormStatistiquesEtRapports : Form
    {
        int nbr = 0 , nbrDem=0 ;
        public FormStatistiquesEtRapports()
        {
            InitializeComponent();
        }

        private void FormStatistiquesEtRapports_Load(object sender, EventArgs e)
        {
            label3.Text = "0" + nbrDem.ToString();
            label2.Text = "0"+nbr.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nbrDem <= nombreDemande())
                if (nbrDem<10)
                label3.Text = "0" + (nbrDem++).ToString(); 
                else
                label3.Text = " "+(nbrDem++).ToString(); 

            if (nbr <= nombreLivreNR())
                if (nbr < 10)
                    label2.Text = "0" + (nbr++).ToString();
                else
                    label2.Text = " "+(nbr++).ToString(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                    Application.OpenForms[i].Close();
                else
                    Application.OpenForms[i].Show();
            }
        }
        private int nombreLivreNR()
        {
            int nbr = 0;
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) from Demande where valide_Retour=0", cn);
                cn.Open();
                nbr =(int) cmd.ExecuteScalar();
                
            }
            
            return nbr;
        }
        private int nombreDemande()
        {
            int nbr = 0;
            using (SqlConnection cn = new SqlConnection(Program.strcn))
            {
                SqlCommand cmd = new SqlCommand("Select count(*) from Demande ", cn);
                cn.Open();
                nbr = (int)cmd.ExecuteScalar();

            }

            return nbr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FormImprimation f = new FormImprimation();
                f.Show();
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
                FormGraphPourcentage f = new FormGraphPourcentage();
                f.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        
    }
}
