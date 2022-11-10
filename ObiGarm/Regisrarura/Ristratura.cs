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
            Button[] bunifuButtons = new Button[] { create_clieant, client_of_bugalter, acrive_client};

            for (var i = 0; i < bunifuButtons.Length; i++)
            {
                bunifuButtons[i].BackColor = Color.FromArgb(70, 70, 70);
            }

            bunifuButtons[index].BackColor = Color.FromArgb(100, 100, 100);
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
            openChildForm(new AddCllient());
        }

        private void Risrarura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void client_of_bugalter_Click(object sender, EventArgs e)
        {
            colorsButton(1);
            openChildForm(new NoClientYet());
        }

        private void create_clieant_Click(object sender, EventArgs e)
        {
            colorsButton(0);
            openChildForm(new AddCllient());
        }

        private void acrive_client_Click(object sender, EventArgs e)
        {
            colorsButton(2);
            openChildForm(new IsClient());
        }
    }
}
