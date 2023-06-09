
namespace ObiGarm.Reports.ReportsForm
{
    partial class PrintRortForm
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
            this.reoportviewPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerThree = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reoportviewPrint
            // 
            this.reoportviewPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reoportviewPrint.LocalReport.ReportEmbeddedResource = "ObiGarm.Reports.ReportsPrint.Report1.rdlc";
            this.reoportviewPrint.Location = new System.Drawing.Point(0, 0);
            this.reoportviewPrint.Margin = new System.Windows.Forms.Padding(0);
            this.reoportviewPrint.Name = "reoportviewPrint";
            this.reoportviewPrint.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reoportviewPrint.ServerReport.BearerToken = null;
            this.reoportviewPrint.Size = new System.Drawing.Size(1438, 782);
            this.reoportviewPrint.TabIndex = 1;
            this.reoportviewPrint.Visible = false;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.DocumentMapWidth = 88;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ObiGarm.Reports.ReportsPrint.Report2.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1438, 782);
            this.reportViewer.TabIndex = 2;
            // 
            // reportViewerThree
            // 
            this.reportViewerThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerThree.DocumentMapWidth = 88;
            this.reportViewerThree.LocalReport.ReportEmbeddedResource = "ObiGarm.Reports.ReportsPrint.Report3.rdlc";
            this.reportViewerThree.Location = new System.Drawing.Point(0, 0);
            this.reportViewerThree.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewerThree.Name = "reportViewerThree";
            this.reportViewerThree.ServerReport.BearerToken = null;
            this.reportViewerThree.Size = new System.Drawing.Size(1438, 782);
            this.reportViewerThree.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 88;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ObiGarm.Reports.ReportsPrint.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1438, 782);
            this.reportViewer1.TabIndex = 4;
            // 
            // PrintRortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 782);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.reportViewerThree);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.reoportviewPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintRortForm";
            this.Text = "PrintRortForm";
            this.Load += new System.EventHandler(this.PrintRortForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reoportviewPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThree;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}