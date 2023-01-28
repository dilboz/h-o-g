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
        private DataTable data_manitoe;

        public ManitorForm(string id_manitor)
        {
            InitializeComponent();
            this.id_manitor = id_manitor;
            sqlConfiguration = new SqlConfiguration();
        }

        public void new_client(DateTime date)
        {

            string sql_select = "SELECT services_client.id, services_client.id_services, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'name_clients', date_format(services_client.time,'%h:%i') as 'time_services_clirnts', users.room_number as 'room_spitsalist' " +
                "FROM services_client " +
                "inner join client on services_client.id_client=client.id " +
                "inner join users on services_client.id_users=users.id " +
                $"where str_to_date(time, '%Y-%m-%d')='{date.ToString("yyyy-MM-dd")}'  and services_client.enable= '1' and services_client.deleted is null and users.id_manitor='{id_manitor}' " +
                $"ORDER BY services_client.time; ";

            sqlConfiguration.displayList(sql_select, manitor_DataGridView);
            check_is_deleted();
            set_time_bool();
        }
        void set_time_bool()
        {
            if (manitor_DataGridView.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in manitor_DataGridView.Rows)
                {
                    //MessageBox.Show(DateTime.Parse( row.Cells[3].Value.ToString()).ToString("HH:mm") + " = " + DateTime.Now.ToString("HH:mm"));
                   
                }
            }
        }
        void check_is_deleted()
        {
            if (manitor_DataGridView.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in manitor_DataGridView.Rows)
                {
                    // id_clients row.Cells[0].Value.ToString()
                    // id_services row.Cells[1].Value.ToString()
                    // name_client row.Cells[2].Value.ToString()
                    // time row.Cells[3].Value.ToString()
                    // number_room row.Cells[4].Value.ToString()


                    DataTable dataTable_services = sqlConfiguration.sqlSelectQuery($"SELECT * FROM services where id = '{row.Cells[1].Value.ToString()}'; ");
                    if (dataTable_services.Rows.Count != 0)
                    {
                        string time_services = dataTable_services.Rows[0]["time_services"].ToString();

                        double time_services_hh = double.Parse(Convert.ToDateTime(time_services).ToString("HH"));
                        double time_services_mm = double.Parse(Convert.ToDateTime(time_services).ToString("mm"));

                    }

                    //MessageBox.Show(row.Cells[3].Value.ToString());

                    DateTime datetime_services = DateTime.Parse(row.Cells[3].Value.ToString());

                    if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) >= DateTime.Parse(datetime_services.ToString("HH:mm")))
                    {
                        string sql = $"UPDATE services_client set enable='0', deleted= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE id ='{row.Cells[0].Value.ToString()}'; ";
                        display_new();
                    }
                }
            }

        }
        void display_new()
        {
            string sql_select = "SELECT services_client.id, services_client.id_services, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'name_clients', date_format(services_client.time,'%h:%i') as 'time_services_clirnts', users.room_number as 'room_spitsalist' " +
                "FROM services_client " +
                "inner join client on services_client.id_client=client.id " +
                "inner join users on services_client.id_users=users.id " +
                $"where str_to_date(time, '%Y-%m-%d')='{DateTime.Now.ToString("yyyy-MM-dd")}'  and services_client.enable= '1' and services_client.deleted is null and users.id_manitor='{id_manitor}' " +
                $"ORDER BY services_client.time; ";

            sqlConfiguration.displayList(sql_select, manitor_DataGridView);
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
            label_info_top.Text = $"НИЗОМИ НАВБАТИ ИДОРАКУНИИ ЭЛЕКТРОНӢ: ИМРУЗ {DateTime.Now.ToString("D")} СОАТ {DateTime.Now.ToString("T")}";
        }

        private void manitor_DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (manitor_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == DateTime.Now.ToString("HH:mm"))
            {
                manitor_DataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                //manitor_DataGridView.FirstDisplayedScrollingRowIndex = ;
                manitor_DataGridView.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}

