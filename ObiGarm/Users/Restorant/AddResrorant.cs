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

namespace ObiGarm.Users.Restorant
{
    public partial class AddResrorant : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly  ListRestorant listRestorant;
        private string id_user;
        private string text_button;

        public AddResrorant(ListRestorant listRestorant, string id_user, string text_button)
        {
            sqlConfiguration = new SqlConfiguration();
            this.listRestorant = listRestorant;
            this.id_user = id_user;
            this.text_button = text_button;
            InitializeComponent();
        }

        void load_comobo()
        {
            string sql = "SELECT * FROM type_kort";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_type_kort);
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select users.id, users.name as 'name', users.surname, users.login, users.password, type_kort.name as 'type_kort' " +
                "from users " +
                "inner join type_kort on users.type_kort = type_kort.id " +
                $"where users.id='{id}'; ";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                Console.WriteLine(sql);
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    txt_name.Text = dataTable.Rows[0]["name"].ToString();
                    txt_surname.Text = dataTable.Rows[0]["surname"].ToString();
                    combo_type_kort.Text = dataTable.Rows[0]["type_kort"].ToString();
                    txt_login.Text =dataTable.Rows[0]["login"].ToString();
                    txt_password.Text =dataTable.Rows[0]["password"].ToString();
                    txt_cheng_password.Text =dataTable.Rows[0]["password"].ToString();
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btn_hide_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void AddResrorant_Shown(object sender, EventArgs e)
        {
            load_comobo();
            if (this.id_user != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_user);
                btn_creat.Text = "Иваз кардан";
                this.Text = "ИВАЗ КАРДАНИ АДМИН РЕСТОРАНТ";
                group_creat_admin_restorant.Text = "ИВАЗ КАРДАНИ СПИТСИАЛИСТ";
            }
        }


        private void addAdmin()
        {
            string name_admin = txt_name.Text;
            string surname_admin = txt_surname.Text;
            string login_admin = txt_login.Text;
            string password_admin = txt_password.Text;
            string check_password_admin = txt_cheng_password.Text;
            string id_typr_restorant = combo_type_kort.SelectedValue.ToString();
            string point_admin = "7";


            string sql_user_check = "select * from users where login = '" + login_admin + "' and point= '' and deleted IS NULL";

            string sql_add_user = "insert into users (name, surname, login, password, type_kort, point) values('" +
                name_admin + "', '" +
                surname_admin + "', '" +
                login_admin + "', '" +
                password_admin + "', '" +
                id_typr_restorant + "', '" +
                point_admin + "');";

            if (name_admin.Trim() != "" && surname_admin.Trim() != "" && login_admin.Trim() != "" && password_admin.Trim() != "" && check_password_admin.Trim() != "" && id_typr_restorant!="")
            {
                if (password_admin.Trim() == check_password_admin.Trim())
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
                            listRestorant.display();
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
            string name_admin = txt_name.Text;
            string surname_admin = txt_surname.Text;
            string login_admin = txt_login.Text;
            string password_admin = txt_password.Text;
            string check_password_admin = txt_cheng_password.Text;
            string id_typr_restorant = combo_type_kort.SelectedValue.ToString();
            string point_admin = "7";
            string sql_user_check = "select * from users where login = '" + login_admin + "' and point= '7' and deleted IS NULL";

            string sql_update_user = "update users set " +
                "name = '" + name_admin + "', " +
                "surname = '" + surname_admin + "', " +
                "login = '" + login_admin + "', " +
                "password = '" + password_admin + "', " +
                "type_kort = '" + id_typr_restorant + "', " +
                "point = '" + point_admin + "' " +
               " where id = '" + id + "'";

            if (name_admin.Trim() != "" && surname_admin.Trim() != "" && login_admin.Trim() != "" && password_admin.Trim() != "" && check_password_admin.Trim() != "" && id_typr_restorant!="")
            {
                if (password_admin.Trim() == check_password_admin.Trim())
                {

                    int result = sqlConfiguration.sqlQuery(sql_update_user);
                    if (result == 500)
                    {

                        txt_name.Text = sql_update_user;
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Close();
                        listRestorant.display();
                        //MessageBox.Show("Админ бо муваффакият илова карда шуд!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
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
