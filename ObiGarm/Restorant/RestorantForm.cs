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
            string sql = "select client.id, client.number_order, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', date_format(client.date_time_start, '%d-%m-%Y') as 'start_date', date_format(client.date_time_end, '%d-%m-%Y') as 'end_date', type_kort.name as 'type_kort', time_format(room.breakfast , '%H:%i') as 'breakfast', time_format(room.lunch  , '%H:%i') as 'lunch', time_format(room.dinner , '%H:%i') as 'dinner' " +
                         "from client " +
                         "inner join kort on client.id_kort = kort.id " +
                         "inner join type_kort on kort.id_type_kort = type_kort.id " +
                         "inner join room on  client.id_room = room.id " +
                         $"where client.enable=1 and client.deleted is null and client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
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
        void checkBreakfast(string idKort)
        {
            string sqlQuery = "select client.id " +
                "from client " +
                "inner join kort on client.id_kort = kort.id " +
                "inner join room on client.id_room = room.id " +
                "where client.enable=1 and client.deleted is null " +
                $"and client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                $"and room.breakfast between '06:00' and '09:30' " +
                $"and kort.id_type_kort= '{id_type_kort}' and kort.kod_kort= '{idKort}' " +
                $"and client.date_current_to_restorant not between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Now.ToString("yyyy-MM-dd")}';";

            if (sqlConfiguration.sqlSelectQuery(sqlQuery).Rows.Count!=0)
            {
                count++;
                labelCountToDay.Text = $"Одамони ируз меомада: {count} нафар";
                label_info.Text = "Хуш омадед ба хурои саҳаррузи!";
                label_info.ForeColor = Color.Green;
                pictureInfoKort.Image = Properties.Resources.yes;
                timer_select_picture.Start();
                SettingsDatabase.setCurrenEatClient(sqlConfiguration.sqlSelectQuery(sqlQuery).Rows[0]["id"].ToString());
            }
            else
            {
                label_info.Text = "Вақти хурои саҳаррузи наомадаст:!";
                label_info.ForeColor = Color.Red;
                pictureInfoKort.Image = Properties.Resources.no;
                timer_select_picture.Start();
            }
        }

        void checkLiunck(string idKort)
        {
            string sqlQuery = "select client.id " +
                "from client " +
                "inner join kort on client.id_kort = kort.id " +
                "inner join room on client.id_room = room.id " +
                "where client.enable=1 and client.deleted is null " +
                $"and client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                $"and room.lunch between '10:30' and '14:30' " +
                $"and kort.id_type_kort= '{id_type_kort}' and kort.kod_kort= '{idKort}' " +
                $"and client.date_current_to_restorant not between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Now.ToString("yyyy-MM-dd")}';";

            Console.WriteLine(sqlQuery);

            if (sqlConfiguration.sqlSelectQuery(sqlQuery).Rows.Count != 0)
            {
                labelCountToDay.Text = $"Одамони ируз меомада: {count++} нафар"; count++;
                labelCountToDay.Text = $"Одамони ируз меомада: {count} нафар";
                label_info.Text = "Хуш омадед ба хурои нисфирузӣ!";
                label_info.ForeColor = Color.Green;
                pictureInfoKort.Image = Properties.Resources.yes;
                timer_select_picture.Start();
                SettingsDatabase.setCurrenEatClient(sqlConfiguration.sqlSelectQuery(sqlQuery).Rows[0]["id"].ToString());
            }
            else
            {
                label_info.Text = "Вақти хурои нисфирузӣ наомадаст:!";
                label_info.ForeColor = Color.Red;
                pictureInfoKort.Image = Properties.Resources.no;
                timer_select_picture.Start();
            }
        }

        void chekckDinner(string idKort)
        {
            string sqlQuery = "select client.id " +
                "from client " +
                "inner join kort on client.id_kort = kort.id " +
                "inner join room on client.id_room = room.id " +
                "where client.enable=1 and client.deleted is null " +
                $"and client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                $"and room.dinner between '17:000' and '19:00' " +
                $"and kort.id_type_kort= '{id_type_kort}' and kort.kod_kort= '{idKort}' " +
                $"and client.date_current_to_restorant not between '{DateTime.Now.ToString("yyyy-MM-dd")}' and '{DateTime.Now.ToString("yyyy-MM-dd")}';";

            Console.WriteLine(sqlQuery);

            if (sqlConfiguration.sqlSelectQuery(sqlQuery).Rows.Count != 0)
            {
                count++;
                labelCountToDay.Text = $"Одамони ируз меомада: {count} нафар";
                label_info.Text = "Хуш омадед ба хурои бегоҳрузӣ!";
                label_info.ForeColor = Color.Green;
                pictureInfoKort.Image = Properties.Resources.yes;
                timer_select_picture.Start();
                SettingsDatabase.setCurrenEatClient(sqlConfiguration.sqlSelectQuery(sqlQuery).Rows[0]["id"].ToString());
            }
            else
            {
                label_info.Text = "Вақти хурои бегоҳрузӣ наомадаст:!";
                label_info.ForeColor = Color.Red;
                pictureInfoKort.Image = Properties.Resources.no;
                timer_select_picture.Start();
            }

        }

        void display_count()
        {
            string sql_select_today = $"select count(*) as 'count' " +
                                      "from client " +
                                      "inner join kort on client.id_kort = kort.id " + 
                                      $"where client.enable=1 and client.deleted is null and client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.ToString("yyyy-MM-dd")}' and kort.id_type_kort= '{id_type_kort}'; "; 
            
            string sql_select = $"select count(*) as 'count' " +
                                "from client " +
                                "inner join kort on client.id_kort = kort.id " +
                                $"where client.enable=1 and client.deleted is null and client.date_time_start <= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}' and client.date_time_end >= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}' and kort.id_type_kort= '{id_type_kort}'; ";

            DataTable dataTableCountClientToDay = sqlConfiguration.sqlSelectQuery(sql_select_today);
            DataTable dataTableCountClientTomorrow = sqlConfiguration.sqlSelectQuery(sql_select);

            if (dataTableCountClientToDay.Rows.Count != 0)
                lbl_info_today.Text = $"Одамони имруз омадан: {dataTableCountClientToDay.Rows[0]["count"].ToString()} нафар";
            else
                lbl_info_today.Text = $"Одамони имруз омадан: 0 нафар";

            if (dataTableCountClientTomorrow.Rows.Count != 0)
                lbl_infoTomorrow.Text = $"Одамони фардо меомада: {dataTableCountClientTomorrow.Rows[0]["count"].ToString()} нафар";
            else
                lbl_info_today.Text = $"Одамони фардо меомада: 0 нафар";
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
            panelInfoKort.Visible = true;
            if (select_tiem==15)
            {
                panelInfoKort.Visible = false;
                pictureInfoKort.Image = null;
                txt_kort.Text = "";
                select_tiem = 0;
                timer_select_picture.Stop();
              
            }
        }

        private void txt_kort_EditValueChanged_1(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);

                string sqlForCheckKort = $"select id from kort where kod_kort = '{txt_kort.Text.Substring(10, 10)}' ";

                if (sqlConfiguration.sqlSelectQuery(sqlForCheckKort).Rows.Count != 0) {
                    string sqlIsActiveKort = $"select id from kort where kod_kort = '{txt_kort.Text.Substring(10, 10)}' and active = '0'; ";
                    if (sqlConfiguration.sqlSelectQuery(sqlIsActiveKort).Rows.Count != 0)
                    {
                        label_info.Text = "Муҳлати корт гузаштааст!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.tome_out;
                        timer_select_picture.Start();
                        return;
                    }
                }
                else
                {
                    label_info.Text = "Чунин корт вуҷуд надорад!";
                    label_info.ForeColor = Color.Red;
                    pictureInfoKort.Image = Properties.Resources.isNotMyKort;
                    timer_select_picture.Start();
                    return;
                }

                if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("06:30") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("09:30"))
                {
                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.Substring(10, 10)}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '06:30' and '09:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count!=0)
                    {
                        label_info.Text = "Шумо хуроки саҳаррузӣ худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else {
                        checkBreakfast(txt_kort.Text.PadLeft(10, '0'));
                        return;
                    }

                    
                }
                else if(DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("10:30") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("14:30"))
                {
                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.Substring(10, 10)}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '10:30' and '14:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count != 0)
                    {
                        label_info.Text = "Шумо хуроки нисфирузи худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else
                    {
                        checkLiunck(txt_kort.Text.PadLeft(10, '0'));
                        return;
                    }
                    
                }
                else if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("17:00") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("19:30"))
                {

                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.Substring(10, 10)}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '17:00' and '19:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count != 0)
                    {
                        label_info.Text = "Шумо хуроки бегоҳрузи худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else
                    {
                        chekckDinner(txt_kort.Text.PadLeft(10, '0'));                        
                        return;
                    }
                }
                btn_ansver.Focus();
                txt_kort.Focus();
            }
            if (txt_kort.Text.Length == 10 && txt_kort.Text!="0000000000")
            {

                string sqlForCheckKort = $"select id from kort where kod_kort = '{txt_kort.Text.PadLeft(10, '0')}' ";

                if (sqlConfiguration.sqlSelectQuery(sqlForCheckKort).Rows.Count != 0)
                {
                    string sqlIsActiveKort = $"select id from kort where kod_kort = '{txt_kort.Text.PadLeft(10, '0')}' and active = '0'; ";
                    if (sqlConfiguration.sqlSelectQuery(sqlIsActiveKort).Rows.Count != 0)
                    {
                        label_info.Text = "Муҳлати корт гузаштааст!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.tome_out;
                        timer_select_picture.Start();
                        return;
                    }
                }
                else
                {
                    label_info.Text = "Чунин корт вуҷуд надорад!";
                    label_info.ForeColor = Color.Red;
                    pictureInfoKort.Image = Properties.Resources.isNotMyKort;
                    timer_select_picture.Start();
                    return;
                }

                if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("06:30") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("09:30"))
                {
                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.PadLeft(10, '0')}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '06:30' and '09:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count != 0)
                    {
                        label_info.Text = "Шумо хуроки саҳаррузӣ худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else
                    {
                        checkBreakfast(txt_kort.Text.PadLeft(10, '0'));
                        return;
                    }


                }
                else if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("10:30") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("14:30"))
                {
                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.PadLeft(10, '0')}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '10:30' and '14:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count != 0)
                    {
                        label_info.Text = "Шумо хуроки нисфирузи худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else
                    {
                        checkLiunck(txt_kort.Text.PadLeft(10, '0'));
                        return;
                    }

                }
                else if (DateTime.Parse(DateTime.Now.ToString("HH:mm")) > DateTime.Parse("17:00") && DateTime.Parse(DateTime.Now.ToString("HH:mm")) < DateTime.Parse("19:30"))
                {

                    string sqlCeckIseat = "select client.date_current_to_restorant  " +
                        "from client " +
                        "inner join kort on client.id_kort = kort.id " +
                        $"where client.enable ='1' and client.deleted  is null and  kort.kod_kort= '{txt_kort.Text.PadLeft(10, '0')}' " +
                        $"and date_format(client.date_current_to_restorant, '%Y-%m-%d') = '{DateTime.Now.ToString("yyyy-MM-dd")}' " +
                        $"and time_format(client.date_current_to_restorant, '%H:%i') between '17:00' and '19:30' ";

                    if (sqlConfiguration.sqlSelectQuery(sqlCeckIseat).Rows.Count != 0)
                    {
                        label_info.Text = "Шумо хуроки бегоҳрузи худа будед!";
                        label_info.ForeColor = Color.Red;
                        pictureInfoKort.Image = Properties.Resources.isEat;
                        timer_select_picture.Start();
                        return;
                    }
                    else
                    {
                        chekckDinner(txt_kort.Text.PadLeft(10, '0'));
                        return;
                    }
                }
                else
                {
                    label_info.Text = "Вакти хурокхури  нест!";
                    label_info.ForeColor = Color.Red;
                    pictureInfoKort.Image = Properties.Resources.isEat;
                    timer_select_picture.Start();
                    return;
                }

                btn_ansver.Focus();

                txt_kort.Focus();
            }
        }

        private void reflashInfo_Click(object sender, EventArgs e)
        {
            display();
            display_count();
        }
    }
}
