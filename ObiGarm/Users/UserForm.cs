using Bunifu.UI.WinForms.BunifuButton;
using ObiGarm.ClassDatabase;
using ObiGarm.Reports.ReportsForm;
using ObiGarm.Services;
using ObiGarm.Users.Admin;
using ObiGarm.Users.Administration;
using ObiGarm.Users.Bonk;
using ObiGarm.Users.Bugalter;
using ObiGarm.Users.Countr_Pr;
using ObiGarm.Users.Frame;
using ObiGarm.Users.Kort;
using ObiGarm.Users.Registar;
using ObiGarm.Users.Restorant;
using ObiGarm.Users.Spitalists;
using ObiGarm.Users.Vracah;
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

namespace ObiGarm.Users
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        string type_user;
        public UserForm()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            setNameAndType();
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

        public void setNameAndType()
        {
            check_type_user();
            user_info_label.Text = "Истифодабаранда: " + SettingsDatabase.name_user + " " + SettingsDatabase.surname_user +
                "\nНамуди истифодабаранда: " + type_user;
        }
        void  check_type_user()
        {          
            if (SettingsDatabase.type_user=="1")
            {
                type_user = "Админ";
            }
            if (SettingsDatabase.type_user == "2")
            {
                type_user = "Врач";
            }
            if (SettingsDatabase.type_user == "3")
            {
                type_user = "Бақайдгир";
            }
        }


        private void showHideMenu(int index)
        {
            Panel[] panels = new Panel[] {panel_user, servises_frame_panel, panel_reports};

            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i]==panels[index])
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

        private void colorsButton(int index)
        {
            Button[] bunifuButtons = new Button[] { main_button, user_button, admin_button, vrach_button,
            registr_button, spitalists_button, bugalter_button, report_c, reference_button, frame_and_room, servicesis_btn, btn_kort, bonk_button, 
                export_database_button, reports_button, administrator_button, restotonant_and_oshkhina, button_country};

            for (var i = 0; i < bunifuButtons.Length; i++)
            {
                bunifuButtons[i].BackColor = Color.FromArgb(70, 70, 70);
            }

            if (index==2 || index==3 || index==4 || index==5 || index==6 || index == 15 || index == 16 || index == 17)
            {
                bunifuButtons[1].BackColor = Color.FromArgb(100, 100, 100);
                bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            }
            else if (index == 8 || index == 9 || index == 10 || index == 11 )
            {
                bunifuButtons[7].BackColor = Color.FromArgb(100, 100, 100);
                bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            }
            //else if (index == 15 || index == 16 || index == 17 )
            //{
            //    bunifuButtons[14].BackColor = Color.FromArgb(100, 100, 100);
            //    bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            //}
            else
            {
                bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
            }


        }

        private void user_button_Click(object sender, EventArgs e)
        {
            colorsButton(1);
            showHideMenu(0);
        }

        private void reports_button_Click(object sender, EventArgs e)
        {

            showHideMenu(2);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            colorsButton(14);
            colorsButton(0);
        }

        private void main_button_Click(object sender, EventArgs e)
        {
            colorsButton(0);
        }




        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void service_button_Click(object sender, EventArgs e)
        {
            showHideMenu(1);
            colorsButton(7);
        }

        private void frame_and_room_Click(object sender, EventArgs e)
        {
            colorsButton(8);
            openChildForm(new ListFrameRoom());
        }

        private void servicesis_btn_Click(object sender, EventArgs e)
        {
            colorsButton(9);
            openChildForm(new ServicesFormDisplay());
        }



        private void report_a_Click(object sender, EventArgs e)
        {
            colorsButton(15);
            openChildForm(new ReportOne());
            
        }

        private void report_b_Click(object sender, EventArgs e)
        {
            colorsButton(16);
            openChildForm(new ReportTwo());
        }

        private void report_c_Click(object sender, EventArgs e)
        {
            colorsButton(17);
        }

        private void bonk_button_Click(object sender, EventArgs e)
        {
            colorsButton(12);
            openChildForm(new ListBonk());
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_kort_Click(object sender, EventArgs e)
        {
            colorsButton(11);
            openChildForm(new ListKort());
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            colorsButton(2);
            openChildForm(new AdminFormDisplay());
        }

        private void vrach_button_Click(object sender, EventArgs e)
        {
            colorsButton(3);
            openChildForm(new VrachFormDisplay());
        }

        private void registr_button_Click(object sender, EventArgs e)
        {
            colorsButton(4);
            openChildForm(new RegistarFormDisplay());
        }

        private void spitalists_button_Click(object sender, EventArgs e)
        {
            colorsButton(5);
            openChildForm(new SpitalistFormDisplay());
        }

        private void bugalter_button_Click(object sender, EventArgs e)
        {
            colorsButton(6);
            openChildForm(new ListBugalter());
        }

        private void administrator_button_Click(object sender, EventArgs e)
        {
            colorsButton(15);
            openChildForm(new ListAdministrator());

        }

        private void restotonant_and_oshkhina_Click(object sender, EventArgs e)
        {
            colorsButton(16);
            openChildForm(new ListRestorant());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorsButton(17);
            openChildForm(new CountryRro()); 
        }
    }
}
