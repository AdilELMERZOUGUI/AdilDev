namespace DevApp1.Forms
{
    partial class repairSource
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
            this.btnImportDB = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtImportDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImportDB
            // 
            this.btnImportDB.Location = new System.Drawing.Point(394, 67);
            this.btnImportDB.Name = "btnImportDB";
            this.btnImportDB.Size = new System.Drawing.Size(107, 21);
            this.btnImportDB.TabIndex = 22;
            this.btnImportDB.Text = "Validé";
            this.btnImportDB.Click += new System.EventHandler(this.btnImportDB_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(14, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Importer database  :";
            // 
            // txtImportDB
            // 
            this.txtImportDB.Location = new System.Drawing.Point(168, 67);
            this.txtImportDB.Name = "txtImportDB";
            this.txtImportDB.Size = new System.Drawing.Size(227, 21);
            this.txtImportDB.TabIndex = 20;
            this.txtImportDB.Click += new System.EventHandler(this.txtImportDB_Click);
            // 
            // repairSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 154);
            this.Controls.Add(this.btnImportDB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtImportDB);
            this.IconOptions.ShowIcon = false;
            this.Name = "repairSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "repairSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnImportDB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtImportDB;
    }
}