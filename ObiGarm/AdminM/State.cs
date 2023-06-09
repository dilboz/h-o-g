using DevExpress.XtraRichEdit.Fields;
using MySqlX.XDevAPI;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace ObiGarm.AdminM
{
    public partial class State : Form
    {
        SqlConfiguration sqlConfiguration;

        public State()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            ShowCharGirlAndMen();
            ShowChartYerys();
            ShowChartMoth();
        }

        private void ShowCharGirlAndMen()
        {
            string query = "select sum(case when c.id_sex = 1 then 1 else 0 end) as 'men', sum(case when c.id_sex = 2 then 1 else 0 end) as 'women' from client c;\r\n";

            DataTable dt = sqlConfiguration.sqlSelectQuery(query);

            int countMen = int.Parse(dt.Rows[0][0].ToString());
            int countWomen = int.Parse(dt.Rows[0][1].ToString());

            double perMen = (countMen * 100) / (countMen + countWomen);
            double perWomen = (countWomen * 100) / (countMen + countWomen);

            Console.WriteLine("M>>" + perMen + "W>>" + perWomen);

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            // Add data points for "Men" and "Women"
            DataPoint menDataPoint = new DataPoint();
            menDataPoint.Color = Color.Green;
            menDataPoint.AxisLabel = $"Мард - {perMen}%";
            menDataPoint.YValues = new double[] { perMen }; // Set the value for men (e.g., 50)
            series.Points.Add(menDataPoint);

            DataPoint womenDataPoint = new DataPoint();
            menDataPoint.Color = Color.Red;
            womenDataPoint.AxisLabel = $"Зан - {perWomen}%";
            womenDataPoint.YValues = new double[] { perWomen }; // Set the value for women (e.g., 70)
            series.Points.Add(womenDataPoint);

            // Add the series to the chart
            chart1.Series.Add(series);
        }

        private void ShowChartYerys()
        {
            string query = "SELECT FLOOR(DATEDIFF(CURDATE(), year_birthday) / 365) AS client_age, COUNT(*) AS client_count FROM client GROUP BY client_age;";
            DataTable dt = sqlConfiguration.sqlSelectQuery(query);

            string countQuery = "SELECT  count(client.id) FROM client";
            DataTable dt1 = sqlConfiguration.sqlSelectQuery(countQuery);

            int count = int.Parse(dt1.Rows[0][0].ToString());

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataPoint menDataPoint = new DataPoint();
                menDataPoint.LegendText = dt.Rows[i][0].ToString() + $" Сола - {(double)((int.Parse(dt.Rows[i][1].ToString()) * 100) / count)}%";
                menDataPoint.YValues = new double[] { (double)((int.Parse(dt.Rows[i][1].ToString()) * 100) / count)}; // Set the value for men (e.g., 50)
                menDataPoint.Label = "";
                series.Points.Add(menDataPoint);
            }

            chart2.Series.Add(series);

        }

        private void ShowChartMoth()
        {
            string query = "select date_format(date_registration, '%M-%Y') AS 'date' , count(*) as 'count' from client group by month(date_registration);";

            DataTable dt = sqlConfiguration.sqlSelectQuery(query);

            string countQuery = "SELECT  count(client.id) FROM client";
            DataTable dt1 = sqlConfiguration.sqlSelectQuery(countQuery);

            int count = int.Parse(dt1.Rows[0][0].ToString());

            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataPoint menDataPoint = new DataPoint();
                menDataPoint.AxisLabel = dt.Rows[i][0].ToString();
                menDataPoint.YValues = new double[] { double.Parse(dt.Rows[i][1].ToString()) }; // Set the value for men (e.g., 50)
                series.Points.Add(menDataPoint);
            }

            chart3.Series.Add(series);

        }

    }

}
