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

namespace ObiGarm.Users.Bugalter
{
    public partial class AddBugalter : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private readonly ListBugalter listBugalter;
        private string id_user;
        private string text_button;

        public AddBugalter(ListBugalter listBugalter, string id_user, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.listBugalter = listBugalter;
            this.id_user = id_user;
            this.text_button = text_button;
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
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void add()
        {
            string name_registar = txt_name.Text;
            string surname_registar = txt_surname.Text;
            string login_registar = txt_login.Text;
            string password_registar = txt_password.Text;
            string check_password_register = txt_cheng_password.Text;
            string point_register = "5";
            string enaled_admin = "1";

            string sql_user_check = "select * from users where login = '" + login_registar + "' and point= '5' and deleted IS NULL";

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
                            txt_name.Text = sql_add_user;
                        }
                        else
                        {
                            this.Close();
                            listBugalter.display();
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

        private void update(string id)
        {
            string name_registar = txt_name.Text;
            string surname_registarn = txt_surname.Text;
            string login_registar = txt_login.Text;
            string password_registar = txt_password.Text;
            string check_password_registarn = txt_cheng_password.Text;
            string point_registar = "5";
            string enaled_registar = "1";

            string sql_user_check = "select * from users where login = '" + login_registar + "' and point= '5' and deleted IS NULL";

            string sql_update_user = "update users set " +
                "name = '" + name_registar + "', " +
                "surname = '" + surname_registarn + "', " +
                "login = '" + login_registar + "', " +
                "password = '" + password_registar + "', " +
                "point = '" + point_registar + "', " +
                "enable = '" + enaled_registar + "'" +
               " where id = '" + id + "'";

            if (name_registar.Trim() != "" && surname_registarn.Trim() != "" && login_registar.Trim() != "" && password_registar.Trim() != "" && check_password_registarn.Trim() != "")
            {
                if (password_registar.Trim() == check_password_registarn.Trim())
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count <= 1)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_update_user);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_name.Text = sql_update_user;
                        }
                        else
                        {
                            this.Close();
                            listBugalter.display();
                            //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        //MessageBox.Show(sqlConfiguration.sqlSelectQuery(sql_user_check).Rows.Count.ToString());
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
                add();
            }
            else
            {
                update(this.id_user);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBugalter_Shown(object sender, EventArgs e)
        {
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                btn_creat.Text = "Иваз кардан";
                group_creat_registr.Text = "ИВАЗ КАРДАНИ РЕГИСТР";
            }
        }
    }
}
