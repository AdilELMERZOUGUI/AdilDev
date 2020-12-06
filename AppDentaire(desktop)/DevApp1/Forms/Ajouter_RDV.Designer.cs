﻿namespace DevApp1.Forms
{
    partial class Ajouter_RDV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboPeriode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateRDV = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckboxDisponible = new DevExpress.XtraEditors.CheckEdit();
            this.toastAdd = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label778 = new System.Windows.Forms.Label();
            this.lblNbRDV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRDV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckboxDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 56);
            this.panel1.TabIndex = 14;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.lbl_titre.Location = new System.Drawing.Point(17, 14);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(263, 28);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Nouvelle rendez-vous";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(306, 241);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 28);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Enregistrer";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboPeriode
            // 
            this.comboPeriode.EditValue = "Matin";
            this.comboPeriode.Location = new System.Drawing.Point(216, 158);
            this.comboPeriode.Name = "comboPeriode";
            this.comboPeriode.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboPeriode.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPeriode.Properties.Appearance.Options.UseBackColor = true;
            this.comboPeriode.Properties.Appearance.Options.UseFont = true;
            this.comboPeriode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboPeriode.Properties.Items.AddRange(new object[] {
            "Matin",
            "Soir"});
            this.comboPeriode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboPeriode.Size = new System.Drawing.Size(174, 22);
            this.comboPeriode.TabIndex = 20;
            this.comboPeriode.SelectedIndexChanged += new System.EventHandler(this.comboPeriode_SelectedIndexChanged);
            // 
            // dateRDV
            // 
            this.dateRDV.EditValue = new System.DateTime(2020, 11, 23, 15, 14, 8, 0);
            this.dateRDV.Location = new System.Drawing.Point(22, 158);
            this.dateRDV.Name = "dateRDV";
            this.dateRDV.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateRDV.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRDV.Properties.Appearance.Options.UseBackColor = true;
            this.dateRDV.Properties.Appearance.Options.UseFont = true;
            this.dateRDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRDV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRDV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateRDV.Size = new System.Drawing.Size(136, 22);
            this.dateRDV.TabIndex = 19;
            this.dateRDV.EditValueChanged += new System.EventHandler(this.dateRDV_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(212, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Période :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblNom.Location = new System.Drawing.Point(164, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 21);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "Nom : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(18, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nom de Patient : ";
            // 
            // ckboxDisponible
            // 
            this.ckboxDisponible.Location = new System.Drawing.Point(22, 204);
            this.ckboxDisponible.Name = "ckboxDisponible";
            this.ckboxDisponible.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxDisponible.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ckboxDisponible.Properties.Appearance.Options.UseFont = true;
            this.ckboxDisponible.Properties.Appearance.Options.UseForeColor = true;
            this.ckboxDisponible.Properties.Caption = "Disponible en salle d\'attente";
            this.ckboxDisponible.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ckboxDisponible.Size = new System.Drawing.Size(228, 20);
            this.ckboxDisponible.TabIndex = 23;
            // 
            // toastAdd
            // 
            this.toastAdd.ApplicationId = "8916491d-3488-43b9-a86c-9d1208acff24";
            this.toastAdd.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("3cc53fe8-e357-4b86-b11f-493dc4e86bec", global::DevApp1.Properties.Resources.about_32x323, "Devmer", "Le rendez-vous programmé avec succés", "Devmer", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // label778
            // 
            this.label778.AutoSize = true;
            this.label778.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label778.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.label778.Location = new System.Drawing.Point(18, 93);
            this.label778.Name = "label778";
            this.label778.Size = new System.Drawing.Size(215, 19);
            this.label778.TabIndex = 16;
            this.label778.Text = "Nombre des rendez-vous : ";
            // 
            // lblNbRDV
            // 
            this.lblNbRDV.AutoSize = true;
            this.lblNbRDV.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNbRDV.ForeColor = System.Drawing.Color.Gray;
            this.lblNbRDV.Location = new System.Drawing.Point(239, 91);
            this.lblNbRDV.Name = "lblNbRDV";
            this.lblNbRDV.Size = new System.Drawing.Size(44, 21);
            this.lblNbRDV.TabIndex = 15;
            this.lblNbRDV.Text = "7/10";
            // 
            // Ajouter_RDV
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 281);
            this.Controls.Add(this.ckboxDisponible);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.comboPeriode);
            this.Controls.Add(this.dateRDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNbRDV);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label778);
            this.Controls.Add(this.label7);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_RDV";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ajouter_RDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboPeriode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRDV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckboxDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btn_Save;
        private DevExpress.XtraEditors.ComboBoxEdit comboPeriode;
        private DevExpress.XtraEditors.DateEdit dateRDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckEdit ckboxDisponible;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastAdd;
        private System.Windows.Forms.Label label778;
        private System.Windows.Forms.Label lblNbRDV;
    }
}