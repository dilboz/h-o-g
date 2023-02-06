
namespace ObiGarm.Vrach
{
    partial class PrintForm
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
            this.SuspendLayout();
            // 
            // reoportviewPrint
            // 
            this.reoportviewPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reoportviewPrint.LocalReport.ReportEmbeddedResource = "ObiGarm.Vrach.ReportPrintFormVrach.rdlc";
            this.reoportviewPrint.Location = new System.Drawing.Point(0, 0);
            this.reoportviewPrint.Margin = new System.Windows.Forms.Padding(0);
            this.reoportviewPrint.Name = "reoportviewPrint";
            this.reoportviewPrint.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reoportviewPrint.ServerReport.BearerToken = null;
            this.reoportviewPrint.Size = new System.Drawing.Size(1039, 557);
            this.reoportviewPrint.TabIndex = 0;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 557);
            this.Controls.Add(this.reoportviewPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrintForm";
            this.ShowIcon = false;
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reoportviewPrint;
    }
}