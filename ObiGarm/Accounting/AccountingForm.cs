using ObiGarm.Accounting.ConsumptionMoney;
using ObiGarm.Accounting.ConsumptionMoney.ConsumptionMoneyanBank;
using ObiGarm.Accounting.ConsumptionMoney.ConsumptionMoneyanKassa;
using ObiGarm.Accounting.GetMoneyInBank;
using ObiGarm.Accounting.GetMoneyInKassa;
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

namespace ObiGarm.Accounting
{
    public partial class AccountingForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        public static AccountingForm accountingForm_inctance;
        string type_user;

        public AccountingForm()
        {
            InitializeComponent();
            accountingForm_inctance = this;
        }

        public void colorsButton(int index)
        {
            Button[] bunifuButtons = new Button[] { btn_get_money, btn_get_money_in_kassa, btn_get_money_in_bank, btn_consuption_money, btn_consuption_money_in_kassa, btn_consuption_money_in_bank};

            for (var i = 0; i < bunifuButtons.Length; i++)
            {
                bunifuButtons[i].BackColor = Color.FromArgb(70, 70, 70);
            }

            if (index==1 || index==2)
            {
                bunifuButtons[0].BackColor = Color.FromArgb(100, 100, 100);
                bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            }

            if (index == 4 || index == 5)
            {
                bunifuButtons[3].BackColor = Color.FromArgb(100, 100, 100);
                bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            }


        }

        private void showHideMenu(int index)
        {
            Panel[] panels = new Panel[] { panel_get_money, panel_consumption };

            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i] == panels[index])
                {
                    continue;
                }
                panels[i].Visible = false;
            }

            if (panels[index].Visible == false)
            {
                panels[index].Visible = true;
            }
            else
            {
                panels[index].Visible = false;
            }
        }

        public void setNameAndType()
        {
            check_type_user();
            user_info_label.Text = "Истифодабаранда: " + SettingsDatabase.name_user + " " + SettingsDatabase.surname_user +
                "\nНамуди истифодабаранда: " + type_user;
        }


        void check_type_user()
        {
            if (SettingsDatabase.type_user == "1")
            {
                type_user = "Админ";
            }
            if (SettingsDatabase.type_user == "2")
            {
                type_user = "Спитсалисти";
            }
            if (SettingsDatabase.type_user == "2")
            {
                type_user = "Врач";
            }
            if (SettingsDatabase.type_user == "4")
            {
                type_user = "Бақайдгир";
            }
            if (SettingsDatabase.type_user == "5")
            {
                type_user = "Буғалтер";
            }
        }


        Form activeForm;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_child_all.Controls.Add(childForm);
            this.panel_child_all.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AccountingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_get_money_in_kassa_Click(object sender, EventArgs e)
        {
            colorsButton(1);
            openChildForm(new ListGetMoney());
        }

        private void btn_get_money_Click(object sender, EventArgs e)
        {
            showHideMenu(0);
        }

        private void AccountingForm_Shown(object sender, EventArgs e)
        {
            showHideMenu(0);
            colorsButton(1);
            openChildForm(new ListGetMoney());
        }

        private void btn_consuption_money_Click(object sender, EventArgs e)
        {
            showHideMenu(1);
        }

        private void btn_get_money_in_bank_Click(object sender, EventArgs e)
        {
            colorsButton(2);
            openChildForm(new ListGetMoneyInBank());
        }

        private void btn_consuption_money_in_kassa_Click(object sender, EventArgs e)
        {
            colorsButton(4);
            openChildForm(new ConsuptionListMoneyKassa());
        }

        private void btn_consuption_money_in_bank_Click(object sender, EventArgs e)
        {
            colorsButton(5);
            openChildForm(new ConsuptionListMoneyBank());
        }
    }
}
