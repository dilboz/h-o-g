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

        public AddServicesForClient(MainFormVrach mainFormVrach, string id_client, string id_services_for_client, string txt_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            load_combo();
            this.mainFormVrach = mainFormVrach;
            this.id_client = id_client;
            this.id_services_for_client = id_services_for_client;
            this.txt_button = txt_button;

            string select_sql = $"select  client.id, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name' from client where id = '{this.id_client}'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(select_sql);
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

                }
               
               

                if (combo_spitsqlist.Items.Count == 0)
                {
                    panel_show_hide.Visible = false;
                    time_services_for_client.Text = "";
                    MessageBox.Show("Шумо бо чунин хизматрасонис спитсалист надоред!!");
                }
                else
                {
                    panel_show_hide.Visible = true;
                    time_services = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("yyyy-MM-dd hh:mm:ss");
 
                     time_services_for_client.Text = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("Рузи dd-MM-yyy соати hh:mm:ss");


                }
            }
            else
            {
                MessageBox.Show("Шумо хизматрасони надоред!!");
                this.Close();
            }
        }


        private string add_time(string id_users, string services_id)
        {
            string sql_select_users = $"select * from users where id = {id_users}";
            DataTable dataTable_users = sqlConfiguration.sqlSelectQuery(sql_select_users);

            string sql_select_serices = $"select * from services where id = {services_id}";
            DataTable dataTable_services = sqlConfiguration.sqlSelectQuery(sql_select_serices);

            string time_end = dataTable_users.Rows[0]["end_date_time_services"].ToString();

            double time_services_hh = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("hh"));
            double time_services_mm = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("mm"));
            double time_services_ss = double.Parse(Convert.ToDateTime(dataTable_services.Rows[0]["time_services"].ToString()).ToString("ss"));

            string new_date;

            if (Convert.ToDateTime(time_end) > DateTime.Now.Date)
            {
                new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();

                if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
                {
                    new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh + 1).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
                else if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
                {
                    new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
                else if (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) > (DateTime.Parse(DateTime.Parse(dataTable_users.Rows[0]["work_time_end"].ToString()).ToString("hh:MM:ss"))))
                {
                    time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
                    new_date = (Convert.ToDateTime(time_end).AddDays(1).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
            }
            else
            {
                time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
                new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) >= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
                {
                    new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh + 1).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
                else if ((DateTime.Parse(DateTime.Parse("12:00:00").ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss"))) && (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) <= DateTime.Parse(DateTime.Parse("13:00:00").ToString("hh:MM:ss"))))
                {
                    new_date = (Convert.ToDateTime(time_end).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
                else if (DateTime.Parse(DateTime.Parse(new_date).ToString("hh:MM:ss")) > (DateTime.Parse(DateTime.Parse(dataTable_users.Rows[0]["work_time_end"].ToString()).ToString("hh:MM:ss"))))
                {
                    time_end = DateTime.Now.ToString("yyyy-MM-dd ") + Convert.ToDateTime(dataTable_users.Rows[0]["work_time_start"].ToString()).ToString("hh:mm:ss");
                    new_date = (Convert.ToDateTime(time_end).AddDays(1).AddHours(time_services_hh).AddMinutes(time_services_mm).AddSeconds(time_services_ss)).ToString();
                }
            }

            return new_date;
        }

        private void combo_spitsqlist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            time_services = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("yyyy-MM-dd hh:mm:ss");
            time_services_for_client.Text = DateTime.Parse(add_time(combo_spitsqlist.SelectedValue.ToString(), combo_services.SelectedValue.ToString())).ToString("Рузи dd-MM-yyy соати hh:mm:ss");
        }


        void add()
        {
            string id_client = this.id_client;
            string id_services = combo_services.SelectedValue.ToString();
            string id_users = combo_spitsqlist.SelectedValue.ToString();
            string _time = time_services;

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

        private void btn_creat_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
