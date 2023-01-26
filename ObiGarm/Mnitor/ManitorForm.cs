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

namespace ObiGarm.Mnitor
{
    public partial class ManitorForm : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;

        //public static ManitorForm manitorForm;
        public ManitorForm()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            //manitorForm = this;

            MessageBox.Show("shows");
        }


        string id_manitor = "1";

        List<top_16> top_16_client = new List<top_16>();


        private void timer_select_Tick(object sender, EventArgs e)
        {
            new_client(DateTime.Now);
            label_info_top.Text = $"НИЗОМИ НАВБАТИ ИДОРАКУНИИ ЭЛЕКТРОНӢ: ИМРУЗ {DateTime.Now.ToString("D")} СОАТ {DateTime.Now.ToString("T")}";
            label_info_botton.Text = $"Мизоҷони муҳтарам навбати худро интизор шавед!";
            Label[] label_full_name = { label_full_name_client_quer_1, label_full_name_client_quer_2, label_full_name_client_quer_3,
                label_full_name_client_quer_4, label_full_name_client_quer_5, label_full_name_client_quer_6, label_full_name_client_quer_7,
            label_full_name_client_quer_8, label_full_name_client_quer_9, label_full_name_client_quer_10, label_full_name_client_quer_11,
                label_full_name_client_quer_12, label_full_name_client_quer_13, label_full_name_client_quer_14, label_full_name_client_quer_15, label_full_name_client_quer_16};
            Label[] label_time = { label_time_quer_1, label_time_quer_2, label_time_quer_3,
                label_time_quer_4, label_time_quer_5, label_time_quer_6, label_time_quer_7 };
            Label[] label_room = { label_room_quer_1, label_room_quer_2, label_room_quer_3,
                label_room_quer_4, label_room_quer_5, label_room_quer_6, label_room_quer_7 };
            for (int i = 0; i < 16; i++)
            {
                if (top_16_client[i].time_quer_client.ToString("HH:mm:ss") !="00:00:01")
                {
                    if (DateTime.Parse(top_16_client[i].time_quer_client.ToString("HH:mm:ss")) <= DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")))
                    {
                        top_16_client[i].bool_is_active = true;
                        label_full_name[i].BackColor = Color.Red;
                        label_time[i].BackColor = Color.Red;
                        label_room[i].BackColor = Color.Red;
                        chech_active_client(i.ToString());
                    }
                }
                
                
            }
        }

        public void new_client(DateTime date)
        {

            Label[] label_full_name = { label_full_name_client_quer_1, label_full_name_client_quer_2, label_full_name_client_quer_3,
                label_full_name_client_quer_4, label_full_name_client_quer_5, label_full_name_client_quer_6, label_full_name_client_quer_7,
            label_full_name_client_quer_8, label_full_name_client_quer_9, label_full_name_client_quer_10, label_full_name_client_quer_11,
                label_full_name_client_quer_12, label_full_name_client_quer_13, label_full_name_client_quer_14, label_full_name_client_quer_15, label_full_name_client_quer_16};
            Label[] label_time = { label_time_quer_1, label_time_quer_2, label_time_quer_3,
                label_time_quer_4, label_time_quer_5, label_time_quer_6, label_time_quer_7 };
            Label[] label_room = { label_room_quer_1, label_room_quer_2, label_room_quer_3,
                label_room_quer_4, label_room_quer_5, label_room_quer_6, label_room_quer_7 };

            string sql_select = "SELECT services_client.id, concat(client.surname, ' ', client.name, ' ', substring(client.patromic,  1, 1), '.') as 'ful_name_client', services_client.time, users.room_number as 'room', users.id_manitor as 'manitor' " +
                "FROM services_client " +
                "inner join client on services_client.id_client=client.id " +
                "inner join users on services_client.id_users=users.id " +
                $"where str_to_date(time, '%Y-%m-%d')='{date.ToString("yyyy-MM-dd")}'  and services_client.enable= '1' and services_client.deleted is null and users.id_manitor='{id_manitor}' " +
                $"ORDER BY services_client.time; ";

            //textBox1.Text = sql_select;

            DataTable data_table_services = sqlConfiguration.sqlSelectQuery(sql_select);

            int count_datetabel = data_table_services.Rows.Count;

            for (int i = count_datetabel; i < 16; i++)
            {
                data_table_services.Rows.Add();
                data_table_services.Rows[i]["id"] = 0;
                //top_16_client[i].bool_is_active = false;
                data_table_services.Rows[i]["ful_name_client"] = "";
                data_table_services.Rows[i]["time"] = DateTime.Parse("0001-01-01 00:00:01") ;
                data_table_services.Rows[i]["room"] = 0 ;
            }

            for (int i = 0; i < 16; i++)
            {
                top_16_client.Add(new top_16());
                top_16_client[i].bool_is_active = false;
                if (data_table_services.Rows[i]["id"].ToString() != "" && data_table_services.Rows[i]["id"].ToString() != "0")
                {
                    top_16_client[i].id_client_services = data_table_services.Rows[i]["id"].ToString();
                    //MessageBox.Show(data_table_services.Rows[i]["id"].ToString());
                    if (data_table_services.Rows[i]["ful_name_client"].ToString() != "")
                    {
                        top_16_client[i].full_name_client = data_table_services.Rows[i]["ful_name_client"].ToString();
                        if (true)
                        {
                            label_full_name[i].Text = data_table_services.Rows[i]["ful_name_client"].ToString();
                        }
                    }
                        
                    else
                    {
                        top_16_client[i].full_name_client = "";
                    }

                    //MessageBox.Show(data_table_services.Rows[i]["time"].ToString());

                    if ((data_table_services.Rows[i]["time"].ToString() != "" &&  i < 7 ) || (data_table_services.Rows[i]["time"].ToString() != "0001-01-01 00:00:01" && i < 7) )
                    {
                        top_16_client[i].time_quer_client = DateTime.Parse(DateTime.Parse(data_table_services.Rows[i]["time"].ToString()).ToString("HH:mm:ss"));
                        label_time[i].Text = DateTime.Parse(data_table_services.Rows[i]["time"].ToString()).ToString("HH:mm:ss");
                    }
                    else
                    {
                        top_16_client[i].time_quer_client = DateTime.Parse(DateTime.Parse("0001-01-01 00:00:01").ToString("HH:mm:ss"));
                    }

                    if ((data_table_services.Rows[i]["room"].ToString() != "" && i < 7) || (data_table_services.Rows[i]["room"].ToString() != "0" && i < 7))
                    {
                        top_16_client[i].room_name = data_table_services.Rows[i]["room"].ToString();
                        label_room[i].Text =data_table_services.Rows[i]["room"].ToString();
                    }
                    else
                    {
                        top_16_client[i].room_name = "";
                    }
                }
                else
                {
                    top_16_client[i].id_client_services = "";
                    top_16_client[i].full_name_client = "";
                    label_full_name[i].Text = "";
                    top_16_client[i].time_quer_client = DateTime.Parse(DateTime.Parse("0001-01-01 00:00:01").ToString("HH:mm:ss"));
                    if (i<7)
                    {
                        label_time[i].Text = "";
                        label_room[i].Text = "";
                    }
                    top_16_client[i].bool_is_active = false;
                    top_16_client[i].room_name = "";
                   
                }
                
            }

            
        }
        
        
        void chech_active_client(string row_index)
        {
            int id_services = int.Parse(top_16_client[int.Parse(row_index)].id_client_services);

            DataTable dataTable_sevices_client = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services_client where id = '{id_services}'; ");

            int id_services_ = int.Parse(dataTable_sevices_client.Rows[0]["id_services"].ToString());

            DataTable dataTable_services = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services where id = '{id_services_}'; ");

            string time_services = dataTable_services.Rows[0]["time_services"].ToString();
            double time_services_hh = double.Parse(Convert.ToDateTime(time_services).ToString("HH"));
            double time_services_mm = double.Parse(Convert.ToDateTime(time_services).ToString("mm"));
            double time_services_ss = double.Parse(Convert.ToDateTime(time_services).ToString("ss"));

            DateTime time_check_ = top_16_client[int.Parse(row_index)].time_quer_client;

            time_check_ = time_check_.AddHours(time_services_hh);
            time_check_ = time_check_.AddMinutes(time_services_mm);
            time_check_ = time_check_.AddSeconds(time_services_ss);


            if (DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"))>=DateTime.Parse(time_check_.ToString("HH:mm:ss")))
            {
                Console.WriteLine(time_check_.ToString());

                _client_services_deleted(row_index);
            }
            else
            {
                new_client(DateTime.Now);
                Console.WriteLine(DateTime.Now.ToString());
            }
        }
        void _client_services_deleted(string id)
        {
            int id_services = int.Parse(top_16_client[int.Parse(id)].id_client_services);
            string sql = $"UPDATE services_client set enable='0', deleted= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE id ='{id_services}'; ";
            sqlConfiguration.sqlQuery(sql);
            new_client(DateTime.Now);
        }

        private void ManitorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && (e.Alt || e.Control || e.Shift))
            {
                if (this.WindowState== FormWindowState.Normal)
                {
                    this.FormBorderStyle= System.Windows.Forms.FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                } 
            }

            if (e.KeyCode == Keys.R && (e.Alt || e.Control || e.Shift))
            {
                if (id_manitor == "1")
                {
                    id_manitor = "2";
                    new_client(DateTime.Now);
                }
                else
                {
                    id_manitor = "1";
                    new_client(DateTime.Now);
                }
            }
        }
        int animated = 0;

       
    }


    class top_16
    {
        public string id_client_services;
        public string full_name_client;
        public DateTime time_quer_client;
        public string room_name;
        public bool bool_is_active=false;
    }
}

