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

        private string prv_id_services;
        private string prv_id_spitsalist;

        private DateTime prv_time_start_work_spit;
        private DateTime prv_time_end_work_spit;
        private DateTime ptv_select_date_for_services;
        private DateTime ptv_select_time_for_services;
        private string prv_full_time_for_client;

        private DateTime prv_client_start_work_spit;
        private DateTime prv_client_end_work_spit;

        public AddServicesForClient(MainFormVrach mainFormVrach, string id_client, string id_main_spitsalist)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.mainFormVrach = mainFormVrach;
            this.id_client = id_client;
            this.id_main_vrach = id_main_spitsalist;

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
            string select_sql_spitsqlist = "select services_users.user_id as 'id', concat(users.surname, ' ', users.name) as 'name' " +
                      "from services_users " +
                      "inner join users on services_users.user_id=users.id " +
                      $"where services_users.service_id = '{id_services}' and users.deleted  is null " +
                      "order by users.end_date_time_services; ";
            sqlConfiguration.displayList(select_sql_spitsqlist, datagridview_vrach);
        }

        void free_date_spitsalist(string id_spitsalist)
        {
            DataTable dataTable_spit = sqlConfiguration.sqlSelectQuery($"SELECT * FROM client where id ='{id_spitsalist}';");
            prv_client_start_work_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["date_time_start"].ToString());
            prv_client_end_work_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["date_time_end"].ToString());

            list_data(DateTime.Now, prv_client_end_work_spit);
        }

        void list_data(DateTime start_date, DateTime end_date)
        {
            datagridview_date.Rows.Clear();
            while (start_date <= end_date)
            {
                datagridview_date.Rows.Add(start_date.ToString("D")); /*.ToString("dd-MM-yyyy")*/
                start_date = start_date.AddDays(1);
            }
        }

        void free_time_spitsalist(DateTime seleted_date)
        {
            DataTable time_services_ = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services where id = '{prv_id_services}' ;");
            DateTime time_seleted_serivces = DateTime.Parse(time_services_.Rows[0]["time_services"].ToString());

            list_time(seleted_date, prv_time_start_work_spit, prv_time_end_work_spit, time_seleted_serivces);
        }

        void list_time(DateTime date_selected, DateTime start_time_spitsalist_work, DateTime end_time_spitsalist_work, DateTime time_services_selected)
        {
            datagridview_time.Rows.Clear();

            if (date_selected.ToString("d") == prv_time_start_work_spit.ToString("d"))
            {
                if (DateTime.Parse(start_time_spitsalist_work.ToString("HH:mm")) <= DateTime.Parse(prv_time_start_work_spit.ToString("HH:mm")))
                {
                    start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm"));
                }
                else
                {
                    start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm"));
                }
                end_time_spitsalist_work = Convert.ToDateTime(prv_time_end_work_spit.ToString("HH:mm"));
            }
            else
            {
                start_time_spitsalist_work = Convert.ToDateTime(prv_time_start_work_spit.ToString("HH:mm"));
                end_time_spitsalist_work = Convert.ToDateTime(prv_time_end_work_spit.ToString("HH:mm"));
            }


            double time_services_hh = double.Parse(Convert.ToDateTime(time_services_selected).ToString("HH"));
            double time_services_mm = double.Parse(Convert.ToDateTime(time_services_selected).ToString("mm"));

            datagridview_time.Rows.Clear();

            Console.WriteLine(date_selected.ToString("yyyy-MM-dd") + "\n" + DateTime.Now.ToString("yyyy-MM-dd"));
            
            if (DateTime.Parse(start_time_spitsalist_work.ToString("HH:mm")) <= DateTime.Parse(DateTime.Now.ToString("HH:mm")) && DateTime.Parse(date_selected.ToString("yyyy-MM-dd")) == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")))
                start_time_spitsalist_work = DateTime.Parse(DateTime.Now.ToString("HH:mm"));

            while (DateTime.Parse(start_time_spitsalist_work.ToString("HH:mm")) <= DateTime.Parse(end_time_spitsalist_work.ToString("HH:mm")))
            {
                DateTime time_plus_srt_time = start_time_spitsalist_work;
                time_plus_srt_time = time_plus_srt_time.AddHours(time_services_hh);
                time_plus_srt_time = time_plus_srt_time.AddMinutes(time_services_mm);

                DataTable check_tabel_sevices_client = sqlConfiguration.sqlSelectQuery($"select * from services_client where id_services = '{prv_id_services}' and id_users = '{prv_id_spitsalist}' and time >= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {start_time_spitsalist_work.Hour}:{start_time_spitsalist_work.Minute}' " +
                    $" and time <= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}' and deleted is null; ");

                /*Console.WriteLine($"select * from services_client where id_services = '{prv_id_services}' and id_users = '{prv_id_spitsalist}' and time >= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {start_time_spitsalist_work.Hour}:{start_time_spitsalist_work.Minute}:{start_time_spitsalist_work.Second}' " +
                    $" and time <= '{date_selected.Year}-{date_selected.Month}-{date_selected.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}' and deleted is null; ");*/

                if (check_tabel_sevices_client.Rows.Count == 0 && start_time_spitsalist_work.ToString("HH")!="13")
                {
                    datagridview_time.Rows.Add(start_time_spitsalist_work.ToString("HH:mm"));
                }

                start_time_spitsalist_work = start_time_spitsalist_work.AddHours(time_services_hh);
                start_time_spitsalist_work = start_time_spitsalist_work.AddMinutes(time_services_mm);

            }
        }

        void adding_services(DateTime time_selected)
        {
            string date = ptv_select_date_for_services.ToString("yyyy-MM-dd");
            string time = time_selected.ToString("HH:mm");

            prv_full_time_for_client = string.Concat(date, " ", time);
            add(prv_full_time_for_client);

            dispaly_services_to_selected_client(this.id_client);
            mainFormVrach.display_services_client(this.id_client);
        }

        void add(string date_time_services_forclient)
        {
            string id_client = this.id_client;
            string id_services = prv_id_services;
            string id_spitsalist = prv_id_spitsalist;
            string time_services_for_client = date_time_services_forclient;


            string chek_sql_query = $"select * from services_client where id_client ='{id_client}' and time >= '{time_services_for_client}' and time <= '{DateTime.Parse(time_services_for_client).AddMinutes(50).ToString("yyyy-MM-dd HH:mm")}' and deleted is null ";
            string chek_sql_query_after = $"select * from services_client where id_client ='{id_client}' and time >= '{DateTime.Parse(time_services_for_client).AddMinutes(-50).ToString("yyyy-MM-dd HH:mm")}' and time <= '{time_services_for_client}' and deleted is null ";

            Console.WriteLine(chek_sql_query);    
            Console.WriteLine(chek_sql_query_after);    

            if (sqlConfiguration.sqlSelectQuery(chek_sql_query).Rows.Count!=0)
            {
                msg("Шумо бояд 1 соат бад ё 1 соат пеш интихоб кунед!!");
                return;
            }
            else if (sqlConfiguration.sqlSelectQuery(chek_sql_query_after).Rows.Count != 0)
            {
                msg("Дар чунин вакт хизматрасони дода шудасст!!");
                return;
            }

            
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
                        free_time_spitsalist(ptv_select_date_for_services);
                        //mainFormVrach.check_btn_add_services();
                        //this.Close();
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
            string display = "SELECT services_client.id, concat(users.surname, ' ', users.name) as 'name_spitsalist', services.name as 'name_services', services_client.time as 'time_services' " +
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

        private void datagridview_vrach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prv_id_spitsalist = datagridview_vrach.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (prv_id_services != "")
            {
                if (prv_id_spitsalist != "")
                {
                    free_date_spitsalist(id_client);
                }
                else msg("Мутахассис интихоб нашудааст!");
            }
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }

        private void datagridview_services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prv_id_services = datagridview_services.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (prv_id_services != "") disolay_vrach_from_id_services(prv_id_services);
            else msg("Хизматрасонӣ интихоб нашудааст!");
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridview_allServicesClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == delete.Index)
            {
                string id = datagridview_allServicesClient.Rows[e.RowIndex].Cells[3].Value.ToString();

                string sqlQueryCheckClient = "select client.id_varch from services_client " +
                    "inner join client on services_client.id_client = client.id " +
                    $"where services_client.id = '{id}' ";

                if (sqlConfiguration.sqlSelectQuery(sqlQueryCheckClient).Rows.Count != 0)
                {
                    if (sqlConfiguration.sqlSelectQuery(sqlQueryCheckClient).Rows[0]["id_varch"].ToString() == id_main_vrach)
                    {

                        DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_allServicesClient.Rows[e.RowIndex].Cells[4].Value + " - " + datagridview_allServicesClient.Rows[e.RowIndex].Cells[5].Value + " - " + datagridview_allServicesClient.Rows[e.RowIndex].Cells[6].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {

                            string sqlDeleteAdmin = $"update services_client set deleted = '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                            int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                            if (res2 == 1)
                            {
                                dispaly_services_to_selected_client(this.id_client);
                                mainFormVrach.display_services_client(this.id_client);
                            }
                            else
                            {
                                MessageBox.Show("Хатоги хангоми нест кардани хизматрасонӣ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        msg("Танҳо табиби истироҳаткунанда хизматрасониро нест карда метавонад!");
                    }
                }

                    
                
                
                
            }
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
    }
}

