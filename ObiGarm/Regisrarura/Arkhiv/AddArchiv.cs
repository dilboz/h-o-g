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
    
    public partial class AddArchiv : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private readonly IsClient isClient;
        string id_client;

        DateTime cur_start_time, cur_end_time;

        public AddArchiv(IsClient isClient, string client_id)
        {
            this.isClient = isClient;
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

            if ((int.Parse(txt_count_day.Text) - count)<0)
            {
                MessageBox.Show("Шумо рузҳоро зиёд карда истодаед!");
                date_first_dey.Value = cur_start_time;
                date_end_dey.Value = cur_end_time;
            }
            else
            {
                txt_day_to_arkhiv.Text = (int.Parse(txt_count_day.Text) - count).ToString();
            }
            
        }

        private void date_end_dey_ValueChanged(object sender, EventArgs e)
        {
            count_day_for_arkhiv(date_first_dey.Value, date_end_dey.Value);
        }

        void edit_for_arkhiv(string id)
        {
            string day_to_arkhiv = txt_day_to_arkhiv.Text;
            string datetime_start = date_first_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            string up_date_client = "UPDATE client SET " +
                $"date_time_start =  str_to_date('{datetime_start}', '%m.%d.%Y %H:%i'), " +
                $"date_time_end = str_to_date('{datetime_end}', '%m.%d.%Y %H:%i'), " +
                $"dey_is_arkhiv = '{day_to_arkhiv}', " +
                $"is_for_vrach = '0', " +
                $"is_arkhiv = '1' " +
                $"WHERE id = '{id}'";


            if (day_to_arkhiv != "0")
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
                    isClient.display();
                }
            }
            else
            {
                MessageBox.Show("Шумо бо 0 руз махкам карда наметавонед!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddArchiv_Shown(object sender, EventArgs e)
        {
            set_info(this.id_client);
        }

        private void btn_save_money_Click(object sender, EventArgs e)
        {
            edit_for_arkhiv(this.id_client);
        }
    }
}
