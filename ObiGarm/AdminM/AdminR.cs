using DevExpress.XtraReports.UI;
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

namespace ObiGarm.AdminM
{
    public partial class AdminR : Form
    {
        public AdminR()
        {
            InitializeComponent();
            setNameAndType();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        public void setNameAndType()
        {
            user_info_label.Text = "Истифодабаранда: " + SettingsDatabase.name_user + " " + SettingsDatabase.surname_user +
                "\nНамуди истифодабаранда: " + check_type_user();
        }

        string check_type_user()
        {
            if (SettingsDatabase.type_user == "1")
            {
                return  "Админ";
            }
            if (SettingsDatabase.type_user == "2")
            {
                return  "Врач";
            }
            if (SettingsDatabase.type_user == "3")
            {
                return  "Бақайдгир";
            }
            else{
                return "Админ";
            }
        }

        Form activeForm;
        public void openChildForm(Panel selectedPanel, Form childForm)
        {
            //if (activeForm != null)
            //{
            //    activeForm.Close();
            //}

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            selectedPanel.Controls.Add(childForm);
            selectedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AdminR_Load(object sender, EventArgs e)
        {
            openChildForm(tab_info_all, new AdminM.State());
            openChildForm(tab_hujrai_tashkhisi, new Administration.InfoReportsFromMoney());
            openChildForm(tab_tainot_dukhtur, new Reports.ReportsForm.ReportOne());
            openChildForm(tab_antrometri, new Reports.ReportsForm.ReportTwo());
            openChildForm(tartibi_ruz, new Reports.ReportsForm.ReportThree());
            openChildForm(tabPage1, new Reports.ReportsForm.ReportFour());

            
        }

        private void AdminR_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}
