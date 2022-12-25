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
        }

        void add_money(string id)
        {
            string number_money = txt_number_money.Text.Trim();
            string comment_money = txt_commen_money.Text.Trim();

            string sql = $"UPDATE client SET nuber_money = '{number_money}', comment_money = '{comment_money}', is_for_vrach = '1' WHERE id = '{id}'";

            if (number_money!="" && comment_money!="")
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
                MessageBox.Show("Дохил кардани миқдори маблағ ва шарҳи маблағ хатмӣ аст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
