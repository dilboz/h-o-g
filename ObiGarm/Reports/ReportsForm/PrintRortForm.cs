using ObiGarm.Reports.ReportsDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Reports.ReportsForm
{
    public partial class PrintRortForm : Form
    {

        private DataTable dataTableReportOne;
        private string dateStartReportOne;
        private string dateEndReportOne;
        private string countClient;


        

        public PrintRortForm()
        {
            InitializeComponent();
        }

        public PrintRortForm(DataTable dataTableReportOne, string dateStartReportOne, string dateEndReportOne, string countClient)
        {
            InitializeComponent();
            this.dataTableReportOne = dataTableReportOne;
            this.dateStartReportOne = dateStartReportOne;
            this.dateEndReportOne = dateEndReportOne;
            this.countClient = countClient;
        }

        private void PrintRortForm_Load(object sender, EventArgs e)
        {
            if (dataTableReportOne!=null)
            {
                this.reoportviewPrint.LocalReport.ReportEmbeddedResource = "ObiGarm.Reports.ReportsPrint.Report1.rdlc";

                Report1.Report1DataTable report1 = new Report1.Report1DataTable();

                foreach (DataRow row in dataTableReportOne.Rows)
                {
                    Report1.Report1Row report1Row = report1.NewReport1Row();
                    report1Row["id"] = row["number_row"];
                    report1Row["order"] = row["order"];
                    report1Row["frime_and_room"] = row["frime_and_room"];
                    report1Row["full_name"] = row["full_name"];
                    report1Row["birzday"] = row["burzday"];
                    report1Row["start_date"] = row["start_date"];
                    report1Row["end_date"] = row["enb_date"];
                    report1Row["count_day"] = row["count_day"];
                    report1Row["number_phon"] = row["number_phon"];
                    report1.Rows.Add(report1Row);
                }

                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource.Name = "Report1";
                reportDataSource.Value = report1;
                this.reoportviewPrint.LocalReport.DataSources.Clear();
                this.reoportviewPrint.LocalReport.DataSources.Add(reportDataSource);

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("datesart",  dateStartReportOne),
                new Microsoft.Reporting.WinForms.ReportParameter("dateend",  dateEndReportOne),
                new Microsoft.Reporting.WinForms.ReportParameter("count",  countClient),
                };

                this.reoportviewPrint.LocalReport.SetParameters(p);
                this.reoportviewPrint.RefreshReport();
            }
        }
    }
}
