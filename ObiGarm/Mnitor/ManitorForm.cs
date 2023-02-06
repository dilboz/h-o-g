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
        private string id_manitor;

        private string[] id_client = new string[20];
        private string[] id_services = new string[20];        
        public ManitorForm(string id_manitor)
        {
            InitializeComponent();
            this.id_manitor = id_manitor;
            sqlConfiguration = new SqlConfiguration();
        }

        public void new_client(DateTime date)
        {

            string sql_select = "SELECT services_client.id, services_client.id_services, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'name_clients', date_format(services_client.time,'%H:%i') as 'time_services_clirnts', users.room_number as 'room_spitsalist' " +
                "FROM services_client " +
                "inner join client on services_client.id_client=client.id " +
                "inner join users on services_client.id_users=users.id " +
                $"where str_to_date(time, '%Y-%m-%d')='{date.ToString("yyyy-MM-dd")}'  and services_client.enable= '1' and services_client.deleted is null and users.id_manitor='{id_manitor}' " +
                $"ORDER BY services_client.time; ";

            to_labels(sqlConfiguration.sqlSelectQuery(sql_select));

        }

        void check_is_deleted(string id, string id_services, string time)
        {
            //MessageBox.Show(id + "- " + id_services + " + " + time);
            DataTable dataTable_services = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services where id = '{id_services}'; ");

            DateTime datetime_services = DateTime.Parse(time);

            if (dataTable_services.Rows.Count != 0)
            {
                string time_services = dataTable_services.Rows[0]["time_services"].ToString();

                double time_services_hh = double.Parse(Convert.ToDateTime(time_services).ToString("HH"));
                double time_services_mm = double.Parse(Convert.ToDateTime(time_services).ToString("mm"));

                datetime_services = datetime_services.AddHours(time_services_hh);
                datetime_services = datetime_services.AddMinutes(time_services_mm);
            }

            
            if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) >= DateTime.Parse(datetime_services.ToString("HH:mm")))
            {
                string sql = $"UPDATE services_client set enable='0', deleted= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE id ='{id}'; ";

                sqlConfiguration.sqlQuery(sql);
            }


        }

        private void ManitorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && (e.Alt || e.Control || e.Shift))
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void timer_select_Tick(object sender, EventArgs e)
        {
            new_client(DateTime.Now);
        }

        private void timer_select_time_now_Tick(object sender, EventArgs e)
        {
            label_info_top.Text = $"Имруз {DateTime.Now.ToString("D")}, соат {DateTime.Now.ToString("HH:mm:ss")}";
        }

        void to_labels(DataTable dataTable)
        {
            Label[] labels_name_client = new Label[] { label_client1, label_client2, label_client3, label_client4, label_client5,
                label_client6, label_client7, label_client8, label_client9, label_client10, label_client11, label_client12, label_client13, label_client14,
                label_client15, label_client16, label_client17, label_client18, label_client19, label_client20};

            Label[] time_selected = new Label[] { time_select_client1, time_select_client2, time_select_client3, time_select_client4, time_select_client5,
                time_select_client6, time_select_client7, time_select_client8, time_select_client9, time_select_client10, time_select_client11, time_select_client12, time_select_client13, time_select_client4,
                time_select_client15, time_select_client16, time_select_client17, time_select_client18, time_select_client19, time_select_client20};

            Label[] room_selected = new Label[] { room_select_client1, room_select_client2, room_select_client3, room_select_client4, room_select_client5,
                room_select_client6, room_select_client7, room_select_client8, room_select_client9, room_select_client10, room_select_client11, room_select_client12, room_select_client13, room_select_client14,
                room_select_client15, room_select_client16, room_select_client17, room_select_client18, room_select_client19, room_select_client20};

            clear_all_label();

            int index = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                
                if (index!=20)
                {
                    //MessageBox.Show(row["time_services_clirnts"].ToString());
                    if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) >= DateTime.Parse(row["time_services_clirnts"].ToString()))
                    {
                        id_client[index] = row["id"].ToString();
                        id_services[index] = row["id_services"].ToString();

                        labels_name_client[index].Text = row["name_clients"].ToString();
                        labels_name_client[index].BackColor=Color.Red; labels_name_client[index].ForeColor = Color.White;

                        time_selected[index].Text = row["time_services_clirnts"].ToString();
                        time_selected[index].BackColor = Color.Red; time_selected[index].ForeColor = Color.White;

                        room_selected[index].Text = row["room_spitsalist"].ToString();
                        room_selected[index].BackColor = Color.Red; room_selected[index].ForeColor = Color.White;

                        check_is_deleted(id_client[index], id_services[index], time_selected[index].Text);

                        index++;
                    }
                    else
                    {
                        id_client[index] = row["id"].ToString();
                        id_services[index] = row["id_services"].ToString();

                        labels_name_client[index].Text = row["name_clients"].ToString();
                        labels_name_client[index].BackColor = Color.White; labels_name_client[index].ForeColor = Color.Black;

                        time_selected[index].Text = row["time_services_clirnts"].ToString();
                        time_selected[index].BackColor = Color.White; time_selected[index].ForeColor = Color.Black;

                        room_selected[index].Text = row["room_spitsalist"].ToString();
                        room_selected[index].BackColor = Color.White; room_selected[index].ForeColor = Color.Black;
                        index++;
                    }

                }
                else
                {
                    break;
                }
            }
        }

        void clear_all_label()
        {
            Label[] labels_name_client = new Label[] { label_client1, label_client2, label_client3, label_client4, label_client5,
                label_client6, label_client7, label_client8, label_client9, label_client10, label_client11, label_client12, label_client13, label_client14,
                label_client15, label_client16, label_client17, label_client18, label_client19, label_client20};

            Label[] time_selected = new Label[] { time_select_client1, time_select_client2, time_select_client3, time_select_client4, time_select_client5,
                time_select_client6, time_select_client7, time_select_client8, time_select_client9, time_select_client10, time_select_client11, time_select_client12, time_select_client13, time_select_client4,
                time_select_client15, time_select_client16, time_select_client17, time_select_client18, time_select_client19, time_select_client20};

            Label[] room_selected = new Label[] { room_select_client1, room_select_client2, room_select_client3, room_select_client4, room_select_client5,
                room_select_client6, room_select_client7, room_select_client8, room_select_client9, room_select_client10, room_select_client11, room_select_client12, room_select_client13, room_select_client14,
                room_select_client15, room_select_client16, room_select_client17, room_select_client18, room_select_client19, room_select_client20};

            for (int i = 0; i < 20; i++)
            {
                labels_name_client[i].Text = "";
                labels_name_client[i].BackColor = Color.White; labels_name_client[i].ForeColor = Color.Black;

                time_selected[i].Text = "";
                time_selected[i].BackColor = Color.White; time_selected[i].ForeColor = Color.Black;

                room_selected[i].Text = "";
                room_selected[i].BackColor = Color.White; room_selected[i].ForeColor = Color.Black;
            }
        }

        private void ManitorForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

