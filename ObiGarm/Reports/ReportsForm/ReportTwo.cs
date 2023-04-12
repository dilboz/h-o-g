using ObiGarm.ClassDatabase;
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
    public partial class ReportTwo : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        public ReportTwo()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();

            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerEnd.Value = DateTime.Now;

            loadComboCountry();
        }

        private string nameCountry;

        private string dateStart;
        string dateEnd;

        DataTable dataTableReportTwoCpontry;
        DataTable dataTableReportTwoProvince;

        void loadComboCountry()
        {
            string querySqlForCountryName = "select  * from country  where deleted is null;";
            sqlConfiguration.LoadComboDE(querySqlForCountryName, "name", "id", combo_country);
        }

        void msg(string messeg) { messDilalog.Text = messeg; messDilalog.Show(); }

        void DisPlay(DateTime dateTimeStart, DateTime dateTimeEnd)
        {

            string idCountry;
            if (combo_country.EditValue!=null)
            {
                idCountry = combo_country.EditValue.ToString();
                nameCountry = combo_country.Text;
            }
            else{
                msg("Шумо кишваррро интихоб накардед!");
                return;
            }
            
            string querySqlCountry;
            string querySqlProvince;

            if (idCountry != "" && idCountry != null)
            {
                querySqlCountry = "select ROW_NUMBER() OVER(ORDER BY c.id) as 'row_number', co.name as 'country', sum(case when c.id_sex = 1 then 1 else 0 end) as 'count_men', " +
                    "sum(case when c.id_sex = 2 then 1 else 0 end) as 'count_woman', count(c.id_county) as 'count_all' " +
                    "from client c " +
                    "inner join country co on c.id_county = co.id " +
                    $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeStart.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}' " +
                    $"group by c.id_county; ";

                querySqlProvince = "select 	 c.id_county, row_number() over(	order by c.id) as 'row_number', p.name as 'province', sum(case when c.id_sex = 1 then 1 else 0 end) as 'count_men', " +
                    "sum(case when c.id_sex = 2 then 1 else 0 end) as 'count_woman', count(c.id_county) as 'count_all' " +
                    "from client c " +
                    "inner join province p on c.id_province  = p.id  " +
                    $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeStart.ToString("yyyy-MM-dd")}' " +
                    $"and date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}' " +
                    $"group by c.id_province  having c.id_county = '{idCountry}';";

                Console.WriteLine(querySqlProvince); 

                dataTableReportTwoCpontry = sqlConfiguration.sqlSelectQuery(querySqlCountry);
                sqlConfiguration.displayListExpress(querySqlCountry, gridControlCountry); 

                dataTableReportTwoProvince = sqlConfiguration.sqlSelectQuery(querySqlProvince);
                sqlConfiguration.displayListExpress(querySqlProvince, gridControlProvince);
            }
            else
            {
                msg("Шумо кишваррро интихоб накардед!");
                return;
            }
        }



        private void buttonAns_Click(object sender, EventArgs e)
        {
            DisPlay(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            dateStart = dateTimePickerStart.Value.ToString("yyyy.MM.dd");
            dateEnd = dateTimePickerEnd.Value.ToString("yyyy.MM.dd");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintRortForm printRortForm = new PrintRortForm(dataTableReportTwoCpontry, dataTableReportTwoProvince, combo_country.Text, dateStart, dateEnd);
            printRortForm.ShowDialog();
        }
    }
}
