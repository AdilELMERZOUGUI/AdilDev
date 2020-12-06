namespace GestionBibliothique
{
    partial class FormBibliothèqueDesLivres
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBibliothèqueDesLivres));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.comboGroupBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.comboTri = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dgvLivre = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.numericUpDownQtt = new System.Windows.Forms.NumericUpDown();
            this.buttonDelCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLast = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPreviews = new MetroFramework.Controls.MetroButton();
            this.btnFirst = new MetroFramework.Controls.MetroButton();
            this.btnEnregistrer = new MetroFramework.Controls.MetroButton();
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.btnNouveau = new MetroFramework.Controls.MetroButton();
            this.buttonUpload = new MetroFramework.Controls.MetroButton();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.checkboxDisponible = new MetroFramework.Controls.MetroToggle();
            this.txtEdition = new MetroFramework.Controls.MetroTextBox();
            this.txtAuteur = new MetroFramework.Controls.MetroTextBox();
            this.txtTitre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboCat = new MetroFramework.Controls.MetroComboBox();
            this.txtcategorie = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCherch = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSetBib = new GestionBibliothique.DataSetBib();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livreTableAdapter = new GestionBibliothique.DataSetBibTableAdapters.livreTableAdapter();
            this.metroPanel6.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel6
            // 
            this.metroPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.metroPanel6.Controls.Add(this.label1);
            this.metroPanel6.Controls.Add(this.btnExit);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 559);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(800, 41);
            this.metroPanel6.TabIndex = 4;
            this.metroPanel6.UseCustomBackColor = true;
            this.metroPanel6.UseCustomForeColor = true;
            this.metroPanel6.UseStyleColors = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(105)))));
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.labelTitre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 91);
            this.metroPanel1.TabIndex = 3;
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
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.comboGroupBy);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.comboTri);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.dgvLivre);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 426);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Liste Des Livres";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 3;
            // 
            // comboGroupBy
            // 
            this.comboGroupBy.FormattingEnabled = true;
            this.comboGroupBy.ItemHeight = 23;
            this.comboGroupBy.Location = new System.Drawing.Point(580, 23);
            this.comboGroupBy.Name = "comboGroupBy";
            this.comboGroupBy.Size = new System.Drawing.Size(204, 29);
            this.comboGroupBy.TabIndex = 6;
            this.comboGroupBy.UseSelectable = true;
            this.comboGroupBy.SelectedIndexChanged += new System.EventHandler(this.comboGroupBy_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(409, 23);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(165, 25);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Filtré par Catégorie :";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // comboTri
            // 
            this.comboTri.FormattingEnabled = true;
            this.comboTri.ItemHeight = 23;
            this.comboTri.Location = new System.Drawing.Point(90, 23);
            this.comboTri.Name = "comboTri";
            this.comboTri.Size = new System.Drawing.Size(204, 29);
            this.comboTri.TabIndex = 6;
            this.comboTri.UseSelectable = true;
            this.comboTri.SelectedIndexChanged += new System.EventHandler(this.comboTri_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(8, 23);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 25);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Trie Par :";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // dgvLivre
            // 
            this.dgvLivre.AllowUserToAddRows = false;
            this.dgvLivre.AllowUserToDeleteRows = false;
            this.dgvLivre.AllowUserToResizeRows = false;
            this.dgvLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLivre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLivre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLivre.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLivre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivre.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivre.EnableHeadersVisualStyles = false;
            this.dgvLivre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLivre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLivre.Location = new System.Drawing.Point(8, 70);
            this.dgvLivre.MultiSelect = false;
            this.dgvLivre.Name = "dgvLivre";
            this.dgvLivre.ReadOnly = true;
            this.dgvLivre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivre.RowHeadersWidth = 20;
            this.dgvLivre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLivre.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvLivre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nexa", 14F);
            this.dgvLivre.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLivre.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dgvLivre.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLivre.RowTemplate.Height = 50;
            this.dgvLivre.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivre.Size = new System.Drawing.Size(776, 353);
            this.dgvLivre.TabIndex = 2;
            this.dgvLivre.UseCustomBackColor = true;
            this.dgvLivre.UseCustomForeColor = true;
            this.dgvLivre.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.numericUpDownQtt);
            this.metroTabPage1.Controls.Add(this.buttonDelCat);
            this.metroTabPage1.Controls.Add(this.btnAddCat);
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.btnLast);
            this.metroTabPage1.Controls.Add(this.btnNext);
            this.metroTabPage1.Controls.Add(this.btnPreviews);
            this.metroTabPage1.Controls.Add(this.btnFirst);
            this.metroTabPage1.Controls.Add(this.btnEnregistrer);
            this.metroTabPage1.Controls.Add(this.btnSupprimer);
            this.metroTabPage1.Controls.Add(this.btnModifier);
            this.metroTabPage1.Controls.Add(this.btnNouveau);
            this.metroTabPage1.Controls.Add(this.buttonUpload);
            this.metroTabPage1.Controls.Add(this.pictureBoxPhoto);
            this.metroTabPage1.Controls.Add(this.checkboxDisponible);
            this.metroTabPage1.Controls.Add(this.txtEdition);
            this.metroTabPage1.Controls.Add(this.txtAuteur);
            this.metroTabPage1.Controls.Add(this.txtTitre);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtID);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.comboCat);
            this.metroTabPage1.Controls.Add(this.txtcategorie);
            this.metroTabPage1.Font = new System.Drawing.Font("Nexa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 426);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Détails Livres";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // numericUpDownQtt
            // 
            this.numericUpDownQtt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownQtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQtt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDownQtt.Location = new System.Drawing.Point(154, 266);
            this.numericUpDownQtt.Name = "numericUpDownQtt";
            this.numericUpDownQtt.Size = new System.Drawing.Size(199, 31);
            this.numericUpDownQtt.TabIndex = 10;
            this.numericUpDownQtt.ValueChanged += new System.EventHandler(this.numericUpDownQtt_ValueChanged);
            // 
            // buttonDelCat
            // 
            this.buttonDelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonDelCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelCat.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelCat.ForeColor = System.Drawing.Color.White;
            this.buttonDelCat.Location = new System.Drawing.Point(361, 219);
            this.buttonDelCat.Name = "buttonDelCat";
            this.buttonDelCat.Size = new System.Drawing.Size(23, 29);
            this.buttonDelCat.TabIndex = 9;
            this.buttonDelCat.Text = "-";
            this.buttonDelCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelCat.UseVisualStyleBackColor = false;
            this.buttonDelCat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.Color.White;
            this.btnAddCat.Location = new System.Drawing.Point(332, 219);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(23, 29);
            this.btnAddCat.TabIndex = 9;
            this.btnAddCat.Text = "+";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(202, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 33);
            this.panel2.TabIndex = 8;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Location = new System.Drawing.Point(452, 215);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(66, 50);
            this.btnLast.TabIndex = 7;
            this.btnLast.UseCustomBackColor = true;
            this.btnLast.UseCustomForeColor = true;
            this.btnLast.UseSelectable = true;
            this.btnLast.UseStyleColors = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(452, 150);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 50);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseCustomForeColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.UseStyleColors = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviews
            // 
            this.btnPreviews.BackColor = System.Drawing.Color.White;
            this.btnPreviews.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreviews.BackgroundImage")));
            this.btnPreviews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreviews.Location = new System.Drawing.Point(452, 84);
            this.btnPreviews.Name = "btnPreviews";
            this.btnPreviews.Size = new System.Drawing.Size(66, 50);
            this.btnPreviews.TabIndex = 7;
            this.btnPreviews.UseCustomBackColor = true;
            this.btnPreviews.UseCustomForeColor = true;
            this.btnPreviews.UseSelectable = true;
            this.btnPreviews.UseStyleColors = true;
            this.btnPreviews.Click += new System.EventHandler(this.btnPreviews_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.Location = new System.Drawing.Point(452, 18);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(66, 50);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.UseCustomBackColor = true;
            this.btnFirst.UseCustomForeColor = true;
            this.btnFirst.UseSelectable = true;
            this.btnFirst.UseStyleColors = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(599, 365);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(141, 50);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseCustomBackColor = true;
            this.btnEnregistrer.UseCustomForeColor = true;
            this.btnEnregistrer.UseSelectable = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(413, 365);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(141, 50);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseCustomBackColor = true;
            this.btnSupprimer.UseCustomForeColor = true;
            this.btnSupprimer.UseSelectable = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(227, 365);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(141, 50);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseCustomBackColor = true;
            this.btnModifier.UseCustomForeColor = true;
            this.btnModifier.UseSelectable = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Location = new System.Drawing.Point(41, 365);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(141, 50);
            this.btnNouveau.TabIndex = 7;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseCustomBackColor = true;
            this.btnNouveau.UseCustomForeColor = true;
            this.btnNouveau.UseSelectable = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.White;
            this.buttonUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpload.BackgroundImage")));
            this.buttonUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpload.Location = new System.Drawing.Point(555, 280);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(185, 50);
            this.buttonUpload.TabIndex = 7;
            this.buttonUpload.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonUpload.UseSelectable = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(555, 18);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(185, 247);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 6;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // checkboxDisponible
            // 
            this.checkboxDisponible.AutoSize = true;
            this.checkboxDisponible.Checked = true;
            this.checkboxDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxDisponible.Enabled = false;
            this.checkboxDisponible.Location = new System.Drawing.Point(221, 307);
            this.checkboxDisponible.Name = "checkboxDisponible";
            this.checkboxDisponible.Size = new System.Drawing.Size(80, 27);
            this.checkboxDisponible.TabIndex = 5;
            this.checkboxDisponible.Text = "On";
            this.checkboxDisponible.UseSelectable = true;
            // 
            // txtEdition
            // 
            // 
            // 
            // 
            this.txtEdition.CustomButton.Image = null;
            this.txtEdition.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtEdition.CustomButton.Name = "";
            this.txtEdition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdition.CustomButton.TabIndex = 1;
            this.txtEdition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdition.CustomButton.UseSelectable = true;
            this.txtEdition.Lines = new string[0];
            this.txtEdition.Location = new System.Drawing.Point(151, 168);
            this.txtEdition.MaxLength = 32767;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.PasswordChar = '\0';
            this.txtEdition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdition.SelectedText = "";
            this.txtEdition.SelectionLength = 0;
            this.txtEdition.SelectionStart = 0;
            this.txtEdition.ShortcutsEnabled = true;
            this.txtEdition.ShowButton = true;
            this.txtEdition.ShowClearButton = true;
            this.txtEdition.Size = new System.Drawing.Size(204, 23);
            this.txtEdition.TabIndex = 3;
            this.txtEdition.UseCustomForeColor = true;
            this.txtEdition.UseSelectable = true;
            this.txtEdition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAuteur
            // 
            // 
            // 
            // 
            this.txtAuteur.CustomButton.Image = null;
            this.txtAuteur.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtAuteur.CustomButton.Name = "";
            this.txtAuteur.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuteur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuteur.CustomButton.TabIndex = 1;
            this.txtAuteur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuteur.CustomButton.UseSelectable = true;
            this.txtAuteur.Lines = new string[0];
            this.txtAuteur.Location = new System.Drawing.Point(152, 117);
            this.txtAuteur.MaxLength = 32767;
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.PasswordChar = '\0';
            this.txtAuteur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuteur.SelectedText = "";
            this.txtAuteur.SelectionLength = 0;
            this.txtAuteur.SelectionStart = 0;
            this.txtAuteur.ShortcutsEnabled = true;
            this.txtAuteur.ShowButton = true;
            this.txtAuteur.ShowClearButton = true;
            this.txtAuteur.Size = new System.Drawing.Size(204, 23);
            this.txtAuteur.TabIndex = 3;
            this.txtAuteur.UseCustomForeColor = true;
            this.txtAuteur.UseSelectable = true;
            this.txtAuteur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuteur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTitre
            // 
            // 
            // 
            // 
            this.txtTitre.CustomButton.Image = null;
            this.txtTitre.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtTitre.CustomButton.Name = "";
            this.txtTitre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitre.CustomButton.TabIndex = 1;
            this.txtTitre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitre.CustomButton.UseSelectable = true;
            this.txtTitre.Lines = new string[0];
            this.txtTitre.Location = new System.Drawing.Point(152, 66);
            this.txtTitre.MaxLength = 32767;
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.PasswordChar = '\0';
            this.txtTitre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitre.SelectedText = "";
            this.txtTitre.SelectionLength = 0;
            this.txtTitre.SelectionStart = 0;
            this.txtTitre.ShortcutsEnabled = true;
            this.txtTitre.ShowButton = true;
            this.txtTitre.ShowClearButton = true;
            this.txtTitre.Size = new System.Drawing.Size(204, 23);
            this.txtTitre.TabIndex = 3;
            this.txtTitre.UseCustomForeColor = true;
            this.txtTitre.UseSelectable = true;
            this.txtTitre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(54, 269);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 25);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Quantité ";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(53, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Edition";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.Enabled = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(152, 15);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.ShowButton = true;
            this.txtID.Size = new System.Drawing.Size(204, 23);
            this.txtID.TabIndex = 3;
            this.txtID.UseCustomForeColor = true;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(53, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Auteur";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(53, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Titre ";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(54, 309);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Disponibilité";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(53, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Categorie";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(53, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // comboCat
            // 
            this.comboCat.DisplayMember = "null";
            this.comboCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCat.FormattingEnabled = true;
            this.comboCat.ItemHeight = 23;
            this.comboCat.Location = new System.Drawing.Point(151, 219);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(180, 29);
            this.comboCat.TabIndex = 4;
            this.comboCat.UseCustomForeColor = true;
            this.comboCat.UseSelectable = true;
            this.comboCat.UseStyleColors = true;
            // 
            // txtcategorie
            // 
            // 
            // 
            // 
            this.txtcategorie.CustomButton.Image = null;
            this.txtcategorie.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtcategorie.CustomButton.Name = "";
            this.txtcategorie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcategorie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcategorie.CustomButton.TabIndex = 1;
            this.txtcategorie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcategorie.CustomButton.UseSelectable = true;
            this.txtcategorie.Lines = new string[0];
            this.txtcategorie.Location = new System.Drawing.Point(154, 222);
            this.txtcategorie.MaxLength = 32767;
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.PasswordChar = '\0';
            this.txtcategorie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcategorie.SelectedText = "";
            this.txtcategorie.SelectionLength = 0;
            this.txtcategorie.SelectionStart = 0;
            this.txtcategorie.ShortcutsEnabled = true;
            this.txtcategorie.ShowButton = true;
            this.txtcategorie.ShowClearButton = true;
            this.txtcategorie.Size = new System.Drawing.Size(178, 23);
            this.txtcategorie.TabIndex = 3;
            this.txtcategorie.UseCustomForeColor = true;
            this.txtcategorie.UseSelectable = true;
            this.txtcategorie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcategorie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroButton9
            // 
            this.metroButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton9.ForeColor = System.Drawing.Color.White;
            this.metroButton9.Location = new System.Drawing.Point(356, 3);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(80, 24);
            this.metroButton9.TabIndex = 7;
            this.metroButton9.Text = "Chercher";
            this.metroButton9.UseCustomBackColor = true;
            this.metroButton9.UseCustomForeColor = true;
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(3, 1);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(180, 25);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Chercher Par ID Livre :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // txtCherch
            // 
            // 
            // 
            // 
            this.txtCherch.CustomButton.Image = null;
            this.txtCherch.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtCherch.CustomButton.Name = "";
            this.txtCherch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCherch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCherch.CustomButton.TabIndex = 1;
            this.txtCherch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCherch.CustomButton.UseSelectable = true;
            this.txtCherch.Lines = new string[0];
            this.txtCherch.Location = new System.Drawing.Point(186, 4);
            this.txtCherch.MaxLength = 32767;
            this.txtCherch.Name = "txtCherch";
            this.txtCherch.PasswordChar = '\0';
            this.txtCherch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCherch.SelectedText = "";
            this.txtCherch.SelectionLength = 0;
            this.txtCherch.SelectionStart = 0;
            this.txtCherch.ShortcutsEnabled = true;
            this.txtCherch.ShowButton = true;
            this.txtCherch.ShowClearButton = true;
            this.txtCherch.Size = new System.Drawing.Size(164, 23);
            this.txtCherch.TabIndex = 3;
            this.txtCherch.UseCustomBackColor = true;
            this.txtCherch.UseCustomForeColor = true;
            this.txtCherch.UseSelectable = true;
            this.txtCherch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCherch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.txtCherch);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroButton9);
            this.panel1.Location = new System.Drawing.Point(339, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 30);
            this.panel1.TabIndex = 6;
            // 
            // dataSetBib
            // 
            this.dataSetBib.DataSetName = "DataSetBib";
            this.dataSetBib.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataMember = "livre";
            this.livreBindingSource.DataSource = this.dataSetBib;
            // 
            // livreTableAdapter
            // 
            this.livreTableAdapter.ClearBeforeFill = true;
            // 
            // FormBibliothèqueDesLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroPanel6);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Nexa", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBibliothèqueDesLivres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBibliothèqueDesLivres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBibliothèqueDesLivres_Load);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label labelTitre;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox comboGroupBy;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboTri;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgvLivre;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton btnLast;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPreviews;
        private MetroFramework.Controls.MetroButton btnFirst;
        private MetroFramework.Controls.MetroButton btnEnregistrer;
        private MetroFramework.Controls.MetroButton btnSupprimer;
        private MetroFramework.Controls.MetroButton btnModifier;
        private MetroFramework.Controls.MetroButton btnNouveau;
        private MetroFramework.Controls.MetroButton buttonUpload;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private MetroFramework.Controls.MetroToggle checkboxDisponible;
        private MetroFramework.Controls.MetroTextBox txtEdition;
        private MetroFramework.Controls.MetroTextBox txtAuteur;
        private MetroFramework.Controls.MetroTextBox txtTitre;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboCat;
        private MetroFramework.Controls.MetroTextBox txtcategorie;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtCherch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownQtt;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelCat;
        private DataSetBib dataSetBib;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private DataSetBibTableAdapters.livreTableAdapter livreTableAdapter;

    }
}