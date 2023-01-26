using InventorySystem1._0.Includes;
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
    public partial class AddCllient : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        public string  name_doctor;
        public string id_vrach;
        
        public string name_room;
        public string id_room;

        private string id_kort;

        private readonly IsClient isClient;
        private string id_client;
        private string txt_button;

        bool erors = false;

        public AddCllient()
        {
            InitializeComponent();

            date_first_dey.Value = DateTime.Now;
            date_end_dey.Value = DateTime.Now;
        }

        public AddCllient(IsClient isClient, string id_client, string txt_button)
        {
            InitializeComponent();

            this.isClient = isClient;
            this.id_client = id_client;
            this.txt_button = txt_button;

            date_first_dey.Value = DateTime.Now;
            date_end_dey.Value = DateTime.Now;

        }

        void setTextTotextbox(string id)
        {
            DataTable table_selecte_client = sqlConfiguration.sqlSelectQuery($"select * from client where id = '{id}';");

            if (table_selecte_client.Rows.Count != 0)
            {
                txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString() + " " + table_selecte_client.Rows[0]["patromic"].ToString();
                txt_year_burthday.Value = Decimal.Parse( table_selecte_client.Rows[0]["nuber_money"].ToString());
                txt_year_burthday.Value = Decimal.Parse(table_selecte_client.Rows[0]["nuber_money"].ToString());

                if (table_selecte_client.Rows[0]["id_sex"].ToString() != "")
                {
                    com_sex.Text = SettingsDatabase.setNmaeSexToTextbox(table_selecte_client.Rows[0]["id_sex"].ToString());
                }

                if (table_selecte_client.Rows[0]["id_county"].ToString()!="")
                {
                    combo_country.Text = SettingsDatabase.setNmaeCountryToTextbox(table_selecte_client.Rows[0]["id_county"].ToString());
                }
                if (table_selecte_client.Rows[0]["id_province"].ToString() != "")
                {
                    combo_province.Text = SettingsDatabase.setNmaeProvinceToTextbox(table_selecte_client.Rows[0]["id_province"].ToString());
                }

                date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString());
                date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString());

                txt_count_dey.Text = (date_end_dey.Value- date_end_dey.Value).TotalDays.ToString();

                if (table_selecte_client.Rows[0]["id_varch"].ToString() != "")
                {
                   id_vrach = table_selecte_client.Rows[0]["id_varch"].ToString();
                   name_doctor = txt_name_doctor.Text = SettingsDatabase.setNmaeVrachToTextbox(table_selecte_client.Rows[0]["id_varch"].ToString());
                }

                if (table_selecte_client.Rows[0]["id_room"].ToString() != "")
                {
                   id_room = table_selecte_client.Rows[0]["id_room"].ToString();
                   name_room = txt_room.Text = SettingsDatabase.setNmaeRoomToTextbox(table_selecte_client.Rows[0]["id_room"].ToString());
                }

                if (table_selecte_client.Rows[0]["id_type_money"].ToString() != "")
                {
                    combo_country.Text = SettingsDatabase.setNmaeTypeMoneyToTextbox(table_selecte_client.Rows[0]["id_type_money"].ToString());
                }

                txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();
                txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();

                if (table_selecte_client.Rows[0]["id_kort"].ToString() != "")
                {
                    id_kort = table_selecte_client.Rows[0]["id_kort"].ToString();
                    txt_kort.Text = SettingsDatabase.setNmaeKodKortToTextbox(table_selecte_client.Rows[0]["id_kort"].ToString());
                }
                msg(name_doctor);
            }
            else
            {
                MessageBox.Show("Ханоги ҳангоми ёфтани текст");
            }
        }

        void loadItemsCombos()
        {
            string sql_sex = "select * from sex";
            sqlConfiguration.LoadCombo(sql_sex, "name", "id", com_sex);

            string sql_county = "SELECT * FROM country order by name;";
            sqlConfiguration.LoadCombo(sql_county, "name", "id", combo_country);

            displayItemComboPtovince(combo_country.SelectedValue.ToString());

            string sql_type_money = "select * from type_money";
            sqlConfiguration.LoadCombo(sql_type_money, "name", "id", combo_type_money);
        }

        void displayItemComboPtovince(string id)
        {
            string sql_province = $"SELECT * FROM province where id_country ='{id}';";
            sqlConfiguration.LoadCombo(sql_province, "name", "id", combo_province);

        }

        void msg(string messeg)
        {
            messDilalog.Text = messeg;
            messDilalog.Show();
        }

        void addClient()
        {
            string sql_add_client;

            string name ="", surname="", patramic="";
            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i==0)surname = split_full_name[i];
                if (i==1)name = split_full_name[i];
                if (i==3)patramic = split_full_name[i];
            }

            string year_birthday = txt_year_burthday.Value.ToString();
            string id_sex = com_sex.SelectedValue.ToString();
            string id_country = combo_country.SelectedValue.ToString();
            string id_province = combo_province.SelectedValue.ToString();

            string datetime_start = date_first_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            string vrach_id = id_vrach;
            string room_id = id_room;

            string type_money = combo_country.SelectedValue.ToString();
            string number_money = txt_number_money.Text;
            string number_order = txt_number_order.Text;

            string kord = id_kort;

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text}' and active ='0' and enable ='1';");

            if (dataTable_kort.Rows.Count == 0) 
            {
                msg("Чунин корт вучуд надорад!!!");
                return;
            }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();

           

           

            sql_add_client = sql_add_client = "insert into client (surname, name, patromic, year_birthday, id_sex, id_county, id_province, date_time_start, date_time_end, id_varch, id_room, id_type_money, nuber_money, number_order, id_kort, date_registration) " +
                                                         $"values('{surname}', '{name}', '{patramic}', '{year_birthday}', '{id_sex}', '{id_country}', '{id_province}',  str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), '{vrach_id}', '{room_id}', '{type_money}', '{number_money}', '{number_order}', '{id_kort}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";


            //txt_kort.Text = sql_add_client;
            if (surname == "") { msg("Шумо насаби муштариро дохил накардед!"); return; }
            else if (name == "") { msg("Шумо номи муштариро дохил накардед!"); return; }
            else if (vrach_id == "") { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            else if (room_id == "") { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            else if (kord == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }

            else if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_full_name.Text = sql_add_client;
                }
                else
                {
                    MessageBox.Show("Шумо бо мувафақият муштариро сабт намудед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string sql_plus_room = $"update room SET count_per = count_per +1  where id = '{id_room}' ";
                    sqlConfiguration.sqlSelectQuery(sql_plus_room);

                    string sql_check_active = $"SELECT * FROM room where id = '{id_room}'; ";
                    DataTable data_table_check = sqlConfiguration.sqlSelectQuery(sql_check_active);


                    if (data_table_check.Rows[0]["max_per"].ToString() == data_table_check.Rows[0]["count_per"].ToString())
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
            txt_full_name.Clear();
            txt_count_dey.Clear();
            txt_number_order.Clear();
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
            loadItemsCombos();

            if (id_client!="" && txt_button=="Иваз кардан")
            {
                setTextTotextbox(id_client);
            }
        }
        public static string CapitalizeFirstLetters(string sValue)
        {
            char[] array = sValue.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))                    
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }

            return new string(array);
        }

        private void txt_kort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; 
        }


        private void radio_is_money_CheckedChanged(object sender, EventArgs e)
        {
            btn_creat.Text = "Ба хазинадор фиристондан";
            txt_number_order.Enabled = false;
            txt_number_order.Text = "";
        }

        private void radio_no_money_CheckedChanged(object sender, EventArgs e)
        {
            btn_creat.Text = "Ба табиб фиристондан";
            txt_number_order.Enabled = true;
          
        }

        private void combo_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayItemComboPtovince(combo_country.SelectedValue.ToString());
        }

        private void date_end_dey_ValueChanged(object sender, EventArgs e)
        {
            DateTime start_date = date_first_dey.Value;
            DateTime end_date = date_end_dey.Value;

            int count = 0;
            while (start_date <= end_date)
            {
                count++;
                start_date = start_date.AddDays(1);
            }

            if (count == 0) msg("Шумо аз рузи авалла хурд ё баробар интихоб карда наметавонед!");
            txt_count_dey.Text = count.ToString();

        }

        private void txt_number_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_number_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void btn_сlear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_room_Click(object sender, EventArgs e)
        {
            if (id_room != "")
            { 
                ListRoom listRoom = new ListRoom(this, id_room);
                listRoom.ShowDialog();
                txt_room.Text = name_room;
            }
            else 
            { 
                ListRoom listRoom = new ListRoom(this, "");
                listRoom.ShowDialog();
                txt_room.Text = name_room;
            }
           
        }

        private void btn_inser_docrot_Click(object sender, EventArgs e)
        {
            ListVrach listVrach = new ListVrach(this);
            listVrach.ShowDialog();
            txt_name_doctor.Text = name_doctor;
        }

        private void txt_full_name_Leave(object sender, EventArgs e)
        {
            txt_full_name.Text = CapitalizeFirstLetters(txt_full_name.Text);
        }

        private void txt_kort_TextChange(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);
                txt_full_name.Focus();
                txt_kort.Focus();
            }
        }

        private void txt_count_dey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

            
        }

        private void txt_count_dey_Leave(object sender, EventArgs e)
        {
            if (txt_count_dey.Text!="")
            {
                if (date_first_dey.Value >= date_end_dey.Value.AddDays(double.Parse(txt_count_dey.Text))) msg("Шумо аз рузи авалла хурд ё баробар интихоб карда наметавонед!");

                else date_end_dey.Value = date_end_dey.Value.AddDays(double.Parse(txt_count_dey.Text));
            }
            
        }
    }
}
