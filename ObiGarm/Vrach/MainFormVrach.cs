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
    public partial class MainFormVrach : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private bool is_check_kort=false;

        private string id_client;

        public MainFormVrach()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            user_info_label.Text =  SettingsDatabase.name_user + " " + SettingsDatabase.surname_user;
            display_client();
            check_btn_add_services();
            txt_numeb_kort.Focus();
        }

        void display_client()
        {
            string sql = "select id, concat(surname , ' ' , name , ' ' , patromic) as full_name from client where enable=1 and is_for_vrach= 1 and deleted is null order by id desc ";
            sqlConfiguration.LoadCombo(sql, "full_name", "id", combo_client);
            combo_client.SelectedIndex = -1;
        }

        void display(string id_client)
        {
            string sql = "select services.name as 'name_services', concat(users.surname, ' ', users.name) as 'ful_name_user', services_client.time as 'time' " +
                "from services_client " +
                "inner join services on services_client.id_services = services.id  " +
                "inner join users on services_client.id_users = users.id " +
                $"where services_client.id_client = '{id_client}' ";

            

            sqlConfiguration.displayListExpress(sql, grid_contol);
        }

       

        public void check_btn_add_services()
        {
            if (is_check_kort == true && id_client!="")
            {
                btn_add_services.Visible = true;
                display(id_client);
            }
            else
            {
                btn_add_services.Visible = false;

            }
        }


        void select_info(string id)
        {
            string sql_for_info_client = "select client.id, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', client.birthday, sex.name as 'sex', client.date_time_start, client.date_time_end "
                                        + "from client "
                                        + "inner join sex on client.id_sex = sex.id "
                                        + $"where client.enable = 1 and client.deleted is null and client.id='{id}'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql_for_info_client);

            

            combo_client.Text = dataTable.Rows[0]["full_name"].ToString();
            txt_full_name.Text= dataTable.Rows[0]["full_name"].ToString();
            txt_birthday.Text= dataTable.Rows[0]["birthday"].ToString();
            txt_sex.Text= dataTable.Rows[0]["sex"].ToString();
            txt_time_start.Text= dataTable.Rows[0]["date_time_start"].ToString();
            txt_end_time.Text= dataTable.Rows[0]["date_time_end"].ToString();
            if (txt_full_name.Text!="")
            {
                is_check_kort=true;
                btn_add_services.Visible = true;

            }
            else
            {
                is_check_kort = false;
                btn_add_services.Visible = false;
            }

        }


        private void combo_client_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ( combo_client.SelectedValue.ToString()!="")
            {
                check_btn_add_services();
                select_info(combo_client.SelectedValue.ToString());

                id_client = combo_client.SelectedValue.ToString();
            }
        }


        private void MainFormVrach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_services_Click(object sender, EventArgs e)
        {
            AddServicesForClient addServicesForClient = new AddServicesForClient(this, id_client, "", "");
            addServicesForClient.ShowDialog();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button_active_kort_Click(object sender, EventArgs e)
        {
            txt_full_name.Focus();
            txt_numeb_kort.Focus();
        }

        private void txt_numeb_kort_TextChanged(object sender, EventArgs e)
        {
            if (txt_numeb_kort.Text.Length == 20)
            {
                txt_numeb_kort.Text = txt_numeb_kort.Text.Substring(10, 10);
                check_klient(txt_numeb_kort.Text);
                txt_full_name.Focus();
                txt_numeb_kort.Focus();
            }
            if (txt_numeb_kort.Text.Length == 10)
            {
                check_klient(txt_numeb_kort.Text);
                txt_full_name.Focus();
                txt_numeb_kort.Focus();
            }

            
        }

        void check_klient(string kort) {

            try
            {
                DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT id, kod_kort FROM obigarm.kort where kod_kort='{kort}';");

                string id_kort;
                if (dataTable_kort.Rows.Count == 0)
                {
                    MessageBox.Show("Чунин корт вучуд надорад!!!"); return;
                }
                else
                {
                    id_kort = dataTable_kort.Rows[0]["id"].ToString();
                }


                DataTable dataTable_id_client = sqlConfiguration.sqlSelectQuery($"select id, is_for_vrach, id_kort from client where deleted is null and is_for_vrach ='1' and id_kort ='{id_kort}';");
                select_info(dataTable_id_client.Rows[0]["id"].ToString());

                id_client = dataTable_id_client.Rows[0]["id"].ToString();
                display(id_client);
            }
            catch (Exception)
            {

                MessageBox.Show("Чунин истироҳаткунанда вучуд надорад");
            }

           
        }

        private void MainFormVrach_Shown(object sender, EventArgs e)
        {
            txt_numeb_kort.Focus();

        }

    }
}
