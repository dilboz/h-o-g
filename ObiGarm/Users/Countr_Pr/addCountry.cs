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

namespace ObiGarm.Users.Countr_Pr
{
    public partial class addCountry : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly CountryRro countryRro;
        private string text_button;
        public string id;
        public addCountry( CountryRro countryRro, string text_button, string id)
        {
            sqlConfiguration = new SqlConfiguration();
            InitializeComponent();
            this.countryRro = countryRro;
            this.text_button = text_button;
            this.id = id;
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from country where id = '" + id + "'";

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

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани кишвар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void addCountry_Shown(object sender, EventArgs e)
        {
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
                group_name_frame.Text = "ИВАЗ КАРДАНИ АДМИН";
            }
        }

        private void addCounty()
        {
            string name_frame = txt_name.Text;
            string sql_user_farme = "select * from country where name = '" + name_frame + "'";

            string sql_add_frame = "insert into country (name) values('" +
               name_frame + "');";

            if (name_frame.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_farme).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        countryRro.displaycountry();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин кишвар дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи кишвар дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void addUpdate(string id)
        {
            string name_frame = txt_name.Text;
            string sql_user_farme = "select * from country where name = '" + name_frame + "'";


            string sql_update_frame = "update country set " +
                "name = '" + name_frame + "' " +
               " where id = '" + id + "'";

            if (name_frame.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_farme).Rows.Count <= 1)
                {
                    int result = sqlConfiguration.sqlQuery(sql_update_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        countryRro.displaycountry();
                        countryRro.displayPr();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин кишвар дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи кишвар дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                addCounty();
            }
            else
            {
                addUpdate(this.id);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
