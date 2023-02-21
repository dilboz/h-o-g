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

            string sql_select = "SELECT services_client.id, services_client.id_services, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'name_clients', date_format(services_client.time,'%H:%i') as 'time_services_clirnts', concat(services.name, ' (', users.surname , ' ', substr(users.name, 1, 1), '..)') as 'users'  " +
                "FROM services_client " +
                "inner join client on services_client.id_client=client.id " +
                "inner join users on services_client.id_users=users.id " +
                "inner join services on services_client.id_services= services.id " +
                $"where str_to_date(time, '%Y-%m-%d')='{date.ToString("yyyy-MM-dd")}'  and services_client.enable= '1' and services_client.deleted is null and users.id_manitor='{id_manitor}' " +
                $"ORDER BY services_client.time; ";

            //Console.WriteLine(sql_select);

            sqlConfiguration.displayListExpress(sql_select, gridControl);

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

        private void gridViewQueryClient_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            DateTime time = Convert.ToDateTime(gridViewQueryClient.GetRowCellValue(e.RowHandle, "time_services_clirnts"));
            string id = Convert.ToString(gridViewQueryClient.GetRowCellValue(e.RowHandle, "id"));
            string id_services = Convert.ToString(gridViewQueryClient.GetRowCellValue(e.RowHandle, "id_services"));

            if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) >= DateTime.Parse(time.ToString("HH:mm")))
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.White;
                e.HighPriority = true;
                check_is_deleted(id, id_services, time.ToString("HH:mm"));
            }
            
            else
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.Black;
                e.HighPriority = true;
            }
        }
    }
}

