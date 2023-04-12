﻿using ObiGarm.Reports.ReportsDate;
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
        // report one
        private DataTable dataTableReportOne;
        private string dateStartReportOne;
        private string dateEndReportOne;
        private string countClient;
        //

        // report two
        private DataTable dataTableReportTwoCountry;
        private DataTable dataTableReportTwoProvince;
        private string nameCountry;
        private string dateStartReportTwo;
        private string dateEndReportTwo;
        //

        // report three
        private DataTable dataTableTeket;
        private DataTable dataTableMoney;
        private string dateStartReportThree;
        private string dateEndReportThree;
        //

        //print report
        private string imruzDI;
        private string IDImuqarari;
        private string IDInimalodaraja;
        private string rafta;
        private string Rmuqarari; 
        private string Rnimalodaraja;
        private string darI;
        private string DImuqarari;
        private string DInimalodaraja;
        private string Oshkhona;
        private string Omuqarari;
        private string Onimalodaraja;
        private string hamguzariho;
        private string meraftagiho;
        private string Mmuqarari;
        private string Mnimalodaraja;
        private string rohhat;
        private string kvitansiy;
        private string darIstirohatgoh;
        private string Imuqarari;
        private string Inimalodaraja;
        //

        public PrintRortForm()
        {
            InitializeComponent();
        }

        public PrintRortForm(DataTable dataTableReportOne, string dateStartReportOne, string dateEndReportOne, string countClient)
        {
            InitializeComponent();
            reoportviewPrint.Visible = true;
            reportViewer.Visible = false;
            reportViewerThree.Visible = false;

            this.dataTableReportOne = dataTableReportOne;
            this.dateStartReportOne = dateStartReportOne;
            this.dateEndReportOne = dateEndReportOne;
            this.countClient = countClient;
        }

        public PrintRortForm(DataTable dataTableReportTwoCountry, DataTable dataTableReportTwoProvince, string nameCountry, string dateStartReportTwo, string dateEndReportTwo)
        {
            InitializeComponent();
            reoportviewPrint.Visible = false;
            reportViewer.Visible = true;
            reportViewerThree.Visible = false;

            this.dataTableReportTwoCountry = dataTableReportTwoCountry;
            this.dataTableReportTwoProvince = dataTableReportTwoProvince;
            this.nameCountry = nameCountry == "" ? " " : nameCountry;
            this.dateStartReportTwo = dateStartReportTwo == "" ? " " : dateStartReportTwo;
            this.dateEndReportTwo = dateEndReportTwo == "" ? " " : dateEndReportTwo;
        }

        public PrintRortForm(DataTable dataTableReportTecke, DataTable dataTableReportMoney,  string dateStartReportThree, string dateEndReportThree)
        {
            InitializeComponent();
            reoportviewPrint.Visible = false;
            reportViewer.Visible = false;
            reportViewerThree.Visible = true;

            this.dataTableTeket = dataTableReportTecke;
            this.dataTableMoney = dataTableReportMoney;
            this.dateStartReportThree = dateStartReportThree == "" ? " " : dateStartReportThree;
            this.dateEndReportThree = dateEndReportThree == "" ? " " : dateEndReportThree;
        }

        public PrintRortForm(string imruzDI, string iDImuqarari, string iDInimalodaraja, string rafta, string rmuqarari, string rnimalodaraja, string darI, string dImuqarari, string dInimalodaraja, string oshkhona, string omuqarari, string onimalodaraja, string hamguzariho, string meraftagiho, string mmuqarari, string mnimalodaraja, string rohhat, string kvitansiy, string darIstirohatgoh, string imuqarari, string inimalodaraja)
        {
            this.imruzDI = imruzDI;
            IDImuqarari = iDImuqarari;
            IDInimalodaraja = iDInimalodaraja;
            this.rafta = rafta;
            Rmuqarari = rmuqarari;
            Rnimalodaraja = rnimalodaraja;
            this.darI = darI;
            DImuqarari = dImuqarari;
            DInimalodaraja = dInimalodaraja;
            Oshkhona = oshkhona;
            Omuqarari = omuqarari;
            Onimalodaraja = onimalodaraja;
            this.hamguzariho = hamguzariho;
            this.meraftagiho = meraftagiho;
            Mmuqarari = mmuqarari;
            Mnimalodaraja = mnimalodaraja;
            this.rohhat = rohhat;
            this.kvitansiy = kvitansiy;
            this.darIstirohatgoh = darIstirohatgoh;
            Imuqarari = imuqarari;
            Inimalodaraja = inimalodaraja;
        }

        private void PrintRortForm_Load(object sender, EventArgs e)
        {
            if (dataTableReportOne != null)
            {
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
            else if (dataTableReportTwoCountry != null || dataTableReportTwoProvince != null)
            {
                Report2.FromCountryDataTable fromCountres = new Report2.FromCountryDataTable();
                Report2_1.FromProvinceDataTable fromProvinces = new Report2_1.FromProvinceDataTable();

                foreach (DataRow row in dataTableReportTwoCountry.Rows)
                {
                    Report2.FromCountryRow fromCountryRow = fromCountres.NewFromCountryRow();
                    fromCountryRow["row_number"] = row["row_number"];
                    fromCountryRow["country"] = row["country"];
                    fromCountryRow["count_men"] = row["count_men"];
                    fromCountryRow["count_woman"] = row["count_woman"];
                    fromCountryRow["count_all"] = row["count_all"];
                    fromCountres.Rows.Add(fromCountryRow);
                }

                Microsoft.Reporting.WinForms.ReportDataSource Report2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report2.Name = "Report2";
                Report2.Value = fromCountres;


                foreach (DataRow row in dataTableReportTwoProvince.Rows)
                {
                    Report2_1.FromProvinceRow fromCountryRow = fromProvinces.NewFromProvinceRow();
                    fromCountryRow["row_number"] = row["row_number"];
                    fromCountryRow["province"] = row["province"];
                    fromCountryRow["count_men"] = row["count_men"];
                    fromCountryRow["count_woman"] = row["count_woman"];
                    fromCountryRow["count_all"] = row["count_all"];
                    fromProvinces.Rows.Add(fromCountryRow);
                }

                Microsoft.Reporting.WinForms.ReportDataSource Report2_1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report2_1.Name = "Report2_1";
                Report2_1.Value = fromProvinces;

                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(Report2);
                this.reportViewer.LocalReport.DataSources.Add(Report2_1);


                Microsoft.Reporting.WinForms.ReportParameter[] p1 = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("datesart",  dateStartReportTwo),
                new Microsoft.Reporting.WinForms.ReportParameter("dateend",  dateEndReportTwo),
                new Microsoft.Reporting.WinForms.ReportParameter("country",  nameCountry),
                };

                this.reportViewer.LocalReport.SetParameters(p1);
                this.reportViewer.RefreshReport();

            }
            else if(dataTableMoney!=null && dataTableTeket!=null){

                Report3.ticketDataTable ticketDataTable = new Report3.ticketDataTable();
                Report3_1.ismonayDataTable ismonayDataTable = new Report3_1.ismonayDataTable();

                foreach (DataRow row in dataTableTeket.Rows)
                {
                    Report3.ticketRow ticketyRow = ticketDataTable.NewticketRow();
                    ticketyRow["row_number"] = row["row_number"];
                    ticketyRow["count_client"] = row["count_client"];
                    ticketyRow["count_day"] = row["count_day"];
                    ticketyRow["money_for_one_day"] = row["money_for_one_day"];
                    ticketyRow["sum"] = row["sum"];
                    ticketDataTable.Rows.Add(ticketyRow);
                }

                Microsoft.Reporting.WinForms.ReportDataSource Report3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report3.Name = "Report3";
                Report3.Value = ticketDataTable;


                foreach (DataRow row in dataTableMoney.Rows)
                {
                    Report3_1.ismonayRow ismonayRow = ismonayDataTable.NewismonayRow();
                    ismonayRow["row_number"] = row["row_number"];
                    ismonayRow["count_client"] = row["count_client"];
                    ismonayRow["count_day"] = row["count_day"];
                    ismonayRow["money_for_one_day"] = row["money_for_one_day"];
                    ismonayRow["sum"] = row["sum"];
                    ismonayDataTable.Rows.Add(ismonayRow);
                }

                Microsoft.Reporting.WinForms.ReportDataSource Report3_1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                Report3_1.Name = "Report3_1";
                Report3_1.Value = ismonayDataTable;

                this.reportViewerThree.LocalReport.DataSources.Clear();
                this.reportViewerThree.LocalReport.DataSources.Add(Report3);
                this.reportViewerThree.LocalReport.DataSources.Add(Report3_1);


                Microsoft.Reporting.WinForms.ReportParameter[] p2 = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("datestart",  dateStartReportThree),
                new Microsoft.Reporting.WinForms.ReportParameter("dateend",  dateEndReportThree)
                };

                this.reportViewerThree.LocalReport.SetParameters(p2);
                this.reportViewerThree.RefreshReport();
            }

        }
    }
}
