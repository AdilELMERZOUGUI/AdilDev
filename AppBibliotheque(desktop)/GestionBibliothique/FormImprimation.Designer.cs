namespace GestionBibliothique
{
    partial class FormImprimation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.crystalReportViewerRappelEleve = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.crystalReportViewerTousEleves = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboEleve = new MetroFramework.Controls.MetroComboBox();
            this.btnAjouter = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(597, 381);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.crystalReportViewerRappelEleve);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(589, 339);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Rappel Pour Un Elève ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // crystalReportViewerRappelEleve
            // 
            this.crystalReportViewerRappelEleve.ActiveViewIndex = -1;
            this.crystalReportViewerRappelEleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerRappelEleve.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerRappelEleve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerRappelEleve.Location = new System.Drawing.Point(0, 39);
            this.crystalReportViewerRappelEleve.Name = "crystalReportViewerRappelEleve";
            this.crystalReportViewerRappelEleve.Size = new System.Drawing.Size(589, 300);
            this.crystalReportViewerRappelEleve.TabIndex = 2;
            this.crystalReportViewerRappelEleve.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.crystalReportViewerTousEleves);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(589, 339);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Rappel Pour Tous Les Elève ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // crystalReportViewerTousEleves
            // 
            this.crystalReportViewerTousEleves.ActiveViewIndex = -1;
            this.crystalReportViewerTousEleves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTousEleves.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTousEleves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTousEleves.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTousEleves.Name = "crystalReportViewerTousEleves";
            this.crystalReportViewerTousEleves.Size = new System.Drawing.Size(589, 339);
            this.crystalReportViewerTousEleves.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.comboEleve);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 39);
            this.panel1.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(120, 5);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 25);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Nom d\'Elève";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // comboEleve
            // 
            this.comboEleve.DisplayMember = "null";
            this.comboEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEleve.FormattingEnabled = true;
            this.comboEleve.ItemHeight = 23;
            this.comboEleve.Location = new System.Drawing.Point(244, 4);
            this.comboEleve.Name = "comboEleve";
            this.comboEleve.Size = new System.Drawing.Size(200, 29);
            this.comboEleve.TabIndex = 16;
            this.comboEleve.UseCustomForeColor = true;
            this.comboEleve.UseSelectable = true;
            this.comboEleve.UseStyleColors = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(450, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(118, 27);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Afficher";
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseCustomForeColor = true;
            this.btnAjouter.UseSelectable = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormImprimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 381);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FormImprimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormٍٍImprimation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormImprimation_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerRappelEleve;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTousEleves;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox comboEleve;
        private MetroFramework.Controls.MetroButton btnAjouter;
    }
}