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

namespace ObiGarm.Accounting.ConsumptionMoney.ConsumptionMoneyanKassa
{
    public partial class ConsuptionAddMoneyKassa : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly ConsuptionListMoneyKassa consumptionMoney;
        private string id_list_money;
        private string text_button;
        

        public ConsuptionAddMoneyKassa(ConsuptionListMoneyKassa consumptionMoney, string id_list_money, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.consumptionMoney = consumptionMoney;
            this.id_list_money = id_list_money;
            this.text_button = text_button;
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "SELECT name, number_money as 'num_mon', date FROM consuption_moneys where id = '" + id_list_money + "'";

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
                    txt_number_money.Text = dataTable.Rows[0]["num_mon"].ToString();
                    date_get_money.EditValue = dataTable.Rows[0]["date"].ToString();
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }


        void add()
        {
            string name = txt_name.Text.Trim();
            string nuber_money = txt_number_money.Text;
            string date = Convert.ToDateTime(date_get_money.Text).ToString("yyyy-MM-dd");

            string add_get_money = $"INSERT INTO consuption_moneys (name, number_money, date) VALUES ('{name}', '{nuber_money}', '{date}');";

            if (name != "" && nuber_money != "")
            {
                int result = sqlConfiguration.sqlQuery(add_get_money);
                if (result == 500)
                {
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                    consumptionMoney.display();
                }
            }
            else
            {
                MessageBox.Show("Шумо хаммаи поляхоро пур накардед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void update(string id)
        {
            string name = txt_name.Text.Trim();
            string nuber_money = txt_number_money.Text;
            string date = Convert.ToDateTime(date_get_money.Text).ToString("yyyy-MM-dd");

            string update_get_money = $"UPDATE consuption_moneys SET name = '{name}', number_money = '{nuber_money}', date = '{date}' WHERE (`id` = '{id}');";

            if (name != "" && nuber_money != "")
            {
                int result = sqlConfiguration.sqlQuery(update_get_money);
                if (result == 500)
                {
                    MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                    consumptionMoney.display();
                }
            }
            else
            {
                MessageBox.Show("Шумо хаммаи поляхоро пур накардед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id_list_money == "" && this.text_button == "Сохтан")
            {
                add();
            }
            else
            {
                update(this.id_list_money);
            }
        }

        private void ConsuptionAddMoneyKassa_Shown(object sender, EventArgs e)
        {
            if (this.id_list_money != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_list_money);
                btn_creat.Text = "Иваз кардан";
                this.Text = "ИВАЗ КАРДАН";
            }
        }

        private void txt_number_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
