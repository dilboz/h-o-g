using Bunifu.Json.Linq;
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

        public string name_doctor;
        public string id_vrach;

        private int currentCountDay = 0;

        private string currentID;

        public string name_room;
        public string id_room;

        private string id_kort;
        private string currentIDKort;

        private int curCountDayToArkhiv = 0;

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
        }

        public AddCllient(IsClient isClient, string id_client, string txt_button)
        {
            InitializeComponent();

            this.isClient = isClient;
            this.id_client = id_client;
            this.txt_button = txt_button;

        }

        public AddCllient(ListArkhiv listArkhiv, string id_client, string txt_button)
        {
            InitializeComponent();

            this.listArkhiv = listArkhiv;
            this.id_client = id_client;
            this.txt_button = txt_button;

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

        void setTextTotextbox(string id)
        {
            DataTable table_selecte_client = sqlConfiguration.sqlSelectQuery($"select * from client where id = '{id}';");

            if (isClient != null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {

                    currentID = table_selecte_client.Rows[0]["currents_id"].ToString();

                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString() 
                        + " " + table_selecte_client.Rows[0]["patromic"].ToString();
                    
                    txt_burthday.EditValue = DateTime.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString()).ToString("dd/MM/yyyy");

                    if (table_selecte_client.Rows[0]["id_sex"].ToString() != "")
                    {
                        com_sex.Text = SettingsDatabase.setNmaeSexToTextbox(table_selecte_client.Rows[0]["id_sex"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_county"].ToString() != "")
                    {
                        combo_country.Text = SettingsDatabase.setNmaeCountryToTextbox(table_selecte_client.Rows[0]["id_county"].ToString());
                    }
                    if (table_selecte_client.Rows[0]["id_province"].ToString() != "" )
                    {
                        combo_province.Text = SettingsDatabase.setNmaeProvinceToTextbox(table_selecte_client.Rows[0]["id_province"].ToString());
                    }



                    date_first_dey.EditValue = DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString()).ToString("dd/MM/yyyy");
                    date_end_dey.EditValue = DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString()).ToString("dd/MM/yyyy");

                    txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();

                    int countDay =Convert.ToInt32((DateTime.Parse(table_selecte_client.Rows[0]["date_time_end"].ToString())
                        - DateTime.Parse(table_selecte_client.Rows[0]["date_time_start"].ToString())).TotalDays)+1;

                    currentCountDay = countDay ;

                    txt_count_dey.Text = countDay.ToString();
                   
                    txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();

                    txt_money_for_one_day.Text = (int.Parse(txt_number_money.Text) / countDay).ToString();

                    //if (double.Parse(txt_count_dey.Text) > 0)
                    //    txt_number_money.Text = (double.Parse(txt_count_dey.Text) * double.Parse(txt_money_for_one_day.Text)).ToString();

                    txt_number_fon.Text = table_selecte_client.Rows[0]["nuber_phon"].ToString();

                    if (table_selecte_client.Rows[0]["id_varch"].ToString() != "")
                    {
                        id_vrach = table_selecte_client.Rows[0]["id_varch"].ToString();
                        combo_doctor.Text =  SettingsDatabase.setNmaeVrachToTextbox(table_selecte_client.Rows[0]["id_varch"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_room"].ToString() != "")
                    {
                        id_room = table_selecte_client.Rows[0]["id_room"].ToString();
                        combo_room.Text = SettingsDatabase.setNmaeRoomToTextbox(table_selecte_client.Rows[0]["id_room"].ToString());
                    }

                    if (table_selecte_client.Rows[0]["id_type_money"].ToString() != "")
                    {
                        combo_type_money.Text = SettingsDatabase.setNmaeTypeMoneyToTextbox(table_selecte_client.Rows[0]["id_type_money"].ToString());
                    }

                    txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();

                    if (table_selecte_client.Rows[0]["id_kort"].ToString() != "")
                    {
                        id_kort = currentIDKort = table_selecte_client.Rows[0]["id_kort"].ToString();
                        txt_kort.Text = SettingsDatabase.setNmaeKodKortToTextbox(table_selecte_client.Rows[0]["id_kort"].ToString());
                    }


                    label_info_for_kort.Visible = false;
                }
                else
                {
                    MessageBox.Show("Ханоги ҳангоми ёфтани текст");
                }
            }

            if (listArkhiv!=null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {

                    currentID = table_selecte_client.Rows[0]["currents_id"].ToString();

                    currentID = currentID + $"{id}, ";

                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString()
                        + " " + table_selecte_client.Rows[0]["patromic"].ToString();

                    txt_burthday.EditValue = DateTime.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString()).ToString("dd/MM/yyyy");

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

                    curCountDayToArkhiv = int.Parse(table_selecte_client.Rows[0]["count_day_to_arkhiv"].ToString());

                    txt_count_dey.Text = table_selecte_client.Rows[0]["count_day_to_arkhiv"].ToString();

                    date_end_dey.EditValue = DateTime.Now.AddDays(curCountDayToArkhiv-1).ToString("dd/MM/yyyy");

                    labelInfoForBlockDay.Text = $"Миқдори рузҳое, ки Шумо бояд интихоб кунед руз {curCountDayToArkhiv} аст";

                    txt_number_fon.Text = table_selecte_client.Rows[0]["nuber_phon"].ToString();
                   

                    txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();

                    if (table_selecte_client.Rows[0]["id_type_money"].ToString() != "")
                    {
                        combo_type_money.Text = SettingsDatabase.setNmaeTypeMoneyToTextbox(table_selecte_client.Rows[0]["id_type_money"].ToString());
                        combo_type_money.Enabled = false;
                    }

                    txt_money_for_one_day.Text = "0";
                    txt_money_for_one_day.Enabled = false;


                    txt_number_money.Text = "0";
                    txt_number_money.Enabled = false;

                    
                }
                else
                {
                    MessageBox.Show("Ханоги ҳангоми ёфтани текст");
                }
            }

            if (arkhivForm!=null)
            {
                if (table_selecte_client.Rows.Count != 0)
                {

                    currentID = table_selecte_client.Rows[0]["currents_id"].ToString();

                    currentID = currentID + $"{id}, ";

                    txt_full_name.Text = table_selecte_client.Rows[0]["surname"].ToString() + " " + table_selecte_client.Rows[0]["name"].ToString()
                        + " " + table_selecte_client.Rows[0]["patromic"].ToString();

                    txt_burthday.EditValue = DateTime.Parse(table_selecte_client.Rows[0]["year_birthday"].ToString()).ToString("dd/MM/yyyy");

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


                    txt_number_fon.Text = table_selecte_client.Rows[0]["nuber_phon"].ToString();

                    txt_number_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();


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
            sqlConfiguration.LoadComboDE(sql_sex, "name", "id", com_sex);


            string sql_county = "SELECT * FROM country order by name;";
            sqlConfiguration.LoadComboDE(sql_county, "name", "id", combo_country);

            string sql_province = $"SELECT * FROM province;";
            sqlConfiguration.LoadComboDE(sql_province, "name", "id", combo_province);

            string sql_type_money = "select * from type_money";
            sqlConfiguration.LoadComboDE(sql_type_money, "name", "id", combo_type_money);

            string sql_doctor = "select users.id, concat(users.name, ' ', users.surname, ' (', case when client.enable = 1 and client.deleted is null then 1 else 0 end, ')' ) as name  " +
                "from users " +
                "left join client on client.id_varch= users.id " +
                "where users.point=3 and users.enable=1 and users.deleted is null " +
                "group by users.id " +
                "order by count(client.id);";
            sqlConfiguration.LoadComboDE(sql_doctor, "name", "id", combo_doctor);

            string sql_room = "select r.id, concat(f.name, ' ', r.name) as 'name_room', " +
                "concat(sum(case when c.enable = 1 and c.deleted is null then 1 else 0 end),'/', r.max_per, ' (', sum(case when c.id_sex = 1 and c.enable = 1 and c.deleted is null then 1 else 0 end), '-мард,',' ',  sum(case when c.id_sex = 2 and c.enable = 1 and c.deleted is null then 1 else 0 end),'-зан', ')', " +
                "' (Наҳорӣ -', TIME_FORMAT(r.breakfast, '%h:%i') , ' Нисфирӯзӣ -', TIME_FORMAT(r.lunch, '%h:%i'), ' Бегоҳрӯзӣ -', time_format(r.dinner, '%h:%i'), ' )'  ) as 'info_for_per' , sum(case when c.enable = 1 and c.deleted is null then 1 else 0 end) as count_clients, r.max_per as max_per " +
                "from room r " +
                "left join client c on (c.id_room = r.id) " +
                "join frame f on (r.id_freme  = f.id) " +
                "left join sex s on (c.id_sex = s.id) " +
                "group by r.id, r.name, f.name " +
                "order by count_clients;";
            sqlConfiguration.LoadComboDE(sql_room, "name_room", "id", combo_room);
        }

        void displayItemComboPtovince(string id)
        {
            string sql_province = $"SELECT * FROM province where id_country ='{id}';";
            sqlConfiguration.LoadComboDE(sql_province, "name", "id", combo_province);

        }

        void msg(string messeg) { messDilalog.Text = messeg; messDilalog.Show();}

        void addClient()
        {
            string sql_add_client,
                name = "", surname = "", patramic = "",
                year_birthday,
                id_sex,
                id_country,
                id_province,
                nuber_phon,
                datetime_start,
                datetime_end,
                vrach_id = "", room_id = "",
                type_money, number_money="", number_order,
                kord ="";

            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 2) patramic = split_full_name[i];
            }

            if (name == "" || surname == "") { msg("Шумо Насаби ё номи муштариро дохил накардед!"); return; }

            if (txt_burthday.Text == "") { msg("Шумо руз, моҳ ва соли таваллуди муштариро дохил накардед!"); return; }
            year_birthday = DateTime.Parse(txt_burthday.Text).ToString("yyyy-MM-dd");

            if (com_sex.EditValue == null) { msg("Шумо ҷинси муштариро интихоб накардед!"); return; }
            id_sex = com_sex.EditValue.ToString();

            if (combo_country.EditValue == null) { msg("Шумо кишвари муштариро интихоб накардед!"); return; }
            id_country = combo_country.EditValue.ToString();

            if (combo_province.EditValue != null) id_province = combo_province.EditValue.ToString();
            else id_province = "null";

            //if (txt_number_fon.Text == "") {msg("Шумо кишвари муштариро интихоб накардед!"); return; };
            nuber_phon = txt_number_fon.Text;

            if (date_first_dey.Text == "") { msg("Шумо аз кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_start =DateTime.Parse( date_first_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");

            if (date_first_dey.Text == "") { msg("Шумо то кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_end = DateTime.Parse(date_end_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            if (combo_type_money.EditValue == null) { msg("Шумо ба муштари намуди роҳхатро интихоб накардед!"); return; }
            type_money = combo_type_money.EditValue.ToString();

            if (txt_number_money.Text == null || txt_number_money.Text == "") { number_money = "0"; }
            else number_money = txt_number_money.Text;

            if (txt_number_order.Text == null || txt_number_order.Text == "") { number_order = "0"; }
            else number_order = txt_number_order.Text;

            if (combo_doctor.EditValue == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            vrach_id = id_vrach =combo_doctor.EditValue.ToString();

            if (combo_room.EditValue == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            room_id = id_room = combo_room.EditValue.ToString();

            if (id_kort == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            kord = id_kort;

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text.PadLeft(10,'0')}' and active ='0' and enable ='1';");
            if (dataTable_kort.Rows.Count == 0) { msg("Чунин корт вучуд надорад!!!"); return; }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();

            sql_add_client = sql_add_client = "insert into client (surname, name, patromic, year_birthday, id_sex, id_county, id_province, nuber_phon, date_time_start, date_time_end, id_varch, id_room, id_type_money, nuber_money, number_order, id_kort, date_registration ) " +
                                                         $"values('{surname}', '{name}', '{patramic}', '{year_birthday}', '{id_sex}', '{id_country}', {id_province}, '{nuber_phon}',  str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), '{vrach_id}', '{room_id}', '{type_money}', '{number_money}', '{number_order}', '{id_kort}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' );";


            if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {
                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql); Console.WriteLine($"Корт бан шуд бо раками  {id_kort}");

                    if (isClient != null)
                    {
                        this.isClient.display(); Console.WriteLine("Бо мувафаатият сабт шуд");
                        this.Close();
                    }
                }
            }
        }

        void editClient(string id_client)
        {
            string sql_add_client,
                name = "", surname = "", patramic = "",
                year_birthday,
                id_sex,
                id_country,
                id_province,
                nuber_phon,
                datetime_start,
                datetime_end,
                vrach_id = "", room_id = "",
                type_money, number_money = "", number_order,
                kord = "";

        string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 2) patramic = split_full_name[i];
            }

            if (name == "" || surname == "") { msg("Шумо Насаби ё номи муштариро дохил накардед!"); return; }

            if (txt_burthday.Text == "") { msg("Шумо руз, моҳ ва соли таваллуди муштариро дохил накардед!"); return; }
            year_birthday = DateTime.Parse(txt_burthday.Text).ToString("yyyy-MM-dd");

            if (com_sex.EditValue == null) { msg("Шумо ҷинси муштариро интихоб накардед!"); return; }
            id_sex = com_sex.EditValue.ToString();

            if (combo_country.EditValue == null) { msg("Шумо кишвари муштариро интихоб накардед!"); return; }
            id_country = combo_country.EditValue.ToString();

            if (combo_province.EditValue != null) id_province = combo_province.EditValue.ToString();
            else id_province = "null";


            //if (txt_number_fon.Text == "") {msg("Шумо кишвари муштариро интихоб накардед!"); return; };
            nuber_phon = txt_number_fon.Text;

            if (date_first_dey.Text == "") { msg("Шумо аз кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_start = DateTime.Parse(date_first_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");

            if (date_first_dey.Text == "") { msg("Шумо то кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_end = DateTime.Parse(date_end_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            if (combo_type_money.EditValue == null) { msg("Шумо ба муштари намуди роҳхатро интихоб накардед!"); return; }
            type_money = combo_type_money.EditValue.ToString();

            if (txt_number_money.Text == null || txt_number_money.Text == "") { number_money = "0"; }
            else number_money = txt_number_money.Text;

            if (txt_number_order.Text == null || txt_number_order.Text == "") { number_order = "0"; }
            else number_order = txt_number_order.Text;

            if (combo_doctor.EditValue == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            vrach_id = id_vrach = combo_doctor.EditValue.ToString();

            if (combo_room.EditValue == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            room_id = id_room = combo_room.EditValue.ToString();

            if (id_kort == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            kord = id_kort;

            SettingsDatabase.setFaleActiveKort(currentIDKort);

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text.PadLeft(10, '0')}' and active ='0' and enable ='1';");
            if (dataTable_kort.Rows.Count == 0) { msg("Чунин корт вучуд надорад!!!"); return; }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();

            SettingsDatabase.setTrueActiveKort(currentIDKort);


            if (id_kort != currentIDKort)
                SettingsDatabase.setFaleActiveKort(currentIDKort);

             sql_add_client = "UPDATE client SET " +
              $"surname='{surname}', name='{name}', patromic='{patramic}', year_birthday='{year_birthday}', id_sex='{id_sex}', id_county='{id_country}', id_province={id_province}, nuber_phon = '{nuber_phon}', date_time_start=str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), date_time_end=str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), id_varch='{vrach_id}', id_room='{room_id}', id_type_money={type_money}, nuber_money='{number_money}', number_order='{number_order}', id_kort='{id_kort}' WHERE id = '{id_client}';  ";


            if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {

                    if (id_kort != currentIDKort) { SettingsDatabase.setFaleActiveKort(currentIDKort); Console.WriteLine("kort ba yakdigar monand nabudan!"); }                 

                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql); Console.WriteLine($"Корт бан шуд бо раками  {id_kort}");

                    if (isClient != null)
                    {
                        this.isClient.display(); Console.WriteLine("Бо мувафаатият сабт шуд");
                        this.Close();
                    }
                }
            }
        }

        void blockClient(string id_client)
        {
            string sql_add_client,
                 name = "", surname = "", patramic = "",
                 year_birthday,
                 id_sex,
                 id_country,
                 id_province,
                 nuber_phon,
                 datetime_start,
                 datetime_end,
                 vrach_id = "", room_id = "",
                 type_money, number_money = "", number_order,
                 kord = "";

            int dayForArchiv = 0;

            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 2) patramic = split_full_name[i];
            }

            if (name == "" || surname == "") { msg("Шумо Насаби ё номи муштариро дохил накардед!"); return; }

            if (txt_burthday.Text == "") { msg("Шумо руз, моҳ ва соли таваллуди муштариро дохил накардед!"); return; }
            year_birthday = DateTime.Parse(txt_burthday.Text).ToString("yyyy-MM-dd");

            if (com_sex.EditValue == null) { msg("Шумо ҷинси муштариро интихоб накардед!"); return; }
            id_sex = com_sex.EditValue.ToString();

            if (combo_country.EditValue == null) { msg("Шумо кишвари муштариро интихоб накардед!"); return; }
            id_country = combo_country.EditValue.ToString();

            if (combo_province.EditValue != null) id_province = combo_province.EditValue.ToString();
            else id_province = "null";


            //if (txt_number_fon.Text == "") {msg("Шумо кишвари муштариро интихоб накардед!"); return; };
            nuber_phon = txt_number_fon.Text;

            if (date_first_dey.Text == "") { msg("Шумо аз кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_start = DateTime.Parse(date_first_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");

            if (date_first_dey.Text == "") { msg("Шумо то кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_end = DateTime.Parse(date_end_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            if (combo_type_money.EditValue == null) { msg("Шумо ба муштари намуди роҳхатро интихоб накардед!"); return; }
            type_money = combo_type_money.EditValue.ToString();

            if (txt_number_money.Text == null || txt_number_money.Text == "") { number_money = "0"; }
            else number_money = txt_number_money.Text;

            if (txt_number_order.Text == null || txt_number_order.Text == "") { number_order = "0"; }
            else number_order = txt_number_order.Text;

            if (combo_doctor.EditValue == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            vrach_id = id_vrach = combo_doctor.EditValue.ToString();

            if (combo_room.EditValue == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            room_id = id_room = combo_room.EditValue.ToString();

            if (id_kort == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            kord = id_kort;

            SettingsDatabase.setFaleActiveKort(currentIDKort);

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text.PadLeft(10, '0')}' and active ='0' and enable ='1';");
            if (dataTable_kort.Rows.Count == 0) { msg("Чунин корт вучуд надорад!!!"); return; }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();


            if (currentCountDay - int.Parse(txt_count_dey.Text)>0 && currentCountDay - int.Parse(txt_count_dey.Text)<currentCountDay)
            {
                dayForArchiv = currentCountDay - int.Parse(txt_count_dey.Text);
                if (btn_creat.Text == "Махкамкунии руз")
                {
                    labelInfoForBlockDay.Visible = true;
                    labelInfoForBlockDay.Text = $"Шумо {currentCountDay - int.Parse(txt_count_dey.Text)} рузи боқимондаи муштариро макам доред!";
                }
            }
            else
            { msg("Бо чунин руз, рузи бокимондаи муштариро махкам карда наметавонед!"); return; }


            if (id_kort != currentIDKort)
                SettingsDatabase.setFaleActiveKort(currentIDKort);



            sql_add_client = "UPDATE client SET " +
             $"surname='{surname}', name='{name}', patromic='{patramic}', year_birthday='{year_birthday}', id_sex='{id_sex}', id_county='{id_country}', id_province={id_province}, nuber_phon = '{nuber_phon}', date_time_start=str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), date_time_end=str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), count_day_to_arkhiv='{dayForArchiv}', id_varch='{vrach_id}', id_room='{room_id}', id_type_money={type_money}, nuber_money='{number_money}', number_order='{number_order}', id_kort='{id_kort}', enable='0' WHERE id = '{id_client}';  ";


            if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {

                    if (id_kort != currentIDKort) { SettingsDatabase.setFaleActiveKort(currentIDKort); Console.WriteLine("kort ba yakdigar monand nabudan!"); }

                    

                    if (isClient != null)
                    {
                        this.isClient.display(); Console.WriteLine("Бо мувафаатият сабт шуд");
                        this.Close();
                    }
                }
            }
        }

        void notBlockClient()
        {
            string sql_add_client,
               name = "", surname = "", patramic = "",
               year_birthday,
               id_sex,
               id_country,
               id_province,
               nuber_phon,
               datetime_start,
               datetime_end,
               vrach_id = "", room_id = "",
               type_money, number_money = "", number_order,
               kord = "";

            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            if (curCountDayToArkhiv!= int.Parse(txt_count_dey.Text))
            { msg($"Шумо рузро ба {curCountDayToArkhiv} руз баробар интихоб накардед"); return; }


            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 2) patramic = split_full_name[i];
            }

            if (name == "" || surname == "") { msg("Шумо Насаби ё номи муштариро дохил накардед!"); return; }

            if (txt_burthday.Text == "") { msg("Шумо руз, моҳ ва соли таваллуди муштариро дохил накардед!"); return; }
            year_birthday = DateTime.Parse(txt_burthday.Text).ToString("yyyy-MM-dd");

            if (com_sex.EditValue == null) { msg("Шумо ҷинси муштариро интихоб накардед!"); return; }
            id_sex = com_sex.EditValue.ToString();

            if (combo_country.EditValue == null) { msg("Шумо кишвари муштариро интихоб накардед!"); return; }
            id_country = combo_country.EditValue.ToString();

            if (combo_province.EditValue != null) id_province = combo_province.EditValue.ToString();
            else id_province = "null";

            //if (txt_number_fon.Text == "") {msg("Шумо кишвари муштариро интихоб накардед!"); return; };
            nuber_phon = txt_number_fon.Text;

            if (date_first_dey.Text == "") { msg("Шумо аз кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_start = DateTime.Parse(date_first_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");

            if (date_first_dey.Text == "") { msg("Шумо то кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_end = DateTime.Parse(date_end_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            if (combo_type_money.EditValue == null) { msg("Шумо ба муштари намуди роҳхатро интихоб накардед!"); return; }
            type_money = combo_type_money.EditValue.ToString();

            if (txt_number_money.Text == null || txt_number_money.Text == "") { number_money = "0"; }
            else number_money = txt_number_money.Text;

            if (txt_number_order.Text == null || txt_number_order.Text == "") { number_order = "0"; }
            else number_order = txt_number_order.Text;

            if (combo_doctor.EditValue == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            vrach_id = id_vrach = combo_doctor.EditValue.ToString();

            if (combo_room.EditValue == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            room_id = id_room = combo_room.EditValue.ToString();

            if (id_kort == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            kord = id_kort;

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text.PadLeft(10, '0')}' and active ='0' and enable ='1';");
            if (dataTable_kort.Rows.Count == 0) { msg("Чунин корт вучуд надорад!!!"); return; }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();

            sql_add_client = sql_add_client = "insert into client (surname, name, patromic, year_birthday, id_sex, id_county, id_province, nuber_phon, date_time_start, date_time_end, id_varch, id_room, id_type_money, nuber_money, number_order, id_kort, date_registration, currents_id) " +
                                                         $"values('{surname}', '{name}', '{patramic}', '{year_birthday}', '{id_sex}', '{id_country}', {id_province}, '{nuber_phon}',  str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), '{vrach_id}', '{room_id}', '{type_money}', '{number_money}', '{number_order}', '{id_kort}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{currentID}');";


            if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {
                    SettingsDatabase.DeletedClient(id_client);

                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql); Console.WriteLine($"Корт бан шуд бо раками  {id_kort}");

                    if (listArkhiv != null)
                    {
                        this.listArkhiv.display(); Console.WriteLine("Бо мувафаатият сабт шуд");
                        this.listArkhiv.click_home();
                        this.Close();
                    }
                }
            }
        }

        void copyClient()
        {
            string sql_add_client,
               name = "", surname = "", patramic = "",
               year_birthday,
               id_sex,
               id_country,
               id_province,
               nuber_phon,
               datetime_start,
               datetime_end,
               vrach_id = "", room_id = "",
               type_money, number_money = "", number_order,
               kord = "";

            string[] split_full_name = txt_full_name.Text.Split(new char[] { ' ' });

            for (int i = 0; i < split_full_name.Length; i++)
            {
                if (i == 0) surname = split_full_name[i];
                if (i == 1) name = split_full_name[i];
                if (i == 2) patramic = split_full_name[i];
            }

            if (name == "" || surname == "") { msg("Шумо Насаби ё номи муштариро дохил накардед!"); return; }

            if (txt_burthday.Text == "") { msg("Шумо руз, моҳ ва соли таваллуди муштариро дохил накардед!"); return; }
            year_birthday = DateTime.Parse(txt_burthday.Text).ToString("yyyy-MM-dd");

            if (com_sex.EditValue == null) { msg("Шумо ҷинси муштариро интихоб накардед!"); return; }
            id_sex = com_sex.EditValue.ToString();

            if (combo_country.EditValue == null) { msg("Шумо кишвари муштариро интихоб накардед!"); return; }
            id_country = combo_country.EditValue.ToString();

            if (combo_province.EditValue != null) id_province = combo_province.EditValue.ToString();
            else id_province = "null";

            //if (txt_number_fon.Text == "") {msg("Шумо кишвари муштариро интихоб накардед!"); return; };
            nuber_phon = txt_number_fon.Text;

            if (date_first_dey.Text == "") { msg("Шумо аз кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_start = DateTime.Parse(date_first_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("09:00").ToString("H:mm");

            if (date_first_dey.Text == "") { msg("Шумо то кай қабул кардани муштариро дохил накардед!"); return; }
            datetime_end = DateTime.Parse(date_end_dey.Text).ToString("MM-dd-yyyy") + " " + Convert.ToDateTime("18:00").ToString("H:mm");

            if (combo_type_money.EditValue == null) { msg("Шумо ба муштари намуди роҳхатро интихоб накардед!"); return; }
            type_money = combo_type_money.EditValue.ToString();

            if (txt_number_money.Text == null || txt_number_money.Text == "") { number_money = "0"; }
            else number_money = txt_number_money.Text;

            if (txt_number_order.Text == null || txt_number_order.Text == "") { number_order = "0"; }
            else number_order = txt_number_order.Text;

            if (combo_doctor.EditValue == null) { msg("Шумо ба муштари табиб интихоб накардед!"); return; }
            vrach_id = id_vrach = combo_doctor.EditValue.ToString();

            if (combo_room.EditValue == null) { msg("Шумо ба муштари хучра интихоб накардед!"); return; }
            room_id = id_room = combo_room.EditValue.ToString();

            if (id_kort == "") { msg("Шумо ба муштари корт интихоб накардед!"); return; }
            kord = id_kort;

            DataTable dataTable_kort = sqlConfiguration.sqlSelectQuery($"SELECT * FROM kort where kod_kort='{txt_kort.Text.PadLeft(10, '0')}' and active ='0' and enable ='1';");
            if (dataTable_kort.Rows.Count == 0) { msg("Чунин корт вучуд надорад!!!"); return; }
            else id_kort = dataTable_kort.Rows[0]["id"].ToString();

            sql_add_client = sql_add_client = "insert into client (surname, name, patromic, year_birthday, id_sex, id_county, id_province, nuber_phon, date_time_start, date_time_end, id_varch, id_room, id_type_money, nuber_money, number_order, id_kort, date_registration, currents_id) " +
                                                         $"values('{surname}', '{name}', '{patramic}', '{year_birthday}', '{id_sex}', '{id_country}', {id_province}, '{nuber_phon}',  str_to_date('{datetime_start}', '%m-%d-%Y %H:%i'), str_to_date('{datetime_end}', '%m-%d-%Y %H:%i'), '{vrach_id}', '{room_id}', '{type_money}', '{number_money}', '{number_order}', '{id_kort}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{currentID}');";


            if (surname != "" && name != "" && id_sex != "" && type_money != "" && vrach_id != "" && room_id != "" && kord != "")
            {
                int result = sqlConfiguration.sqlQuery(sql_add_client);
                if (result == 500)
                {
                    msg("Хатоги ба вучуд омад!");

                    txt_full_name.Text = sql_add_client;
                }
                else
                {
                    string _kort_sql = $"update kort SET active = '1' where id = {id_kort}";
                    sqlConfiguration.sqlSelectQuery(_kort_sql); Console.WriteLine($"Корт бан шуд бо раками  {id_kort}");

                    if (arkhivForm != null)
                    {
                        this.arkhivForm.display(); Console.WriteLine("Бо мувафаатият сабт шуд");
                        this.arkhivForm.click_home();
                        this.Close();
                    }
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
            txt_full_name.EditValue = null;
            txt_burthday.EditValue = null;
            com_sex.EditValue = null;
            combo_country.EditValue = null;
            combo_province.EditValue = null;
            txt_number_fon.EditValue = null;
            txt_count_dey.Text = "1";
            date_first_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            date_end_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            combo_type_money.EditValue = null;
            txt_money_for_one_day.EditValue = null;
            txt_number_money.EditValue = null;
            txt_number_order.EditValue = null;
            combo_doctor.EditValue = null;
            combo_room.EditValue = null;
            txt_number_order.EditValue = null;
            txt_kort.EditValue = null;
        }

        private void AddCllient_Shown(object sender, EventArgs e)
        {
            sqlConfiguration = new SqlConfiguration();

            loadItemsCombos();

            if (id_client != "" && txt_button == "Иваз кардан")
            {
                setTextTotextbox(id_client);
                this.Text= "Иваз кардан";
                btn_creat.Text = "Иваз кардан";
                labelInfoForBlockDay.Visible = false;
                return;
            }
            if (id_client == "" && txt_button == "Сохтан")
            {
                date_first_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
                date_end_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
                this.Text = "Сохтан";
                btn_creat.Text = "Сохтан";
                labelInfoForBlockDay.Visible = false;
                return;
            }
            if (id_client != "" && txt_button == "Махкамкунии руз")
            {
                setTextTotextbox(id_client);
                this.Text = "Махкамкунии руз";
                label_info_for_kort.Visible = false;
                date_first_dey.Enabled = false;
                combo_type_money.Enabled = false;
                txt_money_for_one_day.Enabled = false;
                txt_number_money.Enabled = false;
                txt_number_order.Enabled = false;
                combo_doctor.Enabled = false;
                combo_room.Enabled = false;
                txt_kort.Enabled = false;
                btn_creat.Text = "Махкамкунии руз";
                return;
            }
            if (id_client !="" && txt_button== "Кушодани руз") 
            {
                setTextTotextbox(id_client);
                this.Text = "Кушодани руз";
                label_info_for_kort.Visible = false;
                label_info_for_kort.Visible = true;
                txt_money_for_one_day.Enabled = false;
                txt_number_money.Enabled = false;
                txt_number_order.Enabled = false;
                date_first_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
                btn_creat.Text = "Кушодани руз";
                return;
            }
            if (id_client !="" && txt_button == "Сабт кардан")
            {
                setTextTotextbox(id_client);
                this.Text = "Сабт кардан";
                date_first_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
                date_end_dey.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
                btn_creat.Text = "Сабт кардан";
                return;
            }


        }

        private void combo_country_EditValueChanged(object sender, EventArgs e)
        {
            if (combo_country.EditValue!=null)            
                displayItemComboPtovince(combo_country.EditValue.ToString());
        }

        private void txt_count_dey_EditValueChanged(object sender, EventArgs e)
        {
            if (btn_creat.Text== "Махкамкунии руз")
            {
                labelInfoForBlockDay.Visible = true;
                labelInfoForBlockDay.Text = $"Шумо {currentCountDay - int.Parse(txt_count_dey.Text)} рузи боқимондаи муштариро макам доред!";
            }
            else if (btn_creat.Text == "Кушодани руз")
            {
                if (txt_count_dey.Text != "")
                    if (double.Parse(txt_count_dey.Text) > 0)
                    {
                        AddDay(DateTime.Parse(date_first_dey.Text), double.Parse(txt_count_dey.Text) - 1);
                        if (txt_money_for_one_day.Text != null && txt_money_for_one_day.Text != "")
                            txt_number_money.Text = (double.Parse(txt_count_dey.Text) * double.Parse(txt_money_for_one_day.Text)).ToString();
                    }
            }
            else {
                labelInfoForBlockDay.Visible = false;
                if (txt_count_dey.Text != null)
                    if (txt_count_dey.Text != "")
                        if (double.Parse(txt_count_dey.Text) > 0)
                        {
                            AddDay(DateTime.Parse(date_first_dey.Text), double.Parse(txt_count_dey.Text) - 1);
                            if (txt_money_for_one_day.Text != null && txt_money_for_one_day.Text != "")
                                txt_number_money.Text = (double.Parse(txt_count_dey.Text) * double.Parse(txt_money_for_one_day.Text)).ToString();
                        }
            }

            
        }

        void AddDay(DateTime dateTimeFirst, double addDayToInt)
        {
            date_end_dey.Text = dateTimeFirst.AddDays(addDayToInt).ToString("dd/MM/yyyy");
        }

        private void combo_type_money_EditValueChanged(object sender, EventArgs e)
        {
            /*if (combo_type_money.Text == "Бо маблағ"
                || combo_type_money.EditValue.ToString() == "1")
            {
                txt_money_for_one_day.TabStop = true;
            }
            else
            {
                txt_money_for_one_day.Text = "0";
                txt_money_for_one_day.TabStop = false;*//*
            }*/
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (btn_creat.Text == "Сохтан") addClient();
            if (btn_creat.Text == "Иваз кардан") editClient(id_client);
            if (btn_creat.Text == "Махкамкунии руз") blockClient(id_client);
            if (btn_creat.Text == "Кушодани руз") notBlockClient();
            if (btn_creat.Text == "Сабт кардан") copyClient();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_сlear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void Txt_kort_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length > 0 && int.Parse(txt_kort.Text)>0)
                label_info_for_kort.Visible = true;
            else
                label_info_for_kort.Visible = false;

            check_kort(txt_kort.Text);
        }

        private void txt_money_for_one_day_EditValueChanged(object sender, EventArgs e)
        {
            
            if (txt_button != "Кушодани руз")
                if (txt_count_dey.Text != null)
                    if (txt_count_dey.Text != "")
                        if (double.Parse(txt_count_dey.Text) > 0)
                        {
                            if (txt_count_dey.EditValue != null && date_first_dey.EditValue!=null)
                            {
                                AddDay(DateTime.Parse(date_first_dey.Text), double.Parse(txt_count_dey.Text) - 1);
                                if (txt_money_for_one_day.Text != null && txt_money_for_one_day.Text != "")
                                    txt_number_money.Text = (double.Parse(txt_count_dey.Text) * double.Parse(txt_money_for_one_day.Text)).ToString();
                            }
                              
                        }
        }

        private void txt_full_name_Leave(object sender, EventArgs e)
        {
            txt_full_name.Text = CapitalizeFirstLetters(txt_full_name.Text);
        }

        private void txt_number_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
    }
}
