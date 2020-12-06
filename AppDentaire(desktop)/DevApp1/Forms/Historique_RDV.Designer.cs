namespace DevApp1.Forms
{
    partial class Historique_RDV
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique_RDV));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridHistorique = new DevExpress.XtraGrid.GridControl();
            this.gridViewhistorique = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidRdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_rdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnComboRdv = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.toastDel = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewhistorique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComboRdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastDel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 56);
            this.panel1.TabIndex = 4;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.lbl_titre.Location = new System.Drawing.Point(17, 14);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(330, 28);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Historique des Rendez-vous";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblNom.Location = new System.Drawing.Point(164, 76);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 21);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(18, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nom de Patient : ";
            // 
            // gridHistorique
            // 
            this.gridHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistorique.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHistorique.Location = new System.Drawing.Point(22, 108);
            this.gridHistorique.MainView = this.gridViewhistorique;
            this.gridHistorique.Name = "gridHistorique";
            this.gridHistorique.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnComboRdv});
            this.gridHistorique.Size = new System.Drawing.Size(424, 195);
            this.gridHistorique.TabIndex = 7;
            this.gridHistorique.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewhistorique});
            // 
            // gridViewhistorique
            // 
            this.gridViewhistorique.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridViewhistorique.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.gridViewhistorique.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.gridViewhistorique.Appearance.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewhistorique.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.gridViewhistorique.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewhistorique.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewhistorique.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewhistorique.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewhistorique.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewhistorique.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewhistorique.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewhistorique.Appearance.Row.BorderColor = System.Drawing.Color.Transparent;
            this.gridViewhistorique.Appearance.Row.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewhistorique.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewhistorique.Appearance.Row.Options.UseBackColor = true;
            this.gridViewhistorique.Appearance.Row.Options.UseBorderColor = true;
            this.gridViewhistorique.Appearance.Row.Options.UseFont = true;
            this.gridViewhistorique.Appearance.Row.Options.UseForeColor = true;
            this.gridViewhistorique.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewhistorique.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewhistorique.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewhistorique.Appearance.RowSeparator.BackColor = System.Drawing.Color.Gray;
            this.gridViewhistorique.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewhistorique.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewhistorique.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewhistorique.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewhistorique.AppearancePrint.Row.BackColor = System.Drawing.Color.Transparent;
            this.gridViewhistorique.AppearancePrint.Row.BackColor2 = System.Drawing.Color.Transparent;
            this.gridViewhistorique.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridViewhistorique.ColumnPanelRowHeight = 27;
            this.gridViewhistorique.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidRdv,
            this.coldate_rdv,
            this.colPeriode,
            this.colpasse,
            this.gridColumn1});
            this.gridViewhistorique.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewhistorique.GridControl = this.gridHistorique;
            this.gridViewhistorique.Name = "gridViewhistorique";
            this.gridViewhistorique.OptionsPrint.PrintFooter = false;
            this.gridViewhistorique.OptionsPrint.PrintGroupFooter = false;
            this.gridViewhistorique.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridViewhistorique.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewhistorique.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewhistorique.OptionsView.ShowGroupPanel = false;
            this.gridViewhistorique.PaintStyleName = "MixedXP";
            this.gridViewhistorique.RowHeight = 35;
            // 
            // colidRdv
            // 
            this.colidRdv.Caption = "ID";
            this.colidRdv.FieldName = "ID";
            this.colidRdv.Name = "colidRdv";
            this.colidRdv.OptionsColumn.AllowEdit = false;
            this.colidRdv.OptionsColumn.AllowMove = false;
            this.colidRdv.OptionsColumn.ReadOnly = true;
            this.colidRdv.OptionsFilter.AllowFilter = false;
            this.colidRdv.Visible = true;
            this.colidRdv.VisibleIndex = 0;
            this.colidRdv.Width = 86;
            // 
            // coldate_rdv
            // 
            this.coldate_rdv.Caption = "Date rendez-vous";
            this.coldate_rdv.FieldName = "Date";
            this.coldate_rdv.Name = "coldate_rdv";
            this.coldate_rdv.OptionsColumn.AllowEdit = false;
            this.coldate_rdv.OptionsColumn.AllowMove = false;
            this.coldate_rdv.OptionsColumn.ReadOnly = true;
            this.coldate_rdv.OptionsFilter.AllowFilter = false;
            this.coldate_rdv.Visible = true;
            this.coldate_rdv.VisibleIndex = 1;
            this.coldate_rdv.Width = 135;
            // 
            // colPeriode
            // 
            this.colPeriode.Caption = "Période";
            this.colPeriode.FieldName = "Periode";
            this.colPeriode.Name = "colPeriode";
            this.colPeriode.OptionsColumn.AllowEdit = false;
            this.colPeriode.OptionsColumn.AllowMove = false;
            this.colPeriode.OptionsColumn.ReadOnly = true;
            this.colPeriode.OptionsFilter.AllowFilter = false;
            this.colPeriode.Visible = true;
            this.colPeriode.VisibleIndex = 2;
            this.colPeriode.Width = 61;
            // 
            // colpasse
            // 
            this.colpasse.Caption = "Passé ";
            this.colpasse.FieldName = "Passe";
            this.colpasse.Name = "colpasse";
            this.colpasse.OptionsColumn.AllowEdit = false;
            this.colpasse.OptionsColumn.AllowMove = false;
            this.colpasse.OptionsColumn.ReadOnly = true;
            this.colpasse.OptionsFilter.AllowAutoFilter = false;
            this.colpasse.OptionsFilter.AllowFilter = false;
            this.colpasse.Visible = true;
            this.colpasse.VisibleIndex = 3;
            this.colpasse.Width = 74;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.Caption = "Action";
            this.gridColumn1.ColumnEdit = this.btnComboRdv;
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 51;
            // 
            // btnComboRdv
            // 
            this.btnComboRdv.Appearance.BackColor = System.Drawing.Color.White;
            this.btnComboRdv.Appearance.Options.UseBackColor = true;
            this.btnComboRdv.AutoHeight = false;
            this.btnComboRdv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(15, 15);
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(20, 20);
            editorButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions3.SvgImage")));
            editorButtonImageOptions3.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnComboRdv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, false, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnComboRdv.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnComboRdv.Name = "btnComboRdv";
            this.btnComboRdv.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnComboRdv_ButtonClick);
            // 
            // toastDel
            // 
            this.toastDel.ApplicationId = "8916491d-3488-43b9-a86c-9d1208acff24";
            this.toastDel.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("ff3f8021-4b59-4919-b8e3-0d66a6960203", global::DevApp1.Properties.Resources.about_32x328, "Devmer", "Rendez-vous supprimé avec succés", "Devmer", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Historique_RDV
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 315);
            this.Controls.Add(this.gridHistorique);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historique_RDV";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Historique_RDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewhistorique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComboRdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridHistorique;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewhistorique;
        private DevExpress.XtraGrid.Columns.GridColumn colidRdv;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_rdv;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriode;
        private DevExpress.XtraGrid.Columns.GridColumn colpasse;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox btnComboRdv;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastDel;
    }
}