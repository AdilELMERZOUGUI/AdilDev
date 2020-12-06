namespace GestionBibliothique
{
    partial class FormGestionDesEleves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionDesEleves));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCherch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnCherch = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonDelClasse = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.comboFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxTri = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewEleve = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboClasse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnBtn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtClasse = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel6.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
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
            this.metroPanel6.TabIndex = 6;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.button1.Location = new System.Drawing.Point(761, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 494);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.txtCherch);
            this.panel2.Controls.Add(this.metroLabel9);
            this.panel2.Controls.Add(this.btnCherch);
            this.panel2.Location = new System.Drawing.Point(344, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 32);
            this.panel2.TabIndex = 11;
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
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(3, 3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(180, 25);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Chercher Par ID Livre :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // btnCherch
            // 
            this.btnCherch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnCherch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCherch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCherch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCherch.ForeColor = System.Drawing.Color.White;
            this.btnCherch.Location = new System.Drawing.Point(356, 3);
            this.btnCherch.Name = "btnCherch";
            this.btnCherch.Size = new System.Drawing.Size(80, 24);
            this.btnCherch.TabIndex = 7;
            this.btnCherch.Text = "Chercher";
            this.btnCherch.UseCustomBackColor = true;
            this.btnCherch.UseCustomForeColor = true;
            this.btnCherch.UseSelectable = true;
            this.btnCherch.Click += new System.EventHandler(this.btnCherch_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(100, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 488);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.comboFilter);
            this.metroTabPage2.Controls.Add(this.txtClasse);
            this.metroTabPage2.Controls.Add(this.buttonDelClasse);
            this.metroTabPage2.Controls.Add(this.btnAddCat);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.comboBoxTri);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.dataGridViewEleve);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 446);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Gestion Des Elèves";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 3;
            // 
            // buttonDelClasse
            // 
            this.buttonDelClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.buttonDelClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelClasse.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelClasse.ForeColor = System.Drawing.Color.White;
            this.buttonDelClasse.Location = new System.Drawing.Point(734, 13);
            this.buttonDelClasse.Name = "buttonDelClasse";
            this.buttonDelClasse.Size = new System.Drawing.Size(32, 29);
            this.buttonDelClasse.TabIndex = 12;
            this.buttonDelClasse.Text = "-";
            this.buttonDelClasse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelClasse.UseVisualStyleBackColor = false;
            this.buttonDelClasse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.Color.White;
            this.btnAddCat.Location = new System.Drawing.Point(696, 13);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(32, 29);
            this.btnAddCat.TabIndex = 10;
            this.btnAddCat.Text = "+";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // comboFilter
            // 
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.ItemHeight = 23;
            this.comboFilter.Location = new System.Drawing.Point(486, 13);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(204, 29);
            this.comboFilter.TabIndex = 6;
            this.comboFilter.UseSelectable = true;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(343, 15);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(145, 25);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Filtrer par Classe :";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // comboBoxTri
            // 
            this.comboBoxTri.FormattingEnabled = true;
            this.comboBoxTri.ItemHeight = 23;
            this.comboBoxTri.Location = new System.Drawing.Point(111, 13);
            this.comboBoxTri.Name = "comboBoxTri";
            this.comboBoxTri.Size = new System.Drawing.Size(204, 29);
            this.comboBoxTri.TabIndex = 6;
            this.comboBoxTri.UseSelectable = true;
            this.comboBoxTri.SelectedIndexChanged += new System.EventHandler(this.comboBoxTri_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(8, 15);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 25);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Trier Par :";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.AllowUserToDeleteRows = false;
            this.dataGridViewEleve.AllowUserToResizeRows = false;
            this.dataGridViewEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEleve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEleve.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewEleve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewEleve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEleve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewEleve.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewEleve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEleve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEleve.ColumnHeadersHeight = 50;
            this.dataGridViewEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.ComboClasse,
            this.Column5,
            this.ColumnBtn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEleve.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEleve.EnableHeadersVisualStyles = false;
            this.dataGridViewEleve.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewEleve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewEleve.Location = new System.Drawing.Point(6, 68);
            this.dataGridViewEleve.MultiSelect = false;
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nexa", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEleve.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEleve.RowHeadersWidth = 20;
            this.dataGridViewEleve.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEleve.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEleve.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nexa", 14F);
            this.dataGridViewEleve.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEleve.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dataGridViewEleve.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEleve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewEleve.Size = new System.Drawing.Size(780, 377);
            this.dataGridViewEleve.TabIndex = 2;
            this.dataGridViewEleve.UseCustomBackColor = true;
            this.dataGridViewEleve.UseCustomForeColor = true;
            this.dataGridViewEleve.UseStyleColors = true;
            this.dataGridViewEleve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEleve_CellClick);
            this.dataGridViewEleve.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewEleve_DataError);
            this.dataGridViewEleve.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEleve_DefaultValuesNeeded);
            this.dataGridViewEleve.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewEleve_RowsAdded);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nom";
            this.Column1.HeaderText = "Nom Elève";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "prenom";
            this.Column2.HeaderText = "Prènom Elève";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datenaiss";
            this.Column3.HeaderText = "Date de Naissance";
            this.Column3.Name = "Column3";
            // 
            // ComboClasse
            // 
            this.ComboClasse.DataPropertyName = "id_classe";
            this.ComboClasse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ComboClasse.HeaderText = "Classe";
            this.ComboClasse.Name = "ComboClasse";
            this.ComboClasse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComboClasse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Confirmer";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Confirmer";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "Confirmer";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Confirmer";
            this.Column5.ToolTipText = "Confirmer";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // ColumnBtn2
            // 
            this.ColumnBtn2.DataPropertyName = "Supprimer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Supprimer";
            this.ColumnBtn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnBtn2.HeaderText = "Supprimer";
            this.ColumnBtn2.Name = "ColumnBtn2";
            this.ColumnBtn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBtn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnBtn2.Text = "Supprimer";
            this.ColumnBtn2.ToolTipText = "Supprimer";
            this.ColumnBtn2.UseColumnTextForButtonValue = true;
            // 
            // txtClasse
            // 
            // 
            // 
            // 
            this.txtClasse.CustomButton.Image = null;
            this.txtClasse.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtClasse.CustomButton.Name = "";
            this.txtClasse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClasse.CustomButton.TabIndex = 1;
            this.txtClasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClasse.CustomButton.UseSelectable = true;
            this.txtClasse.Lines = new string[0];
            this.txtClasse.Location = new System.Drawing.Point(505, 17);
            this.txtClasse.MaxLength = 32767;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.PasswordChar = '\0';
            this.txtClasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClasse.SelectedText = "";
            this.txtClasse.SelectionLength = 0;
            this.txtClasse.SelectionStart = 0;
            this.txtClasse.ShortcutsEnabled = true;
            this.txtClasse.ShowButton = true;
            this.txtClasse.ShowClearButton = true;
            this.txtClasse.Size = new System.Drawing.Size(164, 23);
            this.txtClasse.TabIndex = 3;
            this.txtClasse.UseCustomBackColor = true;
            this.txtClasse.UseCustomForeColor = true;
            this.txtClasse.UseSelectable = true;
            this.txtClasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormGestionDesEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel6);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Nexa", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDesEleves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionDesEleves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGestionDesEleves_Load);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtCherch;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnCherch;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox comboFilter;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboBoxTri;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dataGridViewEleve;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboClasse;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtn2;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button buttonDelClasse;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox txtClasse;
    }
}