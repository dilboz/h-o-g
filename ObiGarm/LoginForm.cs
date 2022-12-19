using ObiGarm.Accounting;
using ObiGarm.Administration;
using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura;
using ObiGarm.Users;
using ObiGarm.Vrach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ObiGarm
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        SettingsDatabase settingsDatabase;

       

        List<string> setting_db = new List<string>();

        public LoginForm()
        {
            InitializeComponent();

            sqlConfiguration = new SqlConfiguration();
            settingsDatabase = new SettingsDatabase();
        }

        #region From vod isFirstTime
        string l;
        string res = "";
       
        #endregion


        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && (e.Alt || e.Control || e.Shift))
            {
                SettinsForm settinsForm = new SettinsForm();
                settinsForm.ShowDialog();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


            txt_password.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password; //text box for inputing password

            string path_name = settingsDatabase.path_name;
            
            string line;
            StreamReader sr = new StreamReader(path_name);
            while ((line = sr.ReadLine()) != null)
            {
                setting_db.Add(line);
            }
            sr.Close();

            try
            {
                SqlConfiguration.datasource = setting_db[0];
                SqlConfiguration.username = setting_db[1];
                SqlConfiguration.password = setting_db[2];
                SqlConfiguration.database = setting_db[3];
                SqlConfiguration.port = "3306";

                if (!testFunctionForDB())
                {

                    if (isFirstTime())
                    {
                        //SettingsDatabase enterDataDatabase = new SettingsDatabase();
                        //enterDataDatabase.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми пайвастшави ба базза!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SettinsForm settingsDatabase = new SettinsForm();
                        settingsDatabase.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private bool isFirstTime()
        {
            StreamReader sr = new StreamReader(@"setting\setting_enter.txt");
            while ((l = sr.ReadLine()) != null)
            {
                res = l;
            }
            sr.Close();

            if (res == "1")
            {
                return true;
            }
            return false;
        }

        private void check_show_password_OnChange(object sender, EventArgs e)
        {
            if (check_show_password.Checked)
            {
                check_show_password.Checked = true;
                lbl_show_password.Text = "&Паноҳкунии рамз";
               txt_password.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {

                check_show_password.Checked = false;
                lbl_show_password.Text = "&Дидани рамз";
                txt_password.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void lbl_show_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (check_show_password.Checked)
            {
                lbl_show_password.Text = "&Дидани рамз";
                txt_password.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                check_show_password.Checked = false;
            }
            else
            {
                lbl_show_password.Text = "&Паноҳкунии рамз";
                txt_password.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                check_show_password.Checked = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool testFunctionForDB()
        {
            SqlConfiguration.datasource = setting_db[0];
            SqlConfiguration.username = setting_db[1];
            SqlConfiguration.password = setting_db[2];
            SqlConfiguration.database = setting_db[3];
            SqlConfiguration.port = "3306";

            return SqlConfiguration.getConnection();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginFunc();
        }


        private void LoginFunc()
        {
            if (txt_login.Text != "" && txt_password.Text != "")
            {
                string select_user = "select * from users where login= '" + txt_login.Text + "' and password= '" + txt_password.Text + "' and enable = '1';";

                DataTable tabel_select_user = sqlConfiguration.sqlSelectQuery(select_user);

                if (tabel_select_user.Rows.Count != 0)
                {
                    if (tabel_select_user.Rows.Count == 1)
                    {
                        SettingsDatabase.id_user= tabel_select_user.Rows[0]["id"].ToString();
                        SettingsDatabase.name_user= tabel_select_user.Rows[0]["name"].ToString();
                        SettingsDatabase.surname_user = tabel_select_user.Rows[0]["surname"].ToString();
                        SettingsDatabase.type_user = tabel_select_user.Rows[0]["point"].ToString();

                        if (tabel_select_user.Rows[0]["point"].ToString() == "6")
                        {
                            InfoReportsFromMoney infoReportsFromMoney = new InfoReportsFromMoney();
                            infoReportsFromMoney.Show();
                            this.Hide();
                            
                        }

                        if (tabel_select_user.Rows[0]["point"].ToString() == "5")
                        {
                            AccountingForm accountingForm = new AccountingForm();
                            accountingForm.Show();
                            this.Hide();
                        }

                        if (tabel_select_user.Rows[0]["point"].ToString()== "4" )
                        {
                            Ristratura risrarura = new Ristratura();
                            risrarura.Show();
                            this.Hide();
                        }
                        if (tabel_select_user.Rows[0]["point"].ToString() == "3")
                        {
                            MainFormVrach mainFormVrach = new MainFormVrach();
                            mainFormVrach.Show();
                            this.Hide();
                        }
                        if (tabel_select_user.Rows[0]["point"].ToString() == "1")
                        {
                            UserForm adminForm = new UserForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("рамз ва Логин дакик ворид кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Бо чунин рамз ва Логин истифода баранда нест!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txt_login.Text != "" || txt_password.Text != "")
            {
                if (txt_login.Text != "")
                {
                    MessageBox.Show("Логинро ворид куне");
                }
                if (txt_password.Text != "")
                {
                    MessageBox.Show("рамзро ворид кунед ворид куне");
                }
            }
            else
            {
                MessageBox.Show("Малумотро пурра дохил кунед");
            }
        }
    }
}
