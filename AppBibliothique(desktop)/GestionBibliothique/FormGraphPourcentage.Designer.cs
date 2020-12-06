namespace GestionBibliothique
{
    partial class FormGraphPourcentage
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
            this.crystalReportViewerGraph = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportGraph1 = new GestionBibliothique.CrystalReportGraph();
            this.CrystalReportGraph2 = new GestionBibliothique.CrystalReportGraph();
            this.SuspendLayout();
            // 
            // crystalReportViewerGraph
            // 
            this.crystalReportViewerGraph.ActiveViewIndex = -1;
            this.crystalReportViewerGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerGraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerGraph.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerGraph.Name = "crystalReportViewerGraph";
            this.crystalReportViewerGraph.Size = new System.Drawing.Size(601, 386);
            this.crystalReportViewerGraph.TabIndex = 0;
            this.crystalReportViewerGraph.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormGraphPourcentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 386);
            this.Controls.Add(this.crystalReportViewerGraph);
            this.Name = "FormGraphPourcentage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGraphPourcentage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGraphPourcentage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerGraph;
        private CrystalReportGraph CrystalReportGraph1;
        private CrystalReportGraph CrystalReportGraph2;
    }
}