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

namespace ObiGarm.Regisrarura
{
    public partial class MoneyForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly NoClientYet noClientYet_from;
        public string id_client_me;
        public MoneyForm(NoClientYet noClientYet, string id_client)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            noClientYet_from = noClientYet;
            id_client_me = id_client;
            setTextTotextboxs(id_client);
        }

        void setTextTotextboxs(string id)
        {
            DataTable table_selecte_client = sqlConfiguration.sqlSelectQuery($"select * from client where id = '{id}';");

            if (table_selecte_client.Rows.Count!=0)
            {
                txt_nuber_order.Text = table_selecte_client.Rows[0]["number_order"].ToString();
                txt_number_money.Text = table_selecte_client.Rows[0]["nuber_money"].ToString();
            }
            else
            {
                MessageBox.Show("Ханоги ҳангоми ёфтани текст");
            }
        }

        void add_money(string id)
        {
            string number_money = txt_number_money.Text.Trim();
            string nuber_order = txt_nuber_order.Text.Trim();

            string sql = $"UPDATE client SET nuber_money = '{number_money}', number_order = '{nuber_order}' WHERE id = '{id}'";

            if (nuber_order!="" || nuber_order != "0")
            {
                if (number_money != "")
                {
                    int result = sqlConfiguration.sqlQuery(sql);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        noClientYet_from.display();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Дохил кардани миқдори маблағ хатмӣ аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Шумо рақами ОРДЕР- ро дохил накардед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_money_Click(object sender, EventArgs e)
        {
            if (id_client_me!="")
            {
                add_money(id_client_me);
            }
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_save_money_Click_1(object sender, EventArgs e)
        {
            if (txt_number_money.Text!="0" || txt_number_money.Text!="")
            {
                add_money(id_client_me);
                noClientYet_from.display();
            }
        }
    }
}
