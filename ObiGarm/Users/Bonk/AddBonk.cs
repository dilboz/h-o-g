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

namespace ObiGarm.Users.Bonk
{
    public partial class AddBonk : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private readonly ListBonk listBonk;
        private string text_button;
        public string id;

        public AddBonk(ListBonk listBonk, string id, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.listBonk = listBonk;
            this.text_button = text_button;
            this.id = id;
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from name_bank where id = '" + id + "'";

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
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void AddBonk_Shown(object sender, EventArgs e)
        {
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
            }
        }

        private void add()
        {
            string name_bank = txt_name.Text;
            string sql_user_farme = $"select * from name_bank where name = '" + name_bank + "' and enable = '1' ";

            string sql_add_bank = "insert into name_bank (name) values('" +
               name_bank + "');";

            if (name_bank.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_farme).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_bank);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        listBonk.display();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин бонк дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи бонкро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void updte(string id)
        {
            string name_bsnk = txt_name.Text;
            string sql_user_bank = "select * from name_bank where name = '" + name_bsnk + "' and enable ='1'";


            string sql_update_frame = "update name_bank set " +
                "name = '" + name_bsnk + "' " +
               " where id = '" + id + "'";

            if (name_bsnk.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_bank).Rows.Count <= 1)
                {
                    int result = sqlConfiguration.sqlQuery(sql_update_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        listBonk.display();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин бонк дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи бонкро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                add();
            }
            else
            {
                updte(this.id);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
