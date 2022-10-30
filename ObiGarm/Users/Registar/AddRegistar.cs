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

namespace ObiGarm.Users.Registar
{
    public partial class AddRegistar : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;


        private readonly RegistarFormDisplay registarFormDisplay_form ;
        private string id_user;
        private string text_button;

        public AddRegistar(RegistarFormDisplay registarFormDisplay , string id_user, string text_button)
        {

            sqlConfiguration = new SqlConfiguration();
            registarFormDisplay_form = registarFormDisplay;
            this.id_user = id_user;
            this.text_button = text_button;
            InitializeComponent();
        }

        public void cheng_enbled(string id)
        {

            string sql = "select * from users where id = '" + id + "' ";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            if (dataTable.Rows[0]["enable"].ToString() == "1")
            {
                check_enable.Checked = true;
            }
            else
            {
                check_enable.Checked = false;
            }
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
                    cheng_enbled(id);
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void AddRegistar_Shown(object sender, EventArgs e)
        {
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                btn_creat.Text = "Иваз кардан";
                group_creat_registr.Text = "ИВАЗ КАРДАНИ РЕГИСТР";
            }
        }

        string str_enbaled_register;
        private void enbaled_register()
        {
            if (check_enable.Checked == true)
            {
                str_enbaled_register = "1";
            }
            else
            {
                str_enbaled_register = "0";
            }
        }

        private void addRegistar()
        {
            string name_registar = txt_name.Text;
            string surname_registar = txt_surname.Text;
            string login_registar = txt_login.Text;
            string password_registar= txt_password.Text;
            string check_password_register = txt_cheng_password.Text;
            string point_register = "4";
            enbaled_register();
            string enaled_admin = str_enbaled_register;

            string sql_user_check = "select * from users where login = '" + login_registar + "' and point= '4' and deleted IS NULL";

            string sql_add_user = "insert into users (name, surname, login, password, point, enable) values('" +
                name_registar + "', '" +
                surname_registar + "', '" +
                login_registar + "', '" +
                password_registar + "', '" +
                point_register + "', '" +
                enaled_admin + "');";

            if (name_registar.Trim() != "" && surname_registar.Trim() != "" && login_registar.Trim() != "" && password_registar.Trim() != "" && check_password_register.Trim() != "")
            {
                if (password_registar.Trim() == check_password_register.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count == 0)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_add_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            registarFormDisplay_form.display();
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

        private void updateRegitar(string id)
        {
            string name_registar = txt_name.Text;
            string surname_registarn = txt_surname.Text;
            string login_registar = txt_login.Text;
            string password_registar = txt_password.Text;
            string check_password_registarn = txt_cheng_password.Text;
            string point_registar = "4";
            enbaled_register();
            string enaled_registar = str_enbaled_register;

            string sql_user_check = "select * from users where login = '" + login_registar + "' and point= '4' and deleted IS NULL";

            string sql_update_user = "update users set " +
                "name = '" + name_registar + "', " +
                "surname = '" + surname_registarn + "', " +
                "login = '" + login_registar + "', " +
                "password = '" + password_registar + "', " +
                "point = '" + point_registar + "', " +
                "enable = '" + enaled_registar + "' " +
               " where id = '" + id + "'";

            if (name_registar.Trim() != "" && surname_registarn.Trim() != "" && login_registar.Trim() != "" && password_registar.Trim() != "" && check_password_registarn.Trim() != "")
            {
                if (password_registar.Trim() == check_password_registarn.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count >= 1)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_update_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                            registarFormDisplay_form.display();
                            //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show(sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count.ToString());
                        MessageBox.Show("Чунин логин дар система вучуд надорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                addRegistar();
            }
            else
            {
                updateRegitar(this.id_user);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
