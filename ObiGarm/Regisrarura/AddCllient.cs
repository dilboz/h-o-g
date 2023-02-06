using InventorySystem1._0.Includes;
using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura.Arkhiv;
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
        private readonly ListArkhiv listArkhiv;
        private readonly ArkhivForm arkhivForm;
        private string id_client;
        private string txt_button;

       

        public AddCllient(ArkhivForm arkhivForm, string id_client, string txt_button)
        {
            InitializeComponent();

            this.arkhivForm = arkhivForm;
            this.id_client = id_client;
            this.txt_button = txt_button;

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

        public AddCllient(ListArkhiv listArkhiv, string id_client, string txt_button)
        {
            InitializeComponent();

            this.listArkhiv = listArkhiv;
            this.id_client = id_client;
            this.txt_button = txt_button;

            date_first_dey.Value = DateTime.Now;
            date_end_dey.Value = DateTime.Now;

        }

        void setTextTotextbox(string id)
        {
            DataTable table_selecte_client = sqlConfiguration.sqlSelectQuery($"select * from client where id = '{id}';");

            if (listArkhiv!=null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {
                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString() + " " + table_selecte_client.Rows[0]["patromic"].ToString();
                    txt_year_burthday.Value = Decimal.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString());

                    if (table_selecte_client.Rows[0]["id_sex"].ToString() != "")
                    {
                        com_sex.Text = SettingsDatabase.setNmaeSexToTextbox(table_selecte_client.Rows[0]["id_sex"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_county"].ToString() != "")
                    {
                        combo_country.Text = SettingsDatabase.setNmaeCountryToTextbox(table_selecte_client.Rows[0]["id_county"].ToString());
                    }
                    if (table_selecte_client.Rows[0]["id_province"].ToString() != "")
                    {
                        combo_province.Text = SettingsDatabase.setNmaeProvinceToTextbox(table_selecte_client.Rows[0]["id_province"].ToString());
                    }

                    txt_count_dey.Text = table_selecte_client.Rows[0]["count_day_to_arkhiv"].ToString();
                    txt_count_dey.Enabled = false;

                    //date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString());
                    date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString()).AddDays(double.Parse(txt_count_dey.Text)-1);                    

                    //txt_count_dey.Text = (date_end_dey.Value - date_end_dey.Value).TotalDays.ToString();

                    //if (table_selecte_client.Rows[0]["id_varch"].ToString() != "")
                    //{
                    //    id_vrach = table_selecte_client.Rows[0]["id_varch"].ToString();
                    //    name_doctor = txt_name_doctor.Text = SettingsDatabase.setNmaeVrachToTextbox(table_selecte_client.Rows[0]["id_varch"].ToString());
                    //}

                    //if (table_selecte_client.Rows[0]["id_room"].ToString() != "")
                    //{
                    //    id_room = table_selecte_client.Rows[0]["id_room"].ToString();
                    //    name_room = txt_room.Text = SettingsDatabase.setNmaeRoomToTextbox(table_selecte_client.Rows[0]["id_room"].ToString());
                    //}

                    //if (table_selecte_client.Rows[0]["id_type_money"].ToString() != "")
                    //{
                    //    combo_country.Text = SettingsDatabase.setNmaeTypeMoneyToTextbox(table_selecte_client.Rows[0]["id_type_money"].ToString());
                    //}

                    txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();
                    //txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();

                    //if (table_selecte_client.Rows[0]["id_kort"].ToString() != "")
                    //{
                    //    id_kort = table_selecte_client.Rows[0]["id_kort"].ToString();
                    //    txt_kort.Text = SettingsDatabase.setNmaeKodKortToTextbox(table_selecte_client.Rows[0]["id_kort"].ToString());
                    //}
                }
                else
                {
                    MessageBox.Show("Ханоги ҳангоми ёфтани текст");
                }
            }
            if (arkhivForm != null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {
                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString() + " " + table_selecte_client.Rows[0]["patromic"].ToString();
                    txt_year_burthday.Value = Decimal.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString());

                    if (table_selecte_client.Rows[0]["id_sex"].ToString() != "")
                    {
                        com_sex.Text = SettingsDatabase.setNmaeSexToTextbox(table_selecte_client.Rows[0]["id_sex"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_county"].ToString() != "")
                    {
                        combo_country.Text = SettingsDatabase.setNmaeCountryToTextbox(table_selecte_client.Rows[0]["id_county"].ToString());
                    }
                    if (table_selecte_client.Rows[0]["id_province"].ToString() != "")
                    {
                        combo_province.Text = SettingsDatabase.setNmaeProvinceToTextbox(table_selecte_client.Rows[0]["id_province"].ToString());
                    }

                    //txt_count_dey.Text = table_selecte_client.Rows[0]["count_day_to_arkhiv"].ToString();
                    //txt_count_dey.Enabled = false;

                    //date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString());
                    //date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString()).AddDays(double.Parse(txt_count_dey.Text) - 1);

                    //txt_count_dey.Text = (date_end_dey.Value - date_end_dey.Value).TotalDays.ToString();

                    //if (table_selecte_client.Rows[0]["id_varch"].ToString() != "")
                    //{
                    //    id_vrach = table_selecte_client.Rows[0]["id_varch"].ToString();
                    //    name_doctor = txt_name_doctor.Text = SettingsDatabase.setNmaeVrachToTextbox(table_selecte_client.Rows[0]["id_varch"].ToString());
                    //}

                    //if (table_selecte_client.Rows[0]["id_room"].ToString() != "")
                    //{
                    //    id_room = table_selecte_client.Rows[0]["id_room"].ToString();
                    //    name_room = txt_room.Text = SettingsDatabase.setNmaeRoomToTextbox(table_selecte_client.Rows[0]["id_room"].ToString());
                    //}

                    //if (table_selecte_client.Rows[0]["id_type_money"].ToString() != "")
                    //{
                    //    combo_country.Text = SettingsDatabase.setNmaeTypeMoneyToTextbox(table_selecte_client.Rows[0]["id_type_money"].ToString());
                    //}

                    txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();
                    txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();

                    //if (table_selecte_client.Rows[0]["id_kort"].ToString() != "")
                    //{
                    //    id_kort = table_selecte_client.Rows[0]["id_kort"].ToString();
                    //    txt_kort.Text = SettingsDatabase.setNmaeKodKortToTextbox(table_selecte_client.Rows[0]["id_kort"].ToString());
                    //}
                }
                else
                {
                    MessageBox.Show("Ханоги ҳангоми ёфтани текст");
                }
            }
            if (isClient!=null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {
                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString() + " " + table_selecte_client.Rows[0]["patromic"].ToString();
                    txt_year_burthday.Value = Decimal.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString());

                    if (table_selecte_client.Rows[0]["id_sex"].ToString() != "")
                    {
                        com_sex.Text = SettingsDatabase.setNmaeSexToTextbox(table_selecte_client.Rows[0]["id_sex"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_county"].ToString() != "")
                    {
                        combo_country.Text = SettingsDatabase.setNmaeCountryToTextbox(table_selecte_client.Rows[0]["id_county"].ToString());
                    }
                    if (table_selecte_client.Rows[0]["id_province"].ToString() != "")
                    {
                        combo_province.Text = SettingsDatabase.setNmaeProvinceToTextbox(table_selecte_client.Rows[0]["id_province"].ToString());
                    }

                    date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString());
                    date_end_dey.Value = DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString());

                    txt_count_dey.Text =Convert.ToString(Convert.ToInt32((date_end_dey.Value - date_first_dey.Value).TotalDays));

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
                }
                else
                {
                    MessageBox.Show("Ханоги ҳангоми ёфтани текст");
                }
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

            string id_province;
            if (combo_province.Text!="")
            {
                id_province = combo_province.SelectedValue.ToString();

            }
            else
            {
                id_province = "9";
            }

            string datetime_start = date_first_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");


            string vrach_id = id_vrach;
            string room_id = id_room;

            string type_money = combo_type_money.SelectedValue.ToString();
            string number_money = txt_number_money.Text;
            string number_order = txt_number_order.Text;

            if (number_order == "" || number_order == null)
            {
                number_order = "0";
            }
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


            if (listArkhiv!=null)
            {
                int count =Convert.ToInt32((date_end_dey.Value - date_first_dey.Value).TotalDays)+1;
                if (txt_count_dey.Text!= count.ToString())
                {
                    MessageBox.Show("Шумо наметавонед муштариро кушоед \nШумо рузро хато интихоб кардед!");
                    return;
                }
            }

            //txt_kort.Text = sql_add_client;
            if (surname == "" ) { msg("Шумо насаби муштариро дохил накардед!"); return; }
            else if (name == "" ) { msg("Шумо номи муштариро дохил накардед!"); return; }
            else if (vrach_id == "" || vrach_id == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            else if (room_id == "" || room_id == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            else if (number_money == null || number_money == "") { number_money = "0"; }
            else if (kord == "" ) { msg("Шумо ба муштари корт интихоб накардед!"); return; }

            else if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {
                    msg("Шумо бо мувафақият муштариро сабт намудед!");

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
                    
                    if (isClient!=null)
                    {
                        //txt_full_name.Text = sql_add_client;
                        this.isClient.display();
                        this.Close();
                    }

                    if (listArkhiv != null)
                    {
                        string sqlDeleteAdmin = $"update client set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id_client + "'";
                        int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                        listArkhiv.click_home();
                        this.Close();
                    }

                    if (arkhivForm != null)
                    {
                        arkhivForm.click_home();
                        this.Close();
                    }

                    clear_all();
                }
            }
        }

        void editClient(string id_client)
        {
            

            string name = "", surname = "", patramic = "";
            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 3) patramic = split_full_name[i];
            }

            string year_birthday = txt_year_burthday.Value.ToString();
            string id_sex = com_sex.SelectedValue.ToString();
            string id_country = combo_country.SelectedValue.ToString();
            string id_province;
            if (combo_province.Text != "")
            {
                id_province = combo_province.SelectedValue.ToString();

            }
            else
            {
                id_province = "9";
            }

            string datetime_start = date_first_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");
            string datetime_end = date_end_dey.Value.ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");


            string vrach_id = id_vrach;
            string room_id = id_room;

            string type_money = combo_country.SelectedValue.ToString();

            string number_money = txt_number_money.Text;
            string number_order = txt_number_order.Text;

            string kord = id_kort;

            if (number_order == "" || number_order == null)
            {
                number_order = "0";
            }

            txt_kort.Enabled = false;

            string sql_add_client = "UPDATE client SET " +
              $"surname='{surname}', name='{name}', patromic='{patramic}', year_birthday='{year_birthday}', id_sex='{id_sex}', id_county='{id_country}', id_province='{id_province}', date_time_start=str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), date_time_end=str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), id_varch='{vrach_id}', id_room='{room_id}', id_type_money={type_money}, nuber_money='{number_money}', number_order='{number_order}', id_kort='{id_kort}' WHERE id = '{id_client}';  "; 


            //txt_kort.Text = sql_add_client;
            if (surname == "") { msg("Шумо насаби муштариро дохил накардед!"); return; }
            else if (name == "") { msg("Шумо номи муштариро дохил накардед!"); return; }
            else if (vrach_id == "" )  { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            else if (room_id == "" ) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
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

                    if (isClient != null)
                    {
                        txt_full_name.Text = sql_add_client;
                        this.isClient.display();
                        this.Close();
                    }
                    clear_all();
                }
            }
        }

        void check_kort(string txt_kod_kort)
        {
            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kod_kort}' and active ='0' and enable ='1';");

            if (dataTable_kort.Rows.Count == 0)
            {
                label_info_for_kort.BackColor = Color.Red;
                label_info_for_kort.Text = "Чунин корт вучуд надорад!!!";
            }
            else
            {
                label_info_for_kort.BackColor = Color.Green;
                label_info_for_kort.Text = "Чунин корт вучуд дорад!!!";

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
            if (btn_creat.Text=="Сохтан")
            {
                addClient();
            }
            if (btn_creat.Text == "Иваз кардан")
            {
                editClient(id_client);
            }
        }

        private void AddCllient_Shown(object sender, EventArgs e)
        {
            sqlConfiguration = new SqlConfiguration();

            loadItemsCombos();

            if (id_client!="" && txt_button== "Иваз кардан")
            {
                setTextTotextbox(id_client);
                btn_creat.Text = "Иваз кардан";
                return;
            }
            if (id_client != "")
            {
                setTextTotextbox(id_client);
                btn_creat.Text = "Сохтан";
                return;
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
            check_kort(txt_kort.Text);
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);
                txt_full_name.Focus();
                txt_kort.Focus();
                check_kort(txt_kort.Text);
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
                if (date_first_dey.Value > date_first_dey.Value.AddDays(double.Parse(txt_count_dey.Text) - 1))
                {
                    msg("Шумо аз рузи авалла хурд ё баробар интихоб карда наметавонед!");
                    return;
                }

                else date_end_dey.Value = date_first_dey.Value.AddDays(double.Parse(txt_count_dey.Text) - 1);
            }
            
        }

        private void combo_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayItemComboPtovince(combo_country.SelectedValue.ToString());
        }
    }
}
