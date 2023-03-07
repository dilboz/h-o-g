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
        private string id_client;
        private int full_day;
        private bool set;

        public AddArchiv(IsClient isClient, string client_id)
        {
            this.isClient = isClient;
            this.id_client = client_id;
            sqlConfiguration = new SqlConfiguration();
            InitializeComponent();
            set = false;
        }

        void set_info(string id)
        {
            string select_sql = "select concat(client.surname, ' ', client.name, ' ', client.patromic ) as 'full_name',  client.date_time_start, client.date_time_end " +
                "from client " +
                $"where client.id='{id}';";

            DataTable dataTable_info = sqlConfiguration.sqlSelectQuery(select_sql);

            txt_full_name.Text = dataTable_info.Rows[0]["full_name"].ToString();

            date_first_dey.Value = DateTime.Parse(dataTable_info.Rows[0]["date_time_start"].ToString()) ;
            date_end_dey.Value = DateTime.Parse(dataTable_info.Rows[0]["date_time_end"].ToString());
            full_day = Convert.ToInt32((date_end_dey.Value - date_first_dey.Value).TotalDays);

            //MessageBox.Show(full_day.ToString());
        }


        void edit_for_arkhiv(string id)
        {
            string day_to_arkhiv = txt_day_to_arkhiv.Text;
            string datetime_start = date_first_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            string sele = $"select id_kort  from client where id ='{id}';";

            string up_date_client = "UPDATE client SET " +
                $"date_time_start =  str_to_date('{datetime_start}', '%m.%d.%Y %H:%i'), " +
                $"date_time_end = str_to_date('{datetime_end}', '%m.%d.%Y %H:%i'), " +
                $"count_day_to_arkhiv = '{day_to_arkhiv}', " +
                $"enable = '0' " +
                $"WHERE id = '{id}'";

            if (sqlConfiguration.sqlSelectQuery(sele).Rows.Count != 0)
                SettingsDatabase.setFaleActiveKort(sqlConfiguration.sqlSelectQuery(sele).Rows[0]["id_kort"].ToString());

            if (set==true)
            {
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
            else
            {
                MessageBox.Show("Шумо наметавонед муштариро махкам кунед \nШумо рузро хато интихоб кардед!");
            }
           
        }


        private void AddArchiv_Shown(object sender, EventArgs e)
        {
            set_info(this.id_client);
        }


        private void btn_save_money_Click(object sender, EventArgs e)
        {
            edit_for_arkhiv(this.id_client);
        }

        private void date_end_dey_ValueChanged(object sender, EventArgs e)
        {
            int count_day_maq = Convert.ToInt32((date_end_dey.Value - date_first_dey.Value).TotalDays);

            if (set)
                if (full_day - count_day_maq < 0 || full_day - count_day_maq > full_day)
                    MessageBox.Show("Шумо наметавонед муштариро махкам кунед \nШумо рузро хато интихоб кардед!");
                else
                    txt_day_to_arkhiv.Text = Convert.ToString(full_day - count_day_maq);
            else
                set = true;           
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
