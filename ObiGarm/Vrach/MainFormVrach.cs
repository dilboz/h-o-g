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
            user_info_label.Text = "Истифодабаранда: " + SettingsDatabase.name_user + " " + SettingsDatabase.surname_user;
            display_client();
            check_is_client();
            check_btn_add_services();
        }

        void display_client()
        {
            string sql = "select id, concat(surname , ' ' , name , ' ' , patromic) as full_name from client where enable=1";
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

        void check_is_client()
        {
            if (is_check_kort == false)
            {
                panel_search_client.Visible = true;
                button_active_kort.BackColor = Color.Red;
                button_active_kort.Text = "Фаол кардани корт санҷ";
            }else {
                panel_search_client.Visible = false;
                button_active_kort.BackColor = Color.FromArgb(65, 163, 98);
                button_active_kort.Text = "Хомуш кардани кортсанҷ";
            }
        }

        public void check_btn_add_services()
        {
            if (combo_client.Text!="")
            {
                btn_add_services.Visible = true;
                display(combo_client.SelectedValue.ToString());
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

            txt_full_name.Text= dataTable.Rows[0]["full_name"].ToString();
            txt_birthday.Text= dataTable.Rows[0]["birthday"].ToString();
            txt_sex.Text= dataTable.Rows[0]["sex"].ToString();
            txt_time_start.Text= dataTable.Rows[0]["date_time_start"].ToString();
            txt_end_time.Text= dataTable.Rows[0]["date_time_start"].ToString();
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
            AddServicesForClient addServicesForClient = new AddServicesForClient(this, combo_client.SelectedValue.ToString(), "", "");
            addServicesForClient.ShowDialog();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
