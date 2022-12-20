using ObiGarm.ClassDatabase;
using ObiGarm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Users.Spitalists
{
    public partial class AddSpitalist : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly SpitalistFormDisplay spitalistFormDisplay_form;
        private readonly ServicesFormDisplay servicesFormDisplay_from;

        private string id_user;
        private string text_button;

        public AddSpitalist(SpitalistFormDisplay spitalistFormDisplay, string id_user, string text_button)
        {
            sqlConfiguration = new SqlConfiguration();
            spitalistFormDisplay_form = spitalistFormDisplay;
            this.id_user = id_user;
            this.text_button = text_button;
            InitializeComponent();
        }

        void load_comobo()
        {
            string sql = "SELECT * FROM manitor";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_manitor);
        }

        public AddSpitalist(ServicesFormDisplay servicesFormDisplay, string id_user, string text_button)
        {
            sqlConfiguration = new SqlConfiguration();
            servicesFormDisplay_from = servicesFormDisplay;
            this.id_user = id_user;
            this.text_button = text_button;
            InitializeComponent();
        }
        
        private void setTextToTextBoxs(string id)
        {
            string sql = "select users.id, users.name as 'name', users.surname, users.login, users.password, users.room_number, users.work_time_end, users.work_time_start, manitor.name as 'manitor' " +
                "from users " +
                "inner join manitor on users.id_manitor = manitor.id " +
                $"where users.id='{id}'; ";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    txt_name.Text = dataTable.Rows[0]["name"].ToString();
                    txt_surname.Text = dataTable.Rows[0]["surname"].ToString();
                    txt_login.Text = dataTable.Rows[0]["login"].ToString();
                    txt_password.Text = dataTable.Rows[0]["password"].ToString();
                    txt_cheng_password.Text = dataTable.Rows[0]["password"].ToString();
                    txt_room_number.Value=Convert.ToDecimal(dataTable.Rows[0]["room_number"].ToString());
                    txt_time_start_work.EditValue= dataTable.Rows[0]["work_time_start"].ToString();
                    txt_time_end_work.EditValue= dataTable.Rows[0]["work_time_end"].ToString();
                    combo_manitor.Text= dataTable.Rows[0]["manitor"].ToString();
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }


        //string str_enbaled_admin;
        
        private void AddSpitalist_Shown(object sender, EventArgs e)
        {
            load_comobo();
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                btn_creat.Text = "Иваз кардан";
                this.Text = "ИВАЗ КАРДАНИ СПИТСИАЛИСТ";
                group_sipitsalist.Text = "ИВАЗ КАРДАНИ СПИТСИАЛИСТ";
            }
        }

        private void addAdmin()
        {

            string name_spitalist = txt_name.Text;
            string surname_spitalist = txt_surname.Text;
            string login_spitalist = txt_login.Text;
            string password_spitalist = txt_password.Text;
            string check_password_spitalist = txt_cheng_password.Text;
            string point_spitalist = "2";
            string number_room_spitalist = Convert.ToString(txt_room_number.Value);
            string time_start_work =Convert.ToDateTime(txt_time_start_work.Text).ToString("HH:mm");
            string time_end_work = Convert.ToDateTime(txt_time_end_work.Text).ToString("HH:mm");
            string manitor_id = combo_manitor.SelectedValue.ToString();
            


            string sql_user_check = "select * from users where login = '" + login_spitalist + "' and point= '2' and deleted is null";

            string sql_add_user = "insert into users (name, surname, login, password, point, room_number, id_manitor, work_time_start, end_date_time_services, work_time_end) values('" +
                name_spitalist + "', '" +
                surname_spitalist + "', '" +
                login_spitalist + "', '" +
                password_spitalist + "', '" +
                point_spitalist + "', '" +
                number_room_spitalist + "', '" +
                manitor_id + "', '" +
                time_start_work + "', '" +
                DateTime.Now.ToString("yyyy-MM-dd ") + time_start_work + "', '" +
                time_end_work + "');";

            if (name_spitalist.Trim() != "" && surname_spitalist.Trim() != "" && login_spitalist.Trim() != "" && password_spitalist.Trim() != "" && check_password_spitalist.Trim() != "" 
                && (number_room_spitalist.Trim()!="" || number_room_spitalist.Trim()=="0") && time_start_work!="" && time_end_work!="" && manitor_id!="")
            {
                if (password_spitalist.Trim() == check_password_spitalist.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count == 0)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_add_user);
                        if (result == 500)
                        {
                            txt_name.Text = sql_add_user;
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            if (spitalistFormDisplay_form != null)
                            {

                                spitalistFormDisplay_form.display();
                            }
                            if (servicesFormDisplay_from!=null)
                            {
                                servicesFormDisplay_from.allDisplayList();
                            }
                            
                            //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Чунин логин дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Рамзхо ба хам мувофик нестанд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Пур кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
        private void updateAdmin(string id)
        {

            string name_spitalist = txt_name.Text;
            string surname_spitalist = txt_surname.Text;
            string login_spitalist = txt_login.Text;
            string password_spitalist = txt_password.Text;
            string check_password_spitalist = txt_cheng_password.Text;
            string point_spitalist = "2";
            string number_room_spitalist = Convert.ToString(txt_room_number.Value);
            string time_start_work = Convert.ToDateTime(txt_time_start_work.Text).ToString("HH:mm");
            string time_end_work = Convert.ToDateTime(txt_time_end_work.Text).ToString("HH:mm");
            string manitor_id = combo_manitor.SelectedValue.ToString();



            string sql_user_check = "select * from users where login = '" + login_spitalist + "' and point= '2' and deleted is null";

            string sql_update_user = "update users set " +
               "name = '" + name_spitalist + "', " +
               "surname = '" + surname_spitalist + "', " +
               "login = '" + login_spitalist + "', " +
               "password = '" + password_spitalist + "', " +
               "point = '" + point_spitalist + "', " +
               "room_number = '" + number_room_spitalist + "', " +
               "id_manitor = '" + manitor_id + "', " +
               "work_time_start = '" + time_start_work + "', " +
               "end_date_time_services = '" + DateTime.Now.ToString("yyyy-MM-dd ") + time_start_work + "', " +
               "work_time_end = '" + time_end_work +  "' " +
              " where id = '" + id + "'";


            if (name_spitalist.Trim() != "" && surname_spitalist.Trim() != "" && login_spitalist.Trim() != "" && password_spitalist.Trim() != "" && check_password_spitalist.Trim() != ""
                && (number_room_spitalist.Trim() != "" || number_room_spitalist.Trim() == "0") && time_start_work != "" && time_end_work != "" && manitor_id!="")
            {
                if (password_spitalist.Trim() == check_password_spitalist.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count <= 1)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_update_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            if (spitalistFormDisplay_form != null)
                            {

                                spitalistFormDisplay_form.display();
                            }
                            if (servicesFormDisplay_from != null)
                            {
                                servicesFormDisplay_from.allDisplayList();
                            }
                            //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Чунин логин дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Рамзхо ба хам мувофик нестанд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Пур кардани хамаи сатрхо хатми аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id_user == "" && this.text_button == "Сохтан")
            {
                addAdmin();
            }
            else
            {
                updateAdmin(this.id_user);
            }
        }
    }
}
