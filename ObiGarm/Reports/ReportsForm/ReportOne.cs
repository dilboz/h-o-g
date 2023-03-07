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
    public partial class ReportOne : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        public ReportOne()
        {
            InitializeComponent();

            sqlConfiguration = new SqlConfiguration();
        }

        int countClientint=0;
        string dateStart;
        string dateEnd;

        DataTable dataTableReportOne;

        void Display(DateTime dateTimeStart, DateTime dateTimeEnd, string age )
        {
            string querySql;
            string countClient;
            if (age=="0" || age=="" || age== null )
            {
                querySql = "select  ROW_NUMBER() OVER(ORDER BY c.id)  as 'number_row', c.number_order as 'order', concat('Бинои ', f.name, '/', r.name) as 'frime_and_room', concat(c.surname,' ',c.name) as 'full_name', c.year_birthday as 'burzday', TIMESTAMPDIFF(YEAR,  c.year_birthday, CURDATE()) AS 'age', date_format(c.date_time_start, '%Y-%m-%d') as 'start_date', date_format(c.date_time_end, '%Y-%m-%d') as 'enb_date', DATEDIFF(c.date_time_end , c.date_time_start)+1 as 'count_day', c.nuber_phon as 'number_phon' from client c " +
                   "inner join room r on c.id_room = r.id " +
                   "inner join frame f on r.id_freme  = f.id " +
                  $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeEnd.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}'; ";
                
                countClient = "select count(*) from client c " +
                        $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeEnd.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}'; ";
            }
            else
            {
                querySql = "select  ROW_NUMBER() OVER(ORDER BY c.id)  as 'number_row', c.number_order as 'order', concat('Бинои ', f.name, '/', r.name) as 'frime_and_room', concat(c.surname,' ',c.name) as 'full_name', c.year_birthday as 'burzday', TIMESTAMPDIFF(YEAR,  c.year_birthday, CURDATE()) AS 'age', date_format(c.date_time_start, '%Y-%m-%d') as 'start_date', date_format(c.date_time_end, '%Y-%m-%d') as 'enb_date', DATEDIFF(c.date_time_end , c.date_time_start)+1 as 'count_day', c.nuber_phon as 'number_phon' from client c " +
                    "inner join room r on c.id_room = r.id " +
                    "inner join frame f on r.id_freme  = f.id " +
                    $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeEnd.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}'; " +
                    $"having age = '{age}' ;";

                countClient = "select count(*), TIMESTAMPDIFF(YEAR,  c.year_birthday from client c " +
                    $"where date_format(c.date_time_start, '%Y-%m-%d') >= '{dateTimeEnd.ToString("yyyy-MM-dd")}' and  date_format(c.date_time_start, '%Y-%m-%d') <= '{dateTimeEnd.ToString("yyyy-MM-dd")}' " +
                    $"having age = '{age}' ;";
            }

            if (sqlConfiguration.sqlSelectQuery(countClient).Rows.Count!=0 && sqlConfiguration.sqlSelectQuery(countClient)!=null && sqlConfiguration.sqlSelectQuery(countClient).Rows[0]["count(*)"].ToString()!="0")
            {
                buttonPrint.Visible = true;
                countClientint = int.Parse(sqlConfiguration.sqlSelectQuery(countClient).Rows[0]["count(*)"].ToString());
                labelCountClent.Text = $"Ҳамагӣ: {sqlConfiguration.sqlSelectQuery(countClient).Rows[0]["count(*)"].ToString()} нафар";
            }
            else
            {
                buttonPrint.Visible = false;
                countClientint = 0;
                labelCountClent.Text = $"Ҳамагӣ: 0 нафар";
            }
           

            Console.WriteLine(querySql);

            dataTableReportOne = sqlConfiguration.sqlSelectQuery(querySql);

            sqlConfiguration.displayListExpress(querySql, gridControlReportOne);
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {

            Display(dateTimePickerStart.Value, dateTimePickerEnd.Value, txtEge.Text);

            dateStart = dateTimePickerStart.Value.ToString("yyyy.MM.dd");
            dateEnd = dateTimePickerEnd.Value.ToString("yyyy.MM.dd");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintRortForm printRortForm = new PrintRortForm(dataTableReportOne, dateStart, dateEnd, countClientint.ToString());
            printRortForm.ShowDialog();
        }
    }
}
