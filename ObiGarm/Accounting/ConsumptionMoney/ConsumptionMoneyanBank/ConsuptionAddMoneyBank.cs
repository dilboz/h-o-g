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

namespace ObiGarm.Accounting.ConsumptionMoney.ConsumptionMoneyanBank
{
    public partial class ConsuptionAddMoneyBank : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly ConsuptionListMoneyBank consuptionListMoneyBank;
        private string id_list_money_bank;
        private string text_button;

        public ConsuptionAddMoneyBank(ConsuptionListMoneyBank consuptionListMoneyBank, string id_list_money_bank, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.consuptionListMoneyBank = consuptionListMoneyBank;
            this.id_list_money_bank = id_list_money_bank;
            this.text_button = text_button;
        }

        void loadCombo()
        {
            string sql = "SELECT * FROM name_bank where enable=1;";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_list_name_bank);
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "SELECT lmk.id,  lmk.name, name_bank.name as 'name_bank', lmk.number_money, lmk.date " +
                     "FROM consuption_money_bank lmk " +
                     "inner join name_bank on lmk.id_name_bank = name_bank.id " +
                     $"where lmk.id= '{id}'" +
                     "order by lmk.id desc";

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
                    txt_number_money.Text = dataTable.Rows[0]["number_money"].ToString();
                    combo_list_name_bank.Text = dataTable.Rows[0]["name_bank"].ToString();
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
            string id_name_bank = combo_list_name_bank.SelectedValue.ToString();

            string add_get_money = $"INSERT INTO consuption_money_bank (name, id_name_bank, number_money, date) VALUES ('{name}', '{id_name_bank}', '{nuber_money}', '{date}');";

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
                    consuptionListMoneyBank.display();
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
            string id_name_bank = combo_list_name_bank.SelectedValue.ToString();

            string update_get_money = $"UPDATE consuption_money_bank SET name = '{name}', id_name_bank = '{id_name_bank}', number_money = '{nuber_money}', date = '{date}' WHERE (`id` = '{id}');";

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
                    consuptionListMoneyBank.display();
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

        private void ConsuptionAddMoneyBank_Shown(object sender, EventArgs e)
        {
            loadCombo();
            if (this.id_list_money_bank != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id_list_money_bank);
                btn_creat.Text = "Иваз кардан";
                this.Text = "ИВАЗ КАРДАН";
                group_add_get_money.Text = "ИВАЗ КАРДАН";
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id_list_money_bank == "" && this.text_button == "Сохтан")
            {
                add();
            }
            else
            {
                update(this.id_list_money_bank);
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
