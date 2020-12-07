namespace GestionBibliothique
{
    partial class FormGestionDesTransferts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionDesTransferts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitre = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtQtt = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txteleve = new System.Windows.Forms.TextBox();
            this.txtliivre = new System.Windows.Forms.TextBox();
            this.dateTimePikerPrise = new MetroFramework.Controls.MetroDateTime();
            this.dateTimePikerRetour = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboLivre = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboEleve = new MetroFramework.Controls.MetroComboBox();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.btnAnnuler = new MetroFramework.Controls.MetroButton();
            this.btnAjouter = new MetroFramework.Controls.MetroButton();
            this.checkboxValidation = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ComboBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxTri = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTransfert = new MetroFramework.Controls.MetroGrid();
            this.Nom_Eleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_Livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validation_Retour = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfert)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.labelTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitre.Font = new System.Drawing.Font("Nexa", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.labelTitre.Location = new System.Drawing.Point(12, 27);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(434, 32);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Gestion Du Bibliothique Scolaire";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.labelTitre);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 91);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(760, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(100)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Réalisé Par :  Adil ELMERZOUGUI  Et  Soufian HADANI";
            // 
            // metroPanel6
            // 
            this.metroPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.metroPanel6.Controls.Add(this.label1);
            this.metroPanel6.Controls.Add(this.btnExit);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 559);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(800, 41);
            this.metroPanel6.TabIndex = 6;
            this.metroPanel6.UseCustomBackColor = true;
            this.metroPanel6.UseCustomForeColor = true;
            this.metroPanel6.UseStyleColors = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nexa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(644, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 7;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(100, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 91);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 468);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtQtt);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.Controls.Add(this.txteleve);
            this.metroTabPage1.Controls.Add(this.txtliivre);
            this.metroTabPage1.Controls.Add(this.dateTimePikerPrise);
            this.metroTabPage1.Controls.Add(this.dateTimePikerRetour);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.comboLivre);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.comboEleve);
            this.metroTabPage1.Controls.Add(this.btnModifier);
            this.metroTabPage1.Controls.Add(this.btnAnnuler);
            this.metroTabPage1.Controls.Add(this.btnAjouter);
            this.metroTabPage1.Controls.Add(this.checkboxValidation);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.pictureBox3);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.Font = new System.Drawing.Font("Nexa", 14.25F);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 426);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Traitement Des Demandes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtQtt
            // 
            this.txtQtt.AutoSize = true;
            this.txtQtt.Enabled = false;
            this.txtQtt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtQtt.Location = new System.Drawing.Point(184, 120);
            this.txtQtt.Name = "txtQtt";
            this.txtQtt.Size = new System.Drawing.Size(21, 25);
            this.txtQtt.TabIndex = 21;
            this.txtQtt.Text = "0";
            this.txtQtt.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(14, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Quantité";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(191, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 33);
            this.panel3.TabIndex = 19;
            // 
            // txteleve
            // 
            this.txteleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txteleve.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txteleve.Location = new System.Drawing.Point(386, 19);
            this.txteleve.Name = "txteleve";
            this.txteleve.Size = new System.Drawing.Size(191, 29);
            this.txteleve.TabIndex = 17;
            this.txteleve.TextChanged += new System.EventHandler(this.txteleve_TextChanged_1);
            // 
            // txtliivre
            // 
            this.txtliivre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtliivre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtliivre.Location = new System.Drawing.Point(386, 70);
            this.txtliivre.Name = "txtliivre";
            this.txtliivre.Size = new System.Drawing.Size(191, 29);
            this.txtliivre.TabIndex = 17;
            this.txtliivre.TextChanged += new System.EventHandler(this.txtliivre_TextChanged_1);
            // 
            // dateTimePikerPrise
            // 
            this.dateTimePikerPrise.Location = new System.Drawing.Point(183, 160);
            this.dateTimePikerPrise.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePikerPrise.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePikerPrise.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePikerPrise.Name = "dateTimePikerPrise";
            this.dateTimePikerPrise.Size = new System.Drawing.Size(200, 30);
            this.dateTimePikerPrise.TabIndex = 16;
            // 
            // dateTimePikerRetour
            // 
            this.dateTimePikerRetour.Location = new System.Drawing.Point(183, 211);
            this.dateTimePikerRetour.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePikerRetour.Name = "dateTimePikerRetour";
            this.dateTimePikerRetour.Size = new System.Drawing.Size(200, 30);
            this.dateTimePikerRetour.TabIndex = 15;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 215);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 25);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Date De Retour";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(13, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Date De Prise";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Titre Du Livres";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // comboLivre
            // 
            this.comboLivre.DisplayMember = "null";
            this.comboLivre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLivre.FormattingEnabled = true;
            this.comboLivre.ItemHeight = 23;
            this.comboLivre.Location = new System.Drawing.Point(184, 70);
            this.comboLivre.Name = "comboLivre";
            this.comboLivre.Size = new System.Drawing.Size(200, 29);
            this.comboLivre.TabIndex = 14;
            this.comboLivre.UseCustomForeColor = true;
            this.comboLivre.UseSelectable = true;
            this.comboLivre.UseStyleColors = true;
            this.comboLivre.SelectedIndexChanged += new System.EventHandler(this.comboLivre_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(14, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 25);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Nom d\'Elève";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // comboEleve
            // 
            this.comboEleve.DisplayMember = "null";
            this.comboEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEleve.FormattingEnabled = true;
            this.comboEleve.ItemHeight = 23;
            this.comboEleve.Location = new System.Drawing.Point(184, 19);
            this.comboEleve.Name = "comboEleve";
            this.comboEleve.Size = new System.Drawing.Size(200, 29);
            this.comboEleve.TabIndex = 14;
            this.comboEleve.UseCustomForeColor = true;
            this.comboEleve.UseSelectable = true;
            this.comboEleve.UseStyleColors = true;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(582, 348);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 50);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier Demande";
            this.btnModifier.UseCustomBackColor = true;
            this.btnModifier.UseCustomForeColor = true;
            this.btnModifier.UseSelectable = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(380, 348);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(179, 50);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler Demande";
            this.btnAnnuler.UseCustomBackColor = true;
            this.btnAnnuler.UseCustomForeColor = true;
            this.btnAnnuler.UseSelectable = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(177, 348);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(179, 50);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter Demande";
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseCustomForeColor = true;
            this.btnAjouter.UseSelectable = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // checkboxValidation
            // 
            this.checkboxValidation.AutoSize = true;
            this.checkboxValidation.Checked = true;
            this.checkboxValidation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxValidation.Location = new System.Drawing.Point(211, 260);
            this.checkboxValidation.Name = "checkboxValidation";
            this.checkboxValidation.Size = new System.Drawing.Size(80, 27);
            this.checkboxValidation.TabIndex = 11;
            this.checkboxValidation.Text = "On";
            this.checkboxValidation.UseSelectable = true;
            this.checkboxValidation.CheckedChanged += new System.EventHandler(this.checkboxValidation_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(14, 260);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(166, 25);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Validation du Retour";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(576, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Size = new System.Drawing.Size(23, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(576, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(23, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.ComboBoxFilter);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.ComboBoxTri);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.dataGridViewTransfert);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 426);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Liste Des Demandes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 3;
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.ItemHeight = 23;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "Tous Les Demande",
            "Validé",
            "Non Validé"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(580, 23);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(204, 29);
            this.ComboBoxFilter.TabIndex = 6;
            this.ComboBoxFilter.UseSelectable = true;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(402, 23);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(172, 25);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Filtrer par Validation :";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // ComboBoxTri
            // 
            this.ComboBoxTri.FormattingEnabled = true;
            this.ComboBoxTri.ItemHeight = 23;
            this.ComboBoxTri.Location = new System.Drawing.Point(111, 23);
            this.ComboBoxTri.Name = "ComboBoxTri";
            this.ComboBoxTri.Size = new System.Drawing.Size(204, 29);
            this.ComboBoxTri.TabIndex = 6;
            this.ComboBoxTri.UseSelectable = true;
            this.ComboBoxTri.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTri_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(8, 27);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 25);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Trier Par :";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // dataGridViewTransfert
            // 
            this.dataGridViewTransfert.AllowUserToAddRows = false;
            this.dataGridViewTransfert.AllowUserToDeleteRows = false;
            this.dataGridViewTransfert.AllowUserToOrderColumns = true;
            this.dataGridViewTransfert.AllowUserToResizeRows = false;
            this.dataGridViewTransfert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransfert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransfert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTransfert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTransfert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTransfert.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTransfert.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewTransfert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransfert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransfert.ColumnHeadersHeight = 50;
            this.dataGridViewTransfert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_Eleve,
            this.Titre_Livre,
            this.Date_Prise,
            this.Date_Retour,
            this.Validation_Retour});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransfert.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransfert.EnableHeadersVisualStyles = false;
            this.dataGridViewTransfert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewTransfert.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTransfert.Location = new System.Drawing.Point(6, 68);
            this.dataGridViewTransfert.MultiSelect = false;
            this.dataGridViewTransfert.Name = "dataGridViewTransfert";
            this.dataGridViewTransfert.ReadOnly = true;
            this.dataGridViewTransfert.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransfert.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTransfert.RowHeadersWidth = 20;
            this.dataGridViewTransfert.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTransfert.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTransfert.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nexa", 14F);
            this.dataGridViewTransfert.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTransfert.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dataGridViewTransfert.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTransfert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransfert.Size = new System.Drawing.Size(780, 357);
            this.dataGridViewTransfert.TabIndex = 2;
            this.dataGridViewTransfert.UseCustomBackColor = true;
            this.dataGridViewTransfert.UseCustomForeColor = true;
            this.dataGridViewTransfert.UseStyleColors = true;
            // 
            // Nom_Eleve
            // 
            this.Nom_Eleve.DataPropertyName = "Nom_Eleve";
            this.Nom_Eleve.HeaderText = "Nom Elève";
            this.Nom_Eleve.Name = "Nom_Eleve";
            this.Nom_Eleve.ReadOnly = true;
            // 
            // Titre_Livre
            // 
            this.Titre_Livre.DataPropertyName = "Titre_Livre";
            this.Titre_Livre.HeaderText = "Titre Livre";
            this.Titre_Livre.Name = "Titre_Livre";
            this.Titre_Livre.ReadOnly = true;
            // 
            // Date_Prise
            // 
            this.Date_Prise.DataPropertyName = "Date_Prise";
            this.Date_Prise.HeaderText = "Date Prise";
            this.Date_Prise.Name = "Date_Prise";
            this.Date_Prise.ReadOnly = true;
            // 
            // Date_Retour
            // 
            this.Date_Retour.DataPropertyName = "Date_Retour";
            this.Date_Retour.HeaderText = "Date Retour";
            this.Date_Retour.Name = "Date_Retour";
            this.Date_Retour.ReadOnly = true;
            // 
            // Validation_Retour
            // 
            this.Validation_Retour.DataPropertyName = "Validation_Retour";
            this.Validation_Retour.FalseValue = "False";
            this.Validation_Retour.HeaderText = "Validation Retour";
            this.Validation_Retour.IndeterminateValue = "";
            this.Validation_Retour.Name = "Validation_Retour";
            this.Validation_Retour.ReadOnly = true;
            this.Validation_Retour.TrueValue = "True";
            // 
            // FormGestionDesTransferts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroPanel6);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nexa", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDesTransferts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionDesTransferts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGestionDesTransferts_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txteleve;
        private System.Windows.Forms.TextBox txtliivre;
        private MetroFramework.Controls.MetroDateTime dateTimePikerPrise;
        private MetroFramework.Controls.MetroDateTime dateTimePikerRetour;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboLivre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox comboEleve;
        private MetroFramework.Controls.MetroButton btnModifier;
        private MetroFramework.Controls.MetroButton btnAnnuler;
        private MetroFramework.Controls.MetroButton btnAjouter;
        private MetroFramework.Controls.MetroToggle checkboxValidation;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox ComboBoxFilter;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox ComboBoxTri;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dataGridViewTransfert;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel txtQtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Eleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_Livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Prise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Retour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Validation_Retour;
        private System.Windows.Forms.Button button1;

    }
}