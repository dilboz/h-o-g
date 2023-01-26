using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura.Arkhiv;
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
    public partial class Ristratura : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        string type_user;

        public Ristratura()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            setNameAndType();
        }

        private void colorsButton(int index)
        {
            Button[] buttons = new Button[] { btn_home, btn_not_order, btn_block_client, btn_archive, };

            Label[] label_left = new Label[] { left_labl_home, lbl_left_not_order, lbl_left_block_client, lbl_left_archive };


            for (var i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.White;
                buttons[i].ForeColor = Color.FromArgb(118, 120, 124);
                buttons[i].Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_left[i].Hide();
            }

            buttons[index].BackColor = Color.FromArgb(200, 232, 225);
            buttons[index].ForeColor = Color.FromArgb(52, 127, 96);
            buttons[index].Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_left[index].Show();
        }

        public void setNameAndType()
        {
            check_type_user();
            user_info_label.Text =  SettingsDatabase.name_user + " " + SettingsDatabase.surname_user +
                "\n" + type_user;
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

        private void Risrarura_Load(object sender, EventArgs e)
        {
            colorsButton(0);
            openChildForm(new IsClient());
        }

        private void Risrarura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btn_not_order_Click(object sender, EventArgs e)
        {
            colorsButton(1);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            colorsButton(0);
        }

        private void btn_block_client_Click(object sender, EventArgs e)
        {
            colorsButton(2);
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            colorsButton(3);
        }

        private void panel_child_all_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
