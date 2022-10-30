using ObiGarm.ClassDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm
{
    public partial class SettinsForm : Form
    {
        SqlConfiguration sqlConfiguration;
        SettingsDatabase settingsDatabase;

        public SettinsForm()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            settingsDatabase = new SettingsDatabase();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SettinsForm_Load(object sender, EventArgs e)
        {
            List<string> setting_db = new List<string>();
            string line;

            string path = settingsDatabase.path_name;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                setting_db.Add(line);
            }
            txt_name_host.Text = setting_db[0];
            txt_name_user.Text = setting_db[1];
            txt_password_user.Text = setting_db[2];
           txt_name_database.Text = setting_db[3];
        }

        private bool testFunctionForDB()
        {
            SqlConfiguration.datasource = txt_name_host.Text;
            SqlConfiguration.username = txt_name_user.Text;
            SqlConfiguration.password = txt_password_user.Text;
            SqlConfiguration.database = txt_name_database.Text;
            SqlConfiguration.port = "3306";
           
            return SqlConfiguration.getConnection();
        }

        private void btn_text_connect_Click(object sender, EventArgs e)
        {
            if (testFunctionForDB())
            {
                MessageBox.Show("Натича: Ба база пайваст шудан мумкин аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);

                btn_save_data.Enabled = true;
                btn_connect_data.Enabled = true;
            }
            else
            {
                MessageBox.Show("Натича: Ба база пайвайт шудан номумкин аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_data_Click(object sender, EventArgs e)
        {
            string path = settingsDatabase.path_name;

            if (testFunctionForDB())
            {
                try
                {
                    StreamWriter file = new StreamWriter(path);

                    file.WriteLine(txt_name_host.Text);
                    file.WriteLine(txt_name_user.Text);
                    file.WriteLine(txt_password_user.Text);
                    file.WriteLine(txt_name_database.Text);
                    MessageBox.Show("Амалиёт анчом ёфт!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    file.Flush();
                    file.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Хатоги:\n" + ex.ToString(), "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_connect_data_Click(object sender, EventArgs e)
        {
            if (testFunctionForDB())
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Бо ин маълумотхо ба база пайваст шудан номумкин аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
