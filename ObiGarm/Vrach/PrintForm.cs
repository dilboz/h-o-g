using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Vrach
{
    public partial class PrintForm : Form
    {
        private DataTable datatabel;
        private string name_client;
        private string soli_t;
        private string jins;
        private string muhlati_tabobat;
        private string qad;
        private string vazn;
        private string hqsina;
        private string qobiliyati_nafaskashi;
        private string sanji_bozuho;
        private string tarkibi_hun;
        private string nabz;
        private string harorat;
        private string ekg;
        private string peshob;
        private string najosat;
        private string uzi;
        private string nahory;
        private string nisfiruzi;
        private string begohi;
        private string doctor;
        private string nishonai_tabobat;
        private string order;
        private string fisori_hun;


        public PrintForm(DataTable datatable, string name_client, string soli_t, string jins, string muhlati_tabobat, string qad,
            string vazn, string hqsina, string qobiliyati_nafaskashi, string sanji_bozuho, string tarkibi_hun,
            string nabz, string harorat, string ekg,
            string peshob, string najosat, string uzi, string nahory, string nisfiruzi, string begohi, string doctor, string nishonai_tabobat, string order, string fisori_hun)
        {
            InitializeComponent();
            this.datatabel = datatable;
            this.name_client = name_client == "" ? " " : name_client;
            this.soli_t = soli_t == "" ? " " : soli_t;
            this.jins = jins == "" ? " " : jins;
            this.muhlati_tabobat = muhlati_tabobat == "" ? " " : muhlati_tabobat;
            this.qad = qad == "" ? " " : qad;
            this.vazn = vazn == "" ? " " : vazn;
            this.hqsina = hqsina == "" ? " " : hqsina;
            this.qobiliyati_nafaskashi = qobiliyati_nafaskashi == "" ? " " : qobiliyati_nafaskashi;
            this.sanji_bozuho = sanji_bozuho == "" ? " " : sanji_bozuho;
            this.tarkibi_hun = tarkibi_hun == "" ? " " : tarkibi_hun;
            this.nabz = nabz == "" ? " " : nabz;
            this.harorat = harorat == "" ? " " : harorat;
            this.ekg = ekg == "" ? " " : ekg;
            this.peshob = peshob == "" ? " " : peshob;
            this.najosat = najosat == "" ? " " : najosat;
            this.uzi = uzi == "" ? " " : uzi;
            this.nahory = nahory == "" ? " " : nahory;
            this.nisfiruzi = nisfiruzi == "" ? " " : nisfiruzi;
            this.begohi = begohi == "" ? " " : begohi;
            this.doctor = doctor == "" ? " " : doctor;
            this.nishonai_tabobat = nishonai_tabobat == "" ? " " : nishonai_tabobat;
            this.order = order == "" ? " " : order;
            this.fisori_hun = fisori_hun == "" ? " " : fisori_hun;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

            DataTableInfoServoces.ServisessDataTable servisessRows = new DataTableInfoServoces.ServisessDataTable();

            //MessageBox.Show(datatabel.Rows.Count.ToString());

            foreach (DataRow row in datatabel.Rows)
            {
                DataTableInfoServoces.ServisessRow sRow = servisessRows.NewServisessRow();
                sRow["name_spitsalist"] = row["name_spitsalist"].ToString();
                sRow["name_services"] = row["name_services"].ToString();
                sRow["time_services"] = row["time_services"].ToString();
                servisessRows.Rows.Add(sRow);
            }

            
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource.Name = "DataSetTable";
            reportDataSource.Value = servisessRows;
            this.reoportviewPrint.LocalReport.DataSources.Clear();
            this.reoportviewPrint.LocalReport.DataSources.Add(reportDataSource);




            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("full_name_client",  name_client),
                new Microsoft.Reporting.WinForms.ReportParameter("soli_tavalud",  soli_t),
                new Microsoft.Reporting.WinForms.ReportParameter("jins",  jins),
                new Microsoft.Reporting.WinForms.ReportParameter("muhlati_tabobat",  muhlati_tabobat),
                new Microsoft.Reporting.WinForms.ReportParameter("qad",  qad),
                new Microsoft.Reporting.WinForms.ReportParameter("vazn",  vazn),
                new Microsoft.Reporting.WinForms.ReportParameter("hq_sina",  hqsina),
                new Microsoft.Reporting.WinForms.ReportParameter("qobliyati_nafaskashi",  qobiliyati_nafaskashi),
                new Microsoft.Reporting.WinForms.ReportParameter("fishori_hun",  fisori_hun),
                new Microsoft.Reporting.WinForms.ReportParameter("tarkibi_hun",  tarkibi_hun),
                new Microsoft.Reporting.WinForms.ReportParameter("nabz",  nabz),
                new Microsoft.Reporting.WinForms.ReportParameter("harorat",  harorat),
                new Microsoft.Reporting.WinForms.ReportParameter("ekg",  ekg),
                new Microsoft.Reporting.WinForms.ReportParameter("peshob",  peshob),
                new Microsoft.Reporting.WinForms.ReportParameter("najosat",  najosat),
                new Microsoft.Reporting.WinForms.ReportParameter("uzi",  uzi),
                new Microsoft.Reporting.WinForms.ReportParameter("nahori",  nahory),
                new Microsoft.Reporting.WinForms.ReportParameter("h_nisfiruzi",  nisfiruzi),
                new Microsoft.Reporting.WinForms.ReportParameter("h_begohruzi",  begohi),
                new Microsoft.Reporting.WinForms.ReportParameter("doctor",  doctor),
                new Microsoft.Reporting.WinForms.ReportParameter("nishonai_tabobat",  nishonai_tabobat),
                new Microsoft.Reporting.WinForms.ReportParameter("order",  order),
                new Microsoft.Reporting.WinForms.ReportParameter("quvai_bozuho",  sanji_bozuho)

           };
            this.reoportviewPrint.LocalReport.SetParameters(p);
            this.reoportviewPrint.RefreshReport();
        }
    }

}
