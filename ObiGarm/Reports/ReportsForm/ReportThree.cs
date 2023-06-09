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
    public partial class ReportThree : Form
    {
        SqlConfiguration sqlConfiguration;
        public ReportThree()
        {
            InitializeComponent();

            sqlConfiguration = new SqlConfiguration();

            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerEnd.Value = DateTime.Now;
        }

        string dateStart;
        string dateEnd;

        DataTable dataTableReportThireeTecket;
        DataTable dataTableReportThreeMoney;

        void DisPlay(DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            string querySqlTecket;
            string querySqlMOney;

            querySqlTecket = "select row_number() over(order by c.id) as 'row_number', count(*) as 'count_client', " +
                "sum(datediff(c.date_time_end , c.date_time_start)) as 'count_day', round(c.nuber_money / datediff(c.date_time_end , " +
                "c.date_time_start),0) as 'money_for_one_day', sum(datediff(c.date_time_end , c.date_time_start) * c.nuber_money / datediff(c.date_time_end , " +
                "c.date_time_start)) as 'sum' from client c " +
                $"where c.id_type_money = '2' and date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeStart.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}' " +
                "group by c.nuber_money / datediff(c.date_time_end , c.date_time_start);";

            querySqlMOney = "select row_number() over(order by c.id) as 'row_number', count(*) as 'count_client', " +
                "sum(datediff(c.date_time_end , c.date_time_start)) as 'count_day', round(c.nuber_money / datediff(c.date_time_end , " +
                "c.date_time_start),0) as 'money_for_one_day', sum(datediff(c.date_time_end , c.date_time_start) * c.nuber_money / datediff(c.date_time_end , " +
                "c.date_time_start)) as 'sum' from client c " +
                $"where c.id_type_money = '1' and date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeStart.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}' " +
                "group by c.nuber_money / datediff(c.date_time_end , c.date_time_start);";


            dataTableReportThireeTecket = sqlConfiguration.sqlSelectQuery(querySqlTecket);
            sqlConfiguration.displayListExpress(querySqlTecket, gridControlTecket);

            dataTableReportThreeMoney = sqlConfiguration.sqlSelectQuery(querySqlMOney);
            sqlConfiguration.displayListExpress(querySqlMOney, gridControlMoney);
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            DisPlay(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            dateStart = dateTimePickerStart.Value.ToString("yyyy.MM.dd");
            dateEnd = dateTimePickerEnd.Value.ToString("yyyy.MM.dd");


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintRortForm printRortForm = new PrintRortForm(dataTableReportThireeTecket, dataTableReportThreeMoney, dateStart, dateEnd);
            printRortForm.ShowDialog();
        }
    }
}
