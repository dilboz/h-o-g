using ObiGarm.ClassDatabase;
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
        private string id_services_for_client;
        private string txt_button;
        private string time_services;

        string selected_list_date = "";
        string selected_list_time = "";

        private string id_spitsalist;

        DateTime date_;

        DateTime time_start_client;
        DateTime time_end_client;        

        DateTime time_start_spit;
        DateTime time_end_spit;


        public AddServicesForClient(MainFormVrach mainFormVrach, string id_client, string id_services_for_client, string txt_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            load_combo();
            this.mainFormVrach = mainFormVrach;
            this.id_client = id_client;
            this.id_services_for_client = id_services_for_client;
            this.txt_button = txt_button;

            string select_sql = $"select  client.id, date_time_start, date_time_end, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name' from client where id = '{this.id_client}'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(select_sql);

            

            time_start_client = Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());
            time_end_client = Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());

            txt_full_name.Text = dataTable.Rows[0]["full_name"].ToString();
        }

        void load_combo()
        {
            string select_sql_services = "select * from services where enable = 1";
            sqlConfiguration.LoadCombo(select_sql_services, "name","id", combo_services);
            combo_services.SelectedIndex = -1;
            panel_show_hide.Visible = false;
            time_services_for_client.Text = "";

            

            string select_sql_spitsqlist;
            if (combo_services.Items.Count!=0)
            {
                if ( combo_services.SelectedIndex != -1)
                {
                    if (combo_services.SelectedValue.ToString() != "")
                    {
                        select_sql_spitsqlist = "select services_users.user_id as 'id', concat(users.surname, ' ', users.name) as 'name' " +
                     "from services_users " +
                     "inner join users on services_users.user_id=users.id " +
                     $"where services_users.id = '{combo_services.SelectedValue.ToString()}' ";
                    }
                    else
                    {
                        select_sql_spitsqlist = "select services_users.user_id as 'id', concat(users.surname, ' ', users.name) as 'name' " +
                   "from services_users " +
                   "inner join users on services_users.user_id=users.id ";
                    }
                   

                }
                else
                {
                    select_sql_spitsqlist = "select services_users.user_id as 'id', concat(users.surname, ' ', users.name) as 'name' " +
                    "from services_users " +
                    "inner join users on services_users.user_id=users.id ";
                }
                sqlConfiguration.LoadCombo(select_sql_spitsqlist, "name", "id", combo_spitsqlist);

                id_spitsalist = combo_spitsqlist.SelectedValue.ToString();

                //if (combo_spitsqlist.Items.Count == 0)
                //{
                //   // MessageBox.Show("Шумо бо чунин хизматрасонис спитсалист надоред!!");
                //    panel_show_hide.Visible = false;
                //    time_services_for_client.Text = "";
                //}
                //else
                //{
                //    panel_show_hide.Visible = true;
                //    time_services_for_client.Text = "sas";
                //}
            }
            else
            {
                MessageBox.Show("Шумо хизматрасони надоред!!");
                this.Close();
            }

        }

        private void combo_services_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_services.Items.Count != 0)
            {
                if (combo_services.SelectedValue.ToString() != "")
                {
                    string select_sql_spitsqlist = "select services_users.user_id as 'id', users.deleted as 'deleted_users', concat(users.surname, ' ', users.name)as 'name',  users.end_date_time_services as 'time_services_end' " +
                      "from services_users " +
                      "inner join users on services_users.user_id=users.id " +
                      $"where services_users.service_id = '{combo_services.SelectedValue.ToString()}' and users.deleted  is null " +
                      $"order by users.end_date_time_services";
                    sqlConfiguration.LoadCombo(select_sql_spitsqlist, "name", "id", combo_spitsqlist);

                    id_services_for_client = combo_services.SelectedValue.ToString();

                    
                }
               
               

                if (combo_spitsqlist.Items.Count == 0)
                {
                    panel_show_hide.Visible = false;
                    time_services_for_client.Text = "";
                    MessageBox.Show("Шумо бо чунин хизматрасонис спитсалист надоред!!");
                }
                else
                {
                    id_spitsalist = combo_spitsqlist.SelectedValue.ToString();

                    DataTable dataTable_spit = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.users where id ='{id_spitsalist}';");
                   
                    time_start_spit= Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_start"].ToString());
                    time_end_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_end"].ToString());

                    panel_show_hide.Visible = true;
                  


                }

                lisе_data(time_start_client, time_end_client, "");
            }
            else
            {
                MessageBox.Show("Шумо хизматрасони надоред!!");
                this.Close();
            }
        }


        //private string add_time(string id_users, string services_id)
        //{
        //    string sql_select_users = $"select * from users where id = {id_users}";
        //    DataTable dataTable_users = sqlConfiguration.sqlSelectQuery(sql_select_users);

        //    string sql_select_serices = $"select * from services where id = {services_id}";
        //    DataTable dataTable_services = sqlConfiguration.sqlSelectQuery(sql_select_serices);

        //    string time_end = dataTable_users.Rows[0]["end_date_time_services"].ToString();

        //    double time_services_hh = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("hh"));
        //    double time_services_mm = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("mm"));
        //    double time_services_ss = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("ss"));

        //    string new_date;

        //    if (Convert.ToDateTime(time_end) > DateTime.Now.Date)
        //    {
        //        new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();

        //        if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
        //        {
        //            new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh + 1).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //        else if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
        //        {
        //            new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //        else if (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) > (DateTime.Parse(DateTime.Parse(dataTable_users.Rows[0]["work_time_end"].ToString()).ToString("hh:MM:ss"))))
        //        {
        //            time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
        //            new_date = (Convert.ToDateTime(time_end).AddDays(1).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //    }
        //    else
        //    {
        //        time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
        //        new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
        //        {
        //            new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh + 1).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //        else if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
        //        {
        //            new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //        else if (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) > (DateTime.Parse(DateTime.Parse(dataTable_users.Rows[0]["work_time_end"].ToString()).ToString("hh:MM:ss"))))
        //        {
        //            time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
        //            new_date = (Convert.ToDateTime(time_end).AddDays(1).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
        //        }
        //    }

        //    return new_date;
        //}

        private void combo_spitsqlist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id_spitsalist = combo_spitsqlist.SelectedValue.ToString();
            DataTable dataTable_spit = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.users where id ='{id_spitsalist}';");
            time_start_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_start"].ToString());
            time_end_spit = Convert.ToDateTime(dataTable_spit.Rows[0]["work_time_end"].ToString());
            //time_services = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("yyyy-MM-dd hh:mm:ss");
            //time_services_for_client.Text = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("Рузи dd-MM-yyy соати hh:mm:ss");
            lisе_data(time_start_client, time_end_client, "");

        }


        void add()
        {
            string id_client = this.id_client;
            string id_services = combo_services.SelectedValue.ToString();
            string id_users = combo_spitsqlist.SelectedValue.ToString();
            string _time = time_services_for_client.Text;

            string sql_select = "insert into services_client (id_client, id_services, id_users, time) values('" +
              id_client + "', '" +
              id_services + "', '" +
              id_users + "', '" +
              _time + "');";
            if (id_client!="" && id_services!="" && id_users!="" && _time!="")
            {
                int result = sqlConfiguration.sqlQuery(sql_select);
                if (result == 500)
                {
                    txt_full_name.Text = sql_select;
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql_update_users = $"update users set end_date_time_services= '{_time}'  where id='{id_users}'";
                    int _res = sqlConfiguration.sqlQuery(sql_update_users);
                    if (_res == 500)
                    {
                        txt_full_name.Text = sql_select;
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mainFormVrach.check_btn_add_services();
                        this.Close();
                    }
                   
                    

                    //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Пур кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }



        void lisе_data(DateTime start_date, DateTime end_date, string select_list)
        {
            list_date.Items.Clear();
            while (start_date<= end_date)
            {
                list_date.Items.Add(start_date.ToString("D")/*.ToString("dd-MM-yyyy")*/);
                start_date = start_date.AddDays(1);
            }

            DataTable time_services_ = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.services where id = '{id_services_for_client}';");

            DateTime time_serivc = DateTime.Parse(time_services_.Rows[0]["time_services"].ToString());

            
            
            if (select_list != "")
            {
                 date_ = DateTime.Parse(select_list);
            }
            else
            {
                
               
                date_ = DateTime.Parse(list_date.Items[0].ToString());
            }
           

            _list_time(date_, time_start_spit, time_end_spit, time_serivc);
        }


        void _list_time(DateTime date, DateTime start_time, DateTime end_time, DateTime time_services)
        {
            list_time.Items.Clear();
            if (date.ToString("d") == time_start_client.ToString("d"))
            {
                if (DateTime.Parse(start_time.ToString("HH:mm:ss"))<=DateTime.Parse(time_start_client.ToString("HH:mm:ss")))
                {
                    start_time= Convert.ToDateTime(time_start_client.ToString("HH:mm:ss"));
                }
                else
                {
                    start_time = Convert.ToDateTime(time_start_spit.ToString("HH:mm:ss"));                    
                }
                end_time = Convert.ToDateTime(time_end_spit.ToString("HH:mm:ss"));
            }
            else 
            {
                start_time = Convert.ToDateTime(time_start_spit.ToString("HH:mm:ss"));
                end_time = Convert.ToDateTime(time_end_spit.ToString("HH:mm:ss"));
            }


            double time_services_hh = double.Parse(Convert.ToDateTime(time_services).ToString("HH"));
            double time_services_mm = double.Parse(Convert.ToDateTime(time_services).ToString("mm")) + 10;
            double time_services_ss = double.Parse(Convert.ToDateTime(time_services).ToString("ss"));

            while (DateTime.Parse(start_time.ToString("HH:mm:ss")) <= DateTime.Parse(end_time.ToString("HH:mm:ss")))
            {
                DateTime time_plus_srt_time = start_time;
                time_plus_srt_time = time_plus_srt_time.AddHours(time_services_hh);
                time_plus_srt_time = time_plus_srt_time.AddMinutes(time_services_mm);
                time_plus_srt_time = time_plus_srt_time.AddSeconds(time_services_ss);

                DataTable check_tabel_sevices_client = sqlConfiguration.sqlSelectQuery($"select * from services_client where id_services = '{id_services_for_client}' and id_users = '{id_spitsalist}' and time >= '{date.Year}-{date.Month}-{date.Day} {start_time.Hour}:{start_time.Minute}:{start_time.Second}' " +
                    $" and time <= '{date.Year}-{date.Month}-{date.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}:{time_plus_srt_time.Second}'");

                Console.WriteLine($"select * from services_client where id_services = '{id_services_for_client}' and time >= '{date.Year}-{date.Month}-{date.Day} {start_time.Hour}:{start_time.Minute}:{start_time.Second}'+" +
                    $" and time <= '{date.Year}-{date.Month}-{date.Day} {(time_plus_srt_time.Hour)}:{time_plus_srt_time.Minute}:{time_plus_srt_time.Second}'");

                if (check_tabel_sevices_client.Rows.Count==0)
                {
                    list_time.Items.Add(start_time.ToString("HH:mm:ss"));

                }
                start_time = start_time.AddHours(time_services_hh);
                start_time = start_time.AddMinutes(time_services_mm);
                start_time = start_time.AddSeconds(time_services_ss);

              
            }
            if (selected_list_time != "")
            {
                time_services_for_client.Text = date.ToString("yyyy-MM-dd ") + DateTime.Parse(selected_list_time).ToString("HH:mm:ss");
            }
            else
            {
                if (list_time.Items.Count != 0)
                {
                    time_services_for_client.Text = date.ToString("yyyy-MM-dd ") + DateTime.Parse(list_time.Items[0].ToString()).ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("Дар чунин руз вақти холи надоред!");
                }

            }
        }



        private void btn_creat_Click(object sender, EventArgs e)
        {
            add();
        }

        private void list_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_list_date = list_date.SelectedItem.ToString();

            lisе_data(time_start_client, time_end_client, selected_list_date);
        }

        private void list_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_list_time = list_time.SelectedItem.ToString();
            lisе_data(time_start_client, time_end_client, selected_list_date);
        }

        private void AddServicesForClient_Load(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

