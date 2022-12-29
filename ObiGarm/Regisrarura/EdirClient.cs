using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura
{
    public partial class EdirClient : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly IsClient isClientFrom;
        public string id_client;
        private DataTable dataTable_me;
        private bool is_not_money;

        private string current_id_room;
        public string id_vrach_me;
        public string name_vrach_="";
        private string currebt_id_vrach_me;
        public string id_room;
        public string name_room;
        private string id_kort;
        public EdirClient(IsClient isClient, string id)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            isClientFrom = isClient;
            id_client = id;
            displaySex();
            setTextToTextbox(id_client);
        }

        public void set_names_room_()
        {
            txt_room.Text = name_room;
        }

        public void set_names_varch_()
        {
            txt_name_doctor.Text = name_vrach_;
        }

        void displaySex()
        {
            string sql = "select * from sex";
            sqlConfiguration.LoadCombo(sql, "name", "id", com_sex);
        }

        private string setsex(string id)
        {
            string sql = $"select name from sex where id={id}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            return dataTable.Rows[0]["name"].ToString(); 
        }

        void change_money()
        {
            if (radio_is_money.Checked==true)
            {
                panel3.Visible = true;
                is_not_money = true;

                txt_number_money.Text = dataTable_me.Rows[0]["nuber_money"].ToString(); ;
                txt_commen_money.Text = dataTable_me.Rows[0]["comment_money"].ToString();
            }
            if (radio_no_money.Checked == true)
            {
                panel3.Visible = false;
                is_not_money = true;
            }
        }

        void money_change(int money_my_id)
        {
            if (money_my_id == 1)
            {
                is_not_money = true;
                panel3.Visible = true;
                radio_is_money.Checked = true;
                radio_no_money.Checked = false;
            }
            else
            {
                is_not_money = false;
                panel3.Visible = false;
                radio_is_money.Checked = false;
                radio_no_money.Checked = true;
            }
        }

        void setmoney(string index_money)
        {
            if (index_money=="0")
            {
                radio_is_money.Checked = false;
                radio_no_money.Checked = true;
            }
            else
            {
                radio_is_money.Checked = true;
                radio_no_money.Checked = false;
            }
            change_money();
        }

        private string name_vrach(string id_vrach)
        {
            string sql = $"select id, concat(surname, ' ', name, ' (', summa_cliet, ')') as 'full_name'  from users where id={id_vrach}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            id_vrach_me= dataTable.Rows[0]["id"].ToString();
            currebt_id_vrach_me = id_vrach_me;
            return dataTable.Rows[0]["full_name"].ToString();
        }

        private string room(string id_vrach)
        {
            string sql = "select room.id, concat('Бинои ', frame.name, ' Ҳуҷраи ', room.name) as 'name_room' " +
                         "from room "+
                         "inner join frame on room.id_freme = frame.id "+"" +
                         $"where room.id = {id_vrach}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            id_room = dataTable.Rows[0]["id"].ToString();
            current_id_room = id_room;
            return dataTable.Rows[0]["name_room"].ToString();
        }

        private string kort(string id_kort) {

            this.id_kort = id_kort;
            string sql = "select * from kort " +
                        $"where id = {id_kort}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            return dataTable.Rows[0]["kod_kort"].ToString();
        }

        private void setTextToTextbox(string id)
        {
            string sql = $"select * from client where id= {id};";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            dataTable_me = dataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {

                    txt_surname.Text = dataTable.Rows[0]["surname"].ToString();
                    txt_name.Text = dataTable.Rows[0]["name"].ToString();
                    txt_name_patronymic.Text = dataTable.Rows[0]["patromic"].ToString();
                    date_birthday.Value = Convert.ToDateTime(dataTable.Rows[0]["birthday"].ToString());
                    com_sex.Text = setsex(dataTable.Rows[0]["id_sex"].ToString());
                    date_first_dey.Value= Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());
                    time_first_dey.EditValue= Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());                    
                    date_end_dey.Value= Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());
                    time_end_dey.EditValue = Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());
                    setmoney(dataTable.Rows[0]["money"].ToString());
                    txt_name_doctor.Text = name_vrach(dataTable.Rows[0]["id_varch"].ToString());
                    txt_room.Text = room(dataTable.Rows[0]["id_room"].ToString());
                    txt_kort.Text = kort(dataTable.Rows[0]["id_kort"].ToString());

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        void msg(string messeg)
        {
            MessageBox.Show(messeg, "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void updateClient(string id)
        {
            string surname = txt_surname.Text.Trim();
            string name = txt_name.Text.Trim();
            string patramic = txt_name_patronymic.Text.Trim();
            string birthday = date_birthday.Value.ToString("dd'-'MM'-'yyyy");
            string id_sex = com_sex.SelectedValue.ToString();
            string datetime_start = date_first_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(time_first_dey.Text).ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(time_end_dey.Text).ToString("H:mm");
            string money = "0";
            string number_money = txt_number_money.Text;
            string comment_money = txt_commen_money.Text.Trim();
            string is_for_vrach = "1";
            if (radio_is_money.Checked == true)
            {
                money = "1";
            }
            else
            {
                money = "0";
            }

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM obigarm.kort where kod_kort='{txt_kort.Text}' and enable ='1';");


            if (dataTable_kort.Rows.Count == 0)
            {
                msg("Чунин корт вучуд надорад!!!"); return;
            }
            else
            {
                if (dataTable_kort.Rows[0]["active"].ToString()!="0")
                {
                    if (dataTable_kort.Rows[0]["id"].ToString() != this.id_kort)
                    {
                        msg("Чунин корт вучуд надорад!!!"); return;
                    }
                    else
                    {
                        id_kort = dataTable_kort.Rows[0]["id"].ToString();
                    }
                }
                else
                {
                    id_kort = dataTable_kort.Rows[0]["id"].ToString();
                }
               
            }

            string vrach = id_vrach_me;
            string room = id_room;
            string kord = id_kort;
           
            string up_date_client = "UPDATE client SET " +
                $"surname = '{surname}', " +
                $"name = '{name}', " +
                $"patromic = '{patramic}', " +
                $"birthday = str_to_date('{birthday}', '%d-%m-%Y'), " +
                $"id_sex = '{id_sex}', " +
                $"date_time_start =  str_to_date('{datetime_start}', '%m.%d.%Y %H:%i'), " +
                $"date_time_end = str_to_date('{datetime_end}', '%m.%d.%Y %H:%i'), " +
                $"money = '{money}', " +
                $"nuber_money = '{number_money}'," +
                $"comment_money = '{comment_money}', " +
                $"id_varch = '{vrach}', " +
                $"id_room = '{id_room}', " +
                $"id_kort = '{id_kort}', " +
                $"is_for_vrach = '{is_for_vrach}' " +
                $"WHERE id = '{id}'";

            if (surname == "") { msg("Шумо насаби муштариро дохил накардед!"); return; }
            else if (name == "") { msg("Шумо номи муштариро дохил накардед!"); return; }

            else if (vrach == "") { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            else if (room == "") { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            else if (kord == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            else if (surname != "" && name != "" && id_sex != "" && money != "" && vrach != "" && room != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(up_date_client);
                if (result == 500)
                {
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Шумо бо мувафақият муштариро иваз намудед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (current_id_room!=id_room)
                    {
                        string sql_plus_room = $"update room SET count_per = count_per +1  where id = '{id_room}' ";
                        sqlConfiguration.sqlSelectQuery(sql_plus_room);
                    }
                    else
                    {
                        string sql_plus_room = $"update room SET count_per = count_per -1  where id = '{current_id_room}' ";
                        sqlConfiguration.sqlSelectQuery(sql_plus_room);
                    }
                   

                    string sql_check_active = $"SELECT * FROM obigarm.room where id = '{id_room}'; ";
                    DataTable data_table_check = sqlConfiguration.sqlSelectQuery(sql_check_active);


                    if (data_table_check.Rows[0]["max_per"].ToString() == data_table_check.Rows[0]["count_per"].ToString())
                    {
                        string _room_sql = $"update room SET active = '1' where id = {id_room}";
                        sqlConfiguration.sqlSelectQuery(_room_sql);
                    }
                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql);

                    if (currebt_id_vrach_me!=id_vrach_me)
                    {
                        string sql = $"update users SET summa_cliet = summa_cliet + 1 where id = '{id_vrach_me}';";
                        sqlConfiguration.sqlSelectQuery(sql);
                    }
                    else{
                        string sql = $"update users SET summa_cliet = summa_cliet - 1 where id = '{currebt_id_vrach_me}';";
                        sqlConfiguration.sqlSelectQuery(sql);
                    }
                    
                    clear_all();
                    this.Close();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updateClient(id_client);
        }

      

        private void radio_no_money_Click(object sender, EventArgs e)
        {
            money_change(0);
        }

        private void radio_is_money_Click(object sender, EventArgs e)
        {
            money_change(1);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inser_docrot_Click(object sender, EventArgs e)
        {
            ListVrach listVrach = new ListVrach(this);
            listVrach.ShowDialog();
            txt_name_doctor.Text = name_vrach_;
        }

        private void btn_insert_room_Click(object sender, EventArgs e)
        {
            ListRoom listRoom = new ListRoom(this);
            listRoom.ShowDialog();
            txt_room.Text = name_room;
        }
    }
}
