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

namespace ObiGarm.Users.Vracah
{
    public partial class AddVrach : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly VrachFormDisplay vrachFormDisplay_form;
        private string id_user;
        private string text_button;

        public AddVrach(VrachFormDisplay vrachFormDisplay, string id_user, string text_button)
        {
            sqlConfiguration = new SqlConfiguration();
            vrachFormDisplay_form = vrachFormDisplay;
            this.id_user = id_user;
            this.text_button = text_button;
            InitializeComponent();
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from users where id = '" + id + "'";

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
                    txt_room_number.Value = Convert.ToDecimal(dataTable.Rows[0]["room_number"].ToString());
                    txt_time_start_work.EditValue = dataTable.Rows[0]["work_time_start"].ToString();
                    txt_time_end_work.EditValue = dataTable.Rows[0]["work_time_end"].ToString();
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void AddVrach_Shown(object sender, EventArgs e)
        {
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                btn_creat.Text = "Иваз кардан";
                group_add_vrach.Text = "ИВАЗ КАРДАНИ ВРАЧ";
                this.Text = "ИВАЗ КАРДАНИ ВРАЧ";
            }
        }

        private void addVrach()
        {
            string name_vrach = txt_name.Text;
            string surname_vrach = txt_surname.Text;
            string login_vrach = txt_login.Text;
            string password_vrach = txt_password.Text;
            string check_password_vrach = txt_cheng_password.Text;
            string point_vrach = "3";
            string number_room_vrach = Convert.ToString(txt_room_number.Value);
            string time_start_work =Convert.ToDateTime(txt_time_start_work.Text).ToString("HH:mm");
            string time_end_work = Convert.ToDateTime(txt_time_end_work.Text).ToString("HH:mm");
            
            string sql_user_check = "select * from users where login = '" + login_vrach + "' and point= '3' and deleted is null;";

            string sql_add_user = "insert into users (name, surname, login, password, point, room_number, work_time_start, work_time_end, enable) values('" +
                name_vrach + "', '" +
                surname_vrach + "', '" +
                login_vrach + "', '" +
                password_vrach + "', '" +
                point_vrach + "', '" +
                number_room_vrach + "', '" +
                time_start_work + "', '" +
                time_end_work +"');";

            if (name_vrach.Trim() != "" && surname_vrach.Trim() != "" && login_vrach.Trim() != "" && password_vrach.Trim() != "" && check_password_vrach.Trim() != ""
                && (number_room_vrach.Trim() != "" || number_room_vrach.Trim() == "0") && time_start_work != "" && time_end_work != "")
            {
                if (password_vrach.Trim() == check_password_vrach.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count != 1)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_add_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            vrachFormDisplay_form.display();
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
        private void updateVrach(string id)
        {

            string name_vrach = txt_name.Text;
            string surname_vrach = txt_surname.Text;
            string login_vrach = txt_login.Text;
            string password_vrach = txt_password.Text;
            string check_password_vrach = txt_cheng_password.Text;
            string point_vrach = "3";
            string number_room_vrach = Convert.ToString(txt_room_number.Value);
            string time_start_work = Convert.ToDateTime(txt_time_start_work.Text).ToString("HH:mm");
            string time_end_work = Convert.ToDateTime(txt_time_end_work.Text).ToString("HH:mm");

            
            string sql_user_check = "select * from users where login = '" + login_vrach + "' and point= '3' and deleted is null;";

            string sql_update_user = "update users set " +
               "name = '" + name_vrach + "', " +
               "surname = '" + surname_vrach + "', " +
               "login = '" + login_vrach + "', " +
               "password = '" + password_vrach + "', " +
               "point = '" + point_vrach + "', " +
               "room_number = '" + number_room_vrach + "', " +
               "work_time_start = '" + time_start_work + "', " +
               "work_time_end = '" + time_end_work +  "' " +
              " where id = '" + id + "'";


            if (name_vrach.Trim() != "" && surname_vrach.Trim() != "" && login_vrach.Trim() != "" && password_vrach.Trim() != "" && check_password_vrach.Trim() != ""
                && (number_room_vrach.Trim() != "" || number_room_vrach.Trim() == "0") && time_start_work != "" && time_end_work != "")
            {
                if (password_vrach.Trim() == check_password_vrach.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count != 2 && (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count == 1 || sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count == 0))
                    {
                        int result = sqlConfiguration.sqlQuery(sql_update_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            vrachFormDisplay_form.display();
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
                addVrach();
            }
            else
            {
                updateVrach(this.id_user);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
