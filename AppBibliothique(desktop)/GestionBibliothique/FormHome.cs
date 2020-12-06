using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionBibliothique
{
    public partial class FormHome : Form
    {
        
        public FormHome()
        {

            InitializeComponent();
            
            
        }
       
       
      
        public void FormHome_Load(object sender, EventArgs e)
        {
            Program.get();
            labelNomProfil.Text = Program.nomAdmin;
            pictureBoxProfil.ImageLocation = Program.photo;

           
           
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

        private void buttonToForm1_Click(object sender, EventArgs e)
        {
            
                FormBibliothèqueDesLivres f = new FormBibliothèqueDesLivres();
                f.ShowDialog();
           
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormProfil formProfil = new FormProfil();
            formProfil.ShowDialog();
            this.Hide();
      
         
            
        }

        private void buttonToForm2_Click(object sender, EventArgs e)
        {
            FormGestionDesTransferts f = new FormGestionDesTransferts();
            f.ShowDialog();
        }

        private void buttonToForm4_Click(object sender, EventArgs e)
        {
            FormGestionDesEleves f = new FormGestionDesEleves();
            f.ShowDialog();
        }

        private void buttonToForm3_Click(object sender, EventArgs e)
        {

            FormStatistiquesEtRapports f = new FormStatistiquesEtRapports();
            f.ShowDialog();
        }

       

       
    }
}
