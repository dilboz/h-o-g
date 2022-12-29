using InventorySystem1._0.Includes;
using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura
{
    public partial class AddCllient : Form
    {
        SqlConfiguration sqlConfiguration;
        usableFunction usableFunction;
        public string id_vrach;
        public string name_doctor;
        public string id_room;
        public string name_room;
        public string id_kort = "1";
        public string kod_kort = "";

        public AddCllient()
        {
            InitializeComponent();
        }



        void displaySex()
        {
            string sql = "select * from sex";
            sqlConfiguration.LoadCombo(sql, "name", "id", com_sex);
        }
        string sql_add_client;

        void msg(string messeg)
        {
            MessageBox.Show(messeg, "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void addClient()
        {
            string surname = txt_surname.Text.Trim();
            string name = txt_name.Text.Trim();
            string patramic = txt_name_patronymic.Text.Trim();
            string birthday = date_birthday.Value.ToString("dd'-'MM'-'yyyy");
            string id_sex = com_sex.SelectedValue.ToString();
            string datetime_start = date_first_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(time_first_dey.Text).ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(time_end_dey.Text).ToString("H:mm");
            string money="0";
            string is_for_vrach = "0";
            if (radio_is_money.Checked == true)
            {
                money = "1";
                is_for_vrach = "0";
            }
            else
            {
                money = "0";
                is_for_vrach = "1";
            }

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.kort where kod_kort='{txt_kort.Text}' and active ='0' and enable ='1';");


            if (dataTable_kort.Rows.Count==0)
            {
                msg("Чунин корт вучуд надорад!!!"); return;
            }
            else
            {
                id_kort = dataTable_kort.Rows[0]["id"].ToString();
            }

            string vrach = id_vrach;
            string room = id_room;
            string kord = id_kort;


            sql_add_client = sql_add_client = "insert into client (surname, name, patromic, birthday, id_sex, date_time_start, date_time_end, money, id_varch, id_room, id_kort, is_for_vrach, date_regis) " +
                $"values('{surname}', '{name}', '{patramic}', str_to_date('{birthday}', '%d-%m-%Y'), '{id_sex}', str_to_date('{datetime_start}', '%m.%d.%Y %H:%i'), str_to_date('{datetime_end}', '%m.%d.%Y %H:%i'), '{money}',  '{vrach}',' {room}', '{id_kort}' , '{is_for_vrach}', '{DateTime.Now.ToString("yyyy-MM-dd")}');";


            //txt_kort.Text = sql_add_client;
            if (surname == ""){msg("Шумо насаби муштариро дохил накардед!"); return; }
            else if (name == ""){msg("Шумо номи муштариро дохил накардед!"); return; }
            
            else if (vrach == "") { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            else if (room == "") { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            else if (kord == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            else if (surname != "" && name != "" &&  id_sex != "" && money != "" && vrach != "" && room != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Шумо бо мувафақият муштариро сабт намудед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string sql_plus_room = $"update room SET count_per = count_per +1  where id = '{id_room}' ";
                    sqlConfiguration.sqlSelectQuery(sql_plus_room);

                    string sql_check_active = $"SELECT * FROM obigarm.room where id = '{id_room}'; ";
                    DataTable data_table_check = sqlConfiguration.sqlSelectQuery(sql_check_active);


                    if (data_table_check.Rows[0]["max_per"].ToString()== data_table_check.Rows[0]["count_per"].ToString())
                    {
                        string _room_sql = $"update room SET active = '1' where id = {id_room}";
                        sqlConfiguration.sqlSelectQuery(_room_sql);
                    }
                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql);
                    string sql = $"update users SET summa_cliet = summa_cliet + 1 where id = '{id_vrach}';";
                    sqlConfiguration.sqlSelectQuery(sql);                
                    clear_all();
                }
            }
        }

        void clear_all()
        {
            txt_name.Clear();
            txt_surname.Clear();
            txt_name_patronymic.Clear();
            txt_name_doctor.Clear();
            txt_room.Clear();
            txt_kort.Clear();
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {

            addClient();
        } 

        private void AddCllient_Shown(object sender, EventArgs e)
        {
            
            sqlConfiguration = new SqlConfiguration();
            usableFunction = new usableFunction();
            displaySex();
        }

        private void btn_inser_docrot_Click(object sender, EventArgs e)
        {
            
            ListVrach listVrach = new ListVrach(this);
            listVrach.ShowDialog();
            txt_name_doctor.Text = name_doctor;
        }

        private void btn_insert_room_Click(object sender, EventArgs e)
        {
            
            ListRoom listRoom = new ListRoom(this);
            listRoom.ShowDialog();
            txt_room.Text = name_room;
        }

        private void btn_clear_room_Click(object sender, EventArgs e)
        {
            if (id_room!="" && name_room!="")
            {
                string sql = $"update room SET active = '0' where id = {id_room}";
                sqlConfiguration.sqlSelectQuery(sql);
                id_room = "";
                name_room = "";
                txt_room.Text = "";
            }
        }

        private void btn_clear_doctor_Click(object sender, EventArgs e)
        {
            if (id_vrach != "" && name_doctor != "")
            {
               
                id_vrach = "";
                name_doctor = "";
                txt_name_doctor.Text = "";
            }
        }


        private void btn_сlear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void inser_kort_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.kort where kod_kort='{txt_kort.Text}' and active ='0' and enable ='1';");


            if (dataTable_kort.Rows.Count == 0)
            {
                msg("Чунин корт вучуд надорад!!!"); return;
            }
            else
            {
                id_kort = dataTable_kort.Rows[0]["id"].ToString();
            }
            txt_kort.Focus();
        }

        private void btn_clear_kort_Click(object sender, EventArgs e)
        {
            txt_kort.Clear();
            txt_kort.Focus();
        }

        private void txt_kort_TextChanged(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);
                txt_name.Focus();
                txt_kort.Focus();
            }
        }

        private void radio_is_money_CheckedChanged(object sender, EventArgs e)
        {
            btn_creat.Text = "Ба хазинадор фиристондан";
        }

        private void radio_no_money_CheckedChanged(object sender, EventArgs e)
        {
            btn_creat.Text = "Ба табиб фиристондан";
        }
    }
}
