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
        private string id_vrach;        

        public static bool edit_services_client;
        private string id_client;
        private string name_jins="";
        private string order = "";

        private DataSet dataSet_fro_print;
        public MainFormVrach(string id_vrach)
        {
            InitializeComponent();
            this.id_vrach = id_vrach;
            sqlConfiguration = new SqlConfiguration();
            user_info_label.Text =  SettingsDatabase.name_user + " " + SettingsDatabase.surname_user;
            txt_numeb_kort.Focus();
            display_comboclients();
        }

        void display_comboclients()
        {
            string sql = "select id, concat(surname , ' ' , name , ' ' , patromic) as full_name from client where enable=1  and deleted is null order by id desc ";
            sqlConfiguration.LoadCombo(sql, "full_name", "id", combo_client);
            combo_client.SelectedIndex = -1;
        }

        void dispaly_info_clients(string id_clients)
        {
            string sql_query = "select client.id, client.number_order, client.id_varch, sex.name as 'sex', concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name',  " +
                "client.year_birthday, client.date_time_start, " +
                "client.date_time_end, concat(users.surname, ' ', users.name)  as 'name_vrach', concat('Бинои ', frame.name, ' Ҳуҷраи ', room.name) as 'room', " +
                "room.breakfast, room.lunch, room.dinner  " +
                "from client " +
                "inner join users on client.id_varch  = users.id " +
                "inner join sex on client.id_sex  = sex.id " +
                "inner join room  on client.id_room = room.id " +
                "inner join frame on room.id_freme = frame.id " +
                $"where client.enable = 1 and client.deleted is null and client.id='{id_clients}';";

            

            DataTable _info1 = sqlConfiguration.sqlSelectQuery(sql_query);
            if (_info1.Rows.Count != 0)
            {
                txt_full_name.Text = _info1.Rows[0]["full_name"].ToString();
                txt_year_burhhday.Text = _info1.Rows[0]["year_birthday"].ToString();
                txt_start_time.Text = _info1.Rows[0]["date_time_start"].ToString();
                time_end_time.Text = _info1.Rows[0]["date_time_end"].ToString();
                txt_name_doctor.Text = _info1.Rows[0]["name_vrach"].ToString();
                txt_room.Text = _info1.Rows[0]["room"].ToString();
                txt_time_nahory.Text = _info1.Rows[0]["breakfast"].ToString();
                txt_nisfiruzi.Text = _info1.Rows[0]["lunch"].ToString();
                txt_hurok_begohruzi.Text = _info1.Rows[0]["dinner"].ToString();
                name_jins = _info1.Rows[0]["sex"].ToString();
                order = _info1.Rows[0]["number_order"].ToString();
                if (this.id_vrach == _info1.Rows[0]["id_varch"].ToString()) 
                    edit_services_client = true;
                else edit_services_client = false;

                dispaly_info2_clients(id_clients);
                display_services_client(id_clients);
            }
            else
            {
                MessageBox.Show("korti_dfnouvofiq");
            }

        }

        void dispaly_info2_clients(string id_clients)
        {
            string sql_query = $"select * from info_table_clients where id_clients = '{id_clients}';";

            DataTable _info2 = sqlConfiguration.sqlSelectQuery(sql_query);
            if (_info2.Rows.Count != 0)
            {
                com_nishonahoi_tabobat.SelectedIndex = -1;
                txt_EKG.Text = _info2.Rows[0]["sanjishi_barqii_dil"].ToString();
                txt_tarkibi_hun.Text = _info2.Rows[0]["sanjishi_tarkibi_hun"].ToString();
                txt_sanjishi_peshob.Text = _info2.Rows[0]["sanjishi_peshob"].ToString();
                txt_ultarasado.Text = _info2.Rows[0]["sanjishi_ultrasao"].ToString();
                txt_sanjishi_nasoji.Text = _info2.Rows[0]["najsoat"].ToString(); ;
                txt_qad.Text = _info2.Rows[0]["qad"].ToString();
                txt_vazn.Text = _info2.Rows[0]["vazn"].ToString();
                txt_hajmi_qafasi_sina.Text = _info2.Rows[0]["hajmi_qafasi_sina"].ToString();
                txt_qobiliyati_nafaskashi.Text = _info2.Rows[0]["qobiliyati_nafaskashi"].ToString();
                txt_quvai_bozuho.Text = _info2.Rows[0]["sanjishi_kuvai_bojuho"].ToString();
                txt_fishori_hun.Text = _info2.Rows[0]["fishori_hun"].ToString();
                txt_nabz.Text = _info2.Rows[0]["nabz"].ToString();
                txt_harorat.Text = _info2.Rows[0]["harorat"].ToString();
                com_nishonahoi_tabobat.Text = _info2.Rows[0]["nishonahoi_tabobat"].ToString();
            }
            else
            {
                check_id(id_client);    
                txt_EKG.Text = "";
                txt_tarkibi_hun.Text = "";
                txt_sanjishi_peshob.Text = "";
                txt_ultarasado.Text = "";
                txt_qad.Text = "";
                txt_sanjishi_nasoji.Text = "";
                txt_vazn.Text = "";
                txt_hajmi_qafasi_sina.Text = "";
                txt_qobiliyati_nafaskashi.Text = "";
                txt_quvai_bozuho.Text = "";
                txt_fishori_hun.Text = "";
                txt_nabz.Text = "";
                txt_harorat.Text = "";
                com_nishonahoi_tabobat.SelectedIndex = -1;
            }

        }

       public void display_services_client(string id_client)
        {
            string display = "SELECT services_client.id, services.name as 'name_services', concat(users.surname, ' ', users.name) as 'name_spitsalist',  services_client.time as 'time_services' " +
               "FROM services_client " +
               "inner join services on services_client.id_services = services.id " +
               "inner join users on services_client.id_users = users.id " +
               $"where services_client.id_client ='{id_client}' and services_client.deleted is null "+
               "ORDER BY services_client.time; ";

            sqlConfiguration.displayList(display, datagridview_allServicesClient);
        }

        private void MainFormVrach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void check_klient(string kort) {

            try
            {
                DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT id, kod_kort FROM kort where kod_kort='{kort}';");

                string id_kort;
                if (dataTable_kort.Rows.Count == 0)
                {
                    MessageBox.Show("Чунин корт вучуд надорад!!!"); return;
                    enbled_false();
                }
                else
                {
                    id_kort = dataTable_kort.Rows[0]["id"].ToString();
                }

                DataTable dataTable_id_client = sqlConfiguration.sqlSelectQuery($"select id, id_kort from client where deleted is null and id_kort ='{id_kort}';");
                dispaly_info_clients(dataTable_id_client.Rows[0]["id"].ToString());
                id_client = dataTable_id_client.Rows[0]["id"].ToString();
                enbled_true();
                combo_client.Text = txt_full_name.Text;
                btn_add_services.Visible = true;
            }
            catch (Exception)
            {
                enbled_false();
                btn_add_services.Visible = false;
                MessageBox.Show("Чунин истироҳаткунанда вучуд надорад");
            }

           
        }

        private void check_kort_btn_Click(object sender, EventArgs e)
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

        private void btn_logut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }


        private void combo_client_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (combo_client.SelectedValue.ToString() != "" || combo_client.SelectedIndex != -1)
            {
                id_client = combo_client.SelectedValue.ToString();
                dispaly_info_clients(combo_client.SelectedValue.ToString());
                enbled_true();
                btn_add_services.Visible = true;
               
            }
            else
            {
                enbled_false();
                btn_add_services.Visible = false;
            }
        }

        private void btn_add_services_Click(object sender, EventArgs e)
        {
            AddServicesForClient addServicesForClient = new AddServicesForClient(this, id_client, edit_services_client);
            addServicesForClient.ShowDialog();
        }

        void check_id(string id_client)
        {
            string sql_query = $"select * from info_table_clients where id_clients = '{id_client}';";

            DataTable _info2 = sqlConfiguration.sqlSelectQuery(sql_query);
            if (_info2.Rows.Count == 0)
            {
                string insert = $"INSERT INTO info_table_clients (id_clients) VALUES ('{id_client}');";
                sqlConfiguration.sqlQuery(insert);
            }
        }

        private void txt_EKG_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET sanjishi_barqii_dil = '{txt_EKG.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_tarkibi_hun_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET sanjishi_tarkibi_hun = '{txt_tarkibi_hun.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_sanjishi_peshob_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET sanjishi_peshob = '{txt_sanjishi_peshob.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_ultarasado_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET sanjishi_ultrasao = '{txt_ultarasado.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_qad_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET qad = '{txt_qad.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_vazn_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET vazn = '{txt_vazn.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_hajmi_qafasi_sina_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET hajmi_qafasi_sina = '{txt_hajmi_qafasi_sina.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_qobiliyati_nafaskashi_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET qobiliyati_nafaskashi = '{txt_qobiliyati_nafaskashi.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        void enbled_false()
        {
            txt_EKG.Enabled = false;
            txt_tarkibi_hun.Enabled = false;
            txt_sanjishi_peshob.Enabled = false;
            txt_ultarasado.Enabled = false;
            txt_sanjishi_nasoji.Enabled = false;
            txt_qad.Enabled = false;
            txt_vazn.Enabled = false;
            txt_hajmi_qafasi_sina.Enabled = false;
            txt_qobiliyati_nafaskashi.Enabled = false;
            txt_quvai_bozuho.Enabled = false;
            txt_fishori_hun.Enabled = false;
            txt_nabz.Enabled = false;
            txt_harorat.Enabled = false;
            com_nishonahoi_tabobat.Enabled = false;
        }

        void enbled_true()
        {
            txt_EKG.Enabled = true;
            txt_tarkibi_hun.Enabled = true;
            txt_sanjishi_peshob.Enabled = true;
            txt_ultarasado.Enabled = true;
            txt_qad.Enabled = true;
            txt_vazn.Enabled = true;
            txt_sanjishi_nasoji.Enabled = true;
            txt_hajmi_qafasi_sina.Enabled = true;
            txt_qobiliyati_nafaskashi.Enabled = true;
            txt_quvai_bozuho.Enabled = true;
            txt_fishori_hun.Enabled = true;
            txt_nabz.Enabled = true;
            txt_harorat.Enabled = true;
            com_nishonahoi_tabobat.Enabled = true;
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn dc = new DataColumn("name_spitsalist", typeof(String));
            dataTable.Columns.Add(dc);

            dc = new DataColumn("name_services", typeof(String));
            dataTable.Columns.Add(dc);

            dc = new DataColumn("time_services", typeof(String));
            dataTable.Columns.Add(dc);
            if (datagridview_allServicesClient.Rows.Count!=0)
            {   int count_row = 0;
                foreach (DataGridViewRow row in datagridview_allServicesClient.Rows)
                {
                    if (count_row==18)
                    {
                        break;
                    }
                    DataRow dr = dataTable.NewRow();
                    dr[0] = row.Cells["name_spitsalist"].Value.ToString();
                    dr[1] = row.Cells["name_services"].Value.ToString();
                    dr[2] = row.Cells["time_services"].Value.ToString();
                    dataTable.Rows.Add(dr);
                    count_row++;
                }
                if (count_row<18)
                {
                    for (int i = count_row; i < 18; i++)
                    {
                            DataRow dr = dataTable.NewRow();
                            dr[0] = "";
                            dr[1] = "";
                            dr[2] = "";
                            dataTable.Rows.Add(dr);
                        count_row++;
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < 18; i++)
                {
                    DataRow dr = dataTable.NewRow();
                    dr[0] = "";
                    dr[1] = "";
                    dr[2] = "";
                    dataTable.Rows.Add(dr);
                }
              
            }
            

            PrintForm printForm  = new PrintForm(dataTable, txt_full_name.Text, txt_year_burhhday.Text, name_jins, string.Concat(txt_start_time.Text, " - ", time_end_time.Text), txt_qad.Text, txt_vazn.Text, txt_hajmi_qafasi_sina.Text, txt_qobiliyati_nafaskashi.Text,
                txt_quvai_bozuho.Text, txt_tarkibi_hun.Text, txt_nabz.Text, txt_harorat.Text, txt_EKG.Text, txt_sanjishi_peshob.Text, txt_sanjishi_nasoji.Text, txt_ultarasado.Text, txt_time_nahory.Text, txt_nisfiruzi.Text, txt_hurok_begohruzi.Text, txt_name_doctor.Text, com_nishonahoi_tabobat.Text, order );
            printForm.ShowDialog();
        }

        private void txt_quvai_bozuho_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET sanjishi_kuvai_bojuho = '{txt_quvai_bozuho.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_fishori_hun_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET fishori_hun = '{txt_fishori_hun.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_nabz_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET nabz = '{txt_fishori_hun.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_harorat_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET harorat = '{txt_harorat.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void txt_sanjishi_nasoji_TextChanged(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET najsoat = '{txt_sanjishi_nasoji.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }

        private void com_nishonahoi_tabobat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            check_id(id_client);
            string sql_query = $"UPDATE info_table_clients SET nishonahoi_tabobat = '{com_nishonahoi_tabobat.Text}' WHERE id_clients = '{id_client}';";
            sqlConfiguration.sqlQuery(sql_query);
        }
    }
}
