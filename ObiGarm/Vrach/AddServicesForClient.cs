using ObiGarm.ClassDatabase;
using ObiGarm.Mnitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ObiGarm.Vrach
{
    public partial class AddServicesForClient : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly MainFormVrach mainFormVrach;
        private string id_client;
        private string id_main_vrach;
        private string txt_button;

        private string prv_id_services;
        private string prv_id_spitsalist;

        private DateTime prv_time_start_work_spit;
        private DateTime prv_time_end_work_spit;
        private DateTime ptv_select_date_for_services;
        private DateTime ptv_select_time_for_services;
        private string prv_full_time_for_client;


        public AddServicesForClient(MainFormVrach mainFormVrach, string id_client, string id_main_spitsalist, string txt_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.mainFormVrach = mainFormVrach;
            this.id_client = id_client;
            this.id_main_vrach = id_main_spitsalist;
            this.txt_button = txt_button;

            load_time_start_and_end_ClientWork(this.id_client);
            dispaly_services_to_selected_client(this.id_client);
            load_services();
        }

        void load_time_start_and_end_ClientWork(string id_client)
        {
            string select_sql = $"select  client.id, date_time_start, date_time_end, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name' from client where id = '{id_client}'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(select_sql);

            prv_time_start_work_spit = Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());
            prv_time_end_work_spit = Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());

        }

        void load_services()
        {
            string select_sql_services = "select id, name from services where enable = 1";
            sqlConfiguration.displayList(select_sql_services, datagridview_services);
        }

        void disolay_vrach_from_id_services(string id_services)
        {
            string select_sql_spitsqlist = "select services_users.user_id as 'id', concat(users.surname, ' ', users.name)as 'name' " +
                      "from services_users " +
                      "inner join users on services_users.user_id=users.id " +
                      $"where services_users.service_id = '{id_services}' and users.deleted  is null " +
                      "order by users.end_date_time_services; ";
            sqlConfiguration.displayList(select_sql_spitsqlist, datagridview_vrach);
        }

        void free_date_spitsalist(string id_spitsalist)
        {
            DataTable dataTable_spit = sqlConfiguration.sqlSelectQuery($"SELECT * FROM users where id ='{id_spitsalist}';");
            prv_time_start_work_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_start"].ToString());
            prv_time_end_work_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_end"].ToString());

            list_data(prv_time_start_work_spit, prv_time_end_work_spit);
        }

        void list_data(DateTime start_date, DateTime end_date)
        {
            datagridview_date.Rows.Clear();
            while (start_date <= end_date)
            {
                datagridview_date.Rows.Add(start_date.ToString("D"));/*.ToString("dd-MM-yyyy")*/
                start_date = start_date.AddDays(1);
            }
        }

        void free_time_spitsalist(DateTime seleted_date)
        {
            DataTable time_services_ = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services where id = '{prv_id_services}';");
            DateTime time_seleted_serivces = DateTime.Parse(time_services_.Rows[0]["time_services"].ToString());

            list_time(seleted_date, prv_time_start_work_spit, prv_time_end_work_spit, time_seleted_serivces);
        }

        void list_time(DateTime date_selected, DateTime start_time_spitsalist_work, DateTime end_time_spitsalist_work, DateTime time_services_selected)
        {
            datagridview_time.Rows.Clear();
            if (date_selected.ToString("d") == prv_time_start_work_spit.ToString("d"))
            {
                if (DateTime.Parse(start_time_spitsalist_work.ToString("HH:mm:ss")) <= DateTime.Parse(prv_time_start_work_spit.ToString("HH:mm:ss")))
                {
                    start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm:ss"));
                }
                else
                {
                    start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm:ss"));
                }
                end_time_spitsalist_work = Convert.ToDateTime(prv_time_end_work_spit.ToString("HH:mm:ss"));
            }
            else
            {
                start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm:ss"));
                end_time_spitsalist_work = Convert.ToDateTime(prv_time_end_work_spit.ToString("HH:mm:ss"));
            }


            double time_services_hh = double.Parse(Convert.ToDateTime(time_services_selected).ToString("HH"));
            double time_services_mm = double.Parse(Convert.ToDateTime(time_services_selected).ToString("mm")) + 10;
            double time_services_ss = double.Parse(Convert.ToDateTime(time_services_selected).ToString("ss"));

            datagridview_time.Rows.Clear();

            while (DateTime.Parse(start_time_spitsalist_work.ToString("HH:mm:ss")) <= DateTime.Parse(end_time_spitsalist_work.ToString("HH:mm:ss")))
            {
                DateTime time_plus_srt_time = start_time_spitsalist_work;
                time_plus_srt_time = time_plus_srt_time.AddHours(time_services_hh);
                time_plus_srt_time = time_plus_srt_time.AddMinutes(time_services_mm);
                time_plus_srt_time = time_plus_srt_time.AddSeconds(time_services_ss);

                DataTable check_tabel_sevices_client = sqlConfiguration.sqlSelectQuery($"select * from services_client where id_services = '{prv_id_services}' and id_users = '{prv_id_spitsalist}' and time >= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {start_time_spitsalist_work.Hour}:{start_time_spitsalist_work.Minute}:{start_time_spitsalist_work.Second}' " +
                    $" and time <= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}:{time_plus_srt_time.Second}'");

                Console.WriteLine($"select * from services_client where id_services = '{prv_id_services}' and time >= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {start_time_spitsalist_work.Hour}:{start_time_spitsalist_work.Minute}:{start_time_spitsalist_work.Second}'+" +
                    $" and time <= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}:{time_plus_srt_time.Second}'");


                if (check_tabel_sevices_client.Rows.Count == 0)
                {
                    datagridview_time.Rows.Add(start_time_spitsalist_work.ToString("HH:mm:ss"));
                }
                start_time_spitsalist_work = start_time_spitsalist_work.AddHours(time_services_hh);
                start_time_spitsalist_work = start_time_spitsalist_work.AddMinutes(time_services_mm);
                start_time_spitsalist_work = start_time_spitsalist_work.AddSeconds(time_services_ss);


            }
        }

        void adding_services(DateTime time_selected)
        {
            string date = ptv_select_date_for_services.ToString("yyyy-MM-dd");
            string time = time_selected.ToString("hh:mm:ss");

            prv_full_time_for_client = string.Concat(date, " ", time);
            add(prv_full_time_for_client);

            dispaly_services_to_selected_client(this.id_client);
        }

        void add(string date_time_services_forclient)
        {
            string id_client = this.id_client;
            string id_services = prv_id_services;
            string id_spitsalist = prv_id_spitsalist;
            string time_services_for_client = date_time_services_forclient;


            string chek_sql_query = $"select * from services_client where id_client ='{id_client}' and id_services='{id_services}' and id_users= '{prv_id_spitsalist}' and time = '{time_services_for_client}'";

            string sql_select = "insert into services_client (id_client, id_services, id_users, time) values('" +
              id_client + "', '" +
              id_services + "', '" +
              id_spitsalist + "', '" +
              time_services_for_client + "');";
            if (id_client != "" && id_services != "" && id_spitsalist != "" && time_services_for_client != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_select);
                if (result == 500)
                {
                    msg(sql_select);
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql_update_users = $"update users set end_date_time_services= '{time_services_for_client}'  where id='{id_spitsalist}'";
                    int _res = sqlConfiguration.sqlQuery(sql_update_users);
                    if (_res == 500)
                    {
                        msg(sql_select);
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mainFormVrach.check_btn_add_services();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Интихоб кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        void dispaly_services_to_selected_client(string id_client)
        {
            string display = "SELECT services_client.id, services.name as 'name_services', concat(users.surname, ' ', users.name) as 'name_spitsalist',  services_client.time as 'time_services' " +
                "FROM services_client " +
                "inner join services on services_client.id_services = services.id " +
                "inner join users on services_client.id_users = users.id " +
                $"where services_client.id_client ='{id_client}' and services_client.deleted is null;";

            sqlConfiguration.displayList(display, datagridview_allServicesClient);
        }

        void msg(string messeg)
        {
            messDilalog.Text = messeg;
            messDilalog.Show();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridview_date_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ptv_select_date_for_services = DateTime.Parse(datagridview_date.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (prv_id_services != "")
            {
                if (prv_id_spitsalist != "")
                {
                    if (ptv_select_date_for_services != null)
                    {
                        free_time_spitsalist(ptv_select_date_for_services);
                    }
                }
                else msg("Мутахассис интихоб нашудааст!");
            }
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }

        private void datagridview_time_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ptv_select_time_for_services = DateTime.Parse(datagridview_time.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (prv_id_services != "")
            {
                if (prv_id_spitsalist != "")
                {
                    if (ptv_select_time_for_services != null)
                    {
                        adding_services(ptv_select_time_for_services);
                    }
                }
                else msg("Мутахассис интихоб нашудааст!");
            }
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }

        private void datagridview_vrach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prv_id_spitsalist = datagridview_vrach.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (prv_id_services != "")
            {
                if (prv_id_spitsalist != "")
                {
                    free_date_spitsalist(prv_id_spitsalist);
                }
                else msg("Мутахассис интихоб нашудааст!");
            }
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }

        private void datagridview_services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prv_id_services = datagridview_services.Rows[e.RowIndex].Cells[0].Value.ToString();
            msg(prv_id_services);
            if (prv_id_services != "") disolay_vrach_from_id_services(prv_id_services);
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }
    }
}

