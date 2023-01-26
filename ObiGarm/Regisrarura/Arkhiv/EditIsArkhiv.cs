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

namespace ObiGarm.Regisrarura.Arkhiv
{
    public partial class EditIsArkhiv : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private readonly ListArkhiv listArkhiv;
        string id_client;

        private bool is_sqve = false;

        DateTime cur_start_time, cur_end_time;
        public EditIsArkhiv(ListArkhiv listArkhiv, string client_id)
        {
            this.listArkhiv = listArkhiv;
            this.id_client = client_id;
            sqlConfiguration = new SqlConfiguration();
            InitializeComponent();
        }

        void set_info(string id)
        {
            string select_sql = "select concat(client.surname, ' ', client.name, ' ', client.patromic ) as 'full_name',  client.count_day, client.date_time_start, client.date_time_end " +
                "from client " +
                $"where client.id='{id}';";

            DataTable dataTable_info = sqlConfiguration.sqlSelectQuery(select_sql);

            txt_full_name.Text = dataTable_info.Rows[0]["full_name"].ToString();
            txt_count_day.Text = dataTable_info.Rows[0]["count_day"].ToString();

            cur_start_time = date_first_dey.Value = Convert.ToDateTime(dataTable_info.Rows[0]["date_time_start"].ToString());
            cur_end_time = date_end_dey.Value = Convert.ToDateTime(dataTable_info.Rows[0]["date_time_end"].ToString());

            count_day_for_arkhiv(date_first_dey.Value, date_end_dey.Value);
        }

        private void date_end_dey_ValueChanged(object sender, EventArgs e)
        {
            count_day_for_arkhiv(date_first_dey.Value, date_end_dey.Value);
        }


        void edit_for_arkhiv(string id)
        {
            string datetime_start = date_first_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            string up_date_client = "UPDATE client SET " +
                $"date_time_start =  str_to_date('{datetime_start}', '%m.%d.%Y %H:%i'), " +
                $"date_time_end = str_to_date('{datetime_end}', '%m.%d.%Y %H:%i'), " +
                $"dey_is_arkhiv = '0', " +
                $"is_for_vrach = '1', " +
                $"is_arkhiv = '0' " +
                $"WHERE id = '{id}'";


            if (is_sqve == false)
            {
                int result = sqlConfiguration.sqlQuery(up_date_client);
                if (result == 500)
                {
                    txt_full_name.Text = up_date_client;
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                    listArkhiv.display();
                }
            }
            else
            {
                MessageBox.Show("Шумо бояд ба монандм рузи боқимонда интхоб кунед!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditIsArkhiv_Shown(object sender, EventArgs e)
        {
            set_info(this.id_client);
        }

        private void btn_save_money_Click(object sender, EventArgs e)
        {
            edit_for_arkhiv(this.id_client);
        }

        void count_day_for_arkhiv(DateTime strt_time, DateTime end_time)
        {
            DateTime start_date = strt_time;
            DateTime end_date = end_time; ;

            int count = 0;
            while (start_date <= end_date)
            {
                count++;
                start_date = start_date.AddDays(1);
            }

            if ((int.Parse(txt_count_day.Text) - count) != 0)
            {
                MessageBox.Show("Шумо бояд ба монандм рузи боқимонда интхоб кунед!");
                date_first_dey.Value = cur_start_time;
                date_end_dey.Value = cur_end_time;
                is_sqve = false;
            }
            else
            {
                is_sqve = true;
            }

        }
    }
}
