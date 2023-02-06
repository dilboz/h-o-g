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

namespace ObiGarm.Restorant
{
    public partial class RestorantForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private string id_type_kort;

        int count = 0;

        public RestorantForm()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            label_info_user.Text = $"Истифодабаранда: {SettingsDatabase.surname_user + " " + SettingsDatabase.name_user}";
            DataTable data_table_ = sqlConfiguration.sqlSelectQuery($"select * from users where id='{SettingsDatabase.id_user}'");
            id_type_kort = data_table_.Rows[0]["type_kort"].ToString();
            display_count();
        }

        public void display()
        {
            string sql = "select client.number_order, client.id, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', client.date_time_start, client.date_time_end, type_kort.name as 'type_kort' " +
                         "from client " +
                         "inner join kort on client.id_kort = kort.id " +
                         "inner join type_kort on kort.id_type_kort = type_kort.id " +
                         "where client.enable=1 and client.deleted is null " +
                         "order by id desc ";
            sqlConfiguration.displayListExpress(sql, grid_control_is_client);
        }

        private void RestorantForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void RestorantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        void check_klient(string kod_kort)
        {

            string info_select = "select client.id, date_time_end, room.breakfast, room.lunch, room.dinner, kort.kod_kort, kort.id_type_kort    " +
                "from client " +
                "inner join kort on client.id_kort = kort.id " +
                "inner join room on client.id_room = room.id " +
                $"where  kort.kod_kort = '{kod_kort}' and kort.id_type_kort='{id_type_kort}' and client.deleted is null";

            DataTable dataTable_info = sqlConfiguration.sqlSelectQuery(info_select);

            if (dataTable_info.Rows.Count!=0)
            {
                string check_select = "";

                if ((DateTime.Parse( DateTime.Now.ToString("HH:mm:ss")) > DateTime.Parse("07:00:00") &&   DateTime.Parse("10:11:00") > DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"))))
                {
                    check_select = "select client.id, date_time_end, room.breakfast, room.lunch, room.dinner, kort.kod_kort, kort.id_type_kort " +
                    "from client " +
                    "inner join kort on client.id_kort = kort.id " +
                    "inner join room on client.id_room = room.id " +
                    $"where (client.date_time_start between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Parse(dataTable_info.Rows[0]["date_time_end"].ToString()).AddDays(1).ToString("yyyy-MM-dd")}') " +
                    $"and kort.kod_kort = '{kod_kort}' and kort.id_type_kort='{id_type_kort}' " +
                    $"and (room.breakfast between '{dataTable_info.Rows[0]["breakfast"].ToString()}' and '{DateTime.Parse(dataTable_info.Rows[0]["breakfast"].ToString()).AddMinutes(59).ToString("HH:mm:ss")}') and  client.deleted is null; ";
                    check(check_select);
                }
                else if ((DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")) >= DateTime.Parse("12:01:00") && DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")) <= DateTime.Parse("17:00:00")))
                {
                    check_select = "select client.id, date_time_end, room.breakfast, room.lunch, room.dinner, kort.kod_kort, kort.id_type_kort " +
                    "from client " +
                    "inner join kort on client.id_kort = kort.id " +
                    "inner join room on client.id_room = room.id " +
                    $"where (client.date_time_start between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Parse(dataTable_info.Rows[0]["date_time_end"].ToString()).AddDays(1).ToString("yyyy-MM-dd")}') " +
                    $"and kort.kod_kort = '{kod_kort}' and kort.id_type_kort='{id_type_kort}' " +                   
                    $"and (room.lunch between '{dataTable_info.Rows[0]["lunch"].ToString()}' and '{DateTime.Parse(dataTable_info.Rows[0]["lunch"].ToString()).AddMinutes(59).ToString("HH:mm:ss")}') and client.deleted is null;";

                    check(check_select);
                }
                else if ((DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")) >= DateTime.Parse("18:01:00") && DateTime.Parse(DateTime.Now.ToString("HH:mm:ss")) <= DateTime.Parse("20:00:00")))
                {
                    check_select = "select client.id, date_time_end, room.breakfast, room.lunch, room.dinner, kort.kod_kort, kort.id_type_kort " +
                    "from client " +
                    "inner join kort on client.id_kort = kort.id " +
                    "inner join room on client.id_room = room.id " +
                    $"where (client.date_time_start between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Parse(dataTable_info.Rows[0]["date_time_end"].ToString()).AddDays(1).ToString("yyyy-MM-dd")}') " +
                    $"and kort.kod_kort = '{kod_kort}' and kort.id_type_kort='{id_type_kort}' " +
                   $"and (room.dinner between '{dataTable_info.Rows[0]["dinner"].ToString()}' and '{DateTime.Parse(dataTable_info.Rows[0]["dinner"].ToString()).AddMinutes(59).ToString("HH:mm:ss")}')) and client.deleted is null; ";

                    check(check_select);
                }
                else
                { 
                    label_info.Text = "Воакти хурок наомадааст!";
                    label_info.ForeColor = Color.Red;
                    timer_select_picture.Start();
                    pictureBox1.Image = Properties.Resources.no;
                }

                textEdit1.Text = check_select;



            }
            else
            {
                textEdit1.Text = info_select;
                label_info.Text = "Корт вучуд надорад!";
                label_info.ForeColor = Color.Red;
                timer_select_picture.Start();
                pictureBox1.Image = Properties.Resources.tome_out;
            }
        }

        void  check(string check_select)
        {
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(check_select);

            if (dataTable.Rows.Count != 0)
            {
                textEdit1.Text = check_select;
                label_info.Text = "Хуш омадед!";
               
                label_info.ForeColor = Color.White;
                display_count_();
                timer_select_picture.Start();
                pictureBox1.Image = Properties.Resources.yes;
            }
            else
            {
                textEdit1.Text = check_select;
                label_info.Text = "Воакти хурок наомадааст!";
                label_info.ForeColor = Color.Red;
                timer_select_picture.Start();
                pictureBox1.Image = Properties.Resources.no;
            }
        }

        void display_count_()
        {
            count++;
            labelControl3.Text = $"Миқдори одамони имруз қабул карда: {count} нафар";
        }

        void display_count()
        {
            string sql_select_today = $"select kort.kod_kort, kort.id_type_kort " +
                                      "from client " +
                                      "inner join kort on client.id_kort = kort.id " +
                                      $"where" +
                                      $" (client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end>= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}') and kort.id_type_kort='{id_type_kort}' and client.deleted is null"; 
            
            string sql_select = $"select kort.kod_kort, kort.id_type_kort " +
                                 "from client " +
                                 "inner join kort on client.id_kort = kort.id " +
                                  $"where" +
                                  $" (client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end>= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}') and kort.id_type_kort='{id_type_kort}' and client.deleted is null"; 

            lbl_info_today.Text = $"Миқдори одамони имруз меомада: {sqlConfiguration.sqlSelectQuery(sql_select_today).Rows.Count} нафар";
            lbl_info_day.Text = $"Миқдори одамони фардо меомада: {sqlConfiguration.sqlSelectQuery(sql_select).Rows.Count} нафар";

        }

        private void txt_kort_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);
                check_klient(txt_kort.Text);
                btn_ansver.Focus();
                txt_kort.Focus();
            }
            if (txt_kort.Text.Length == 10)
            {
                check_klient(txt_kort.Text);
                btn_ansver.Focus();
                txt_kort.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            display();
            display_count();
        }

        private void btn_ansver_Click(object sender, EventArgs e)
        {
            btn_ansver.Focus();
            txt_kort.Focus();
        }

        int select_tiem = 0;
        private void timer_select_picture_Tick(object sender, EventArgs e)
        {
            select_tiem++;
            pictureBox1.Visible = true;
            if (select_tiem==15)
            {
                pictureBox1.Visible = false;
                pictureBox1.Image = null;
                select_tiem = 0;
                timer_select_picture.Stop();
              
            }
        }

        private void txt_kort_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q && (e.Alt || e.Control || e.Shift))
            {
                if (textEdit1.Visible ==false)
                {
                    textEdit1.Visible = true;
                }
                else
                {
                    textEdit1.Visible = false;
                }
            }
        }
    }
}
