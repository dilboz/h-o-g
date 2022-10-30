using ObiGarm.ClassDatabase;
using ObiGarm.Users.Spitalists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Services
{
    public partial class ServicesFormDisplay : Form
    {
        SqlConfiguration sqlConfiguration;
        public ServicesFormDisplay()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void loadListSpitsqlist()
        {
            string sql = "select id, CONCAT_WS(' ', name, surname) as 'name' from users where point = '2' and deleted is null";
            sqlConfiguration.LoadList(sql, "name", "id", list_sipsalist);
        }
        
        public void loadListServices()
        {
            string sql = "select id, name from services where enable= '1' and deleted is null";
            sqlConfiguration.LoadList(sql, "name", "id", list_services);

        }

        public void loadListServicesUser(string id_user)
        {
            string sql = "select services_users.id, services.name as 'name_services' " +
                    "from services_users " +
                    "inner join services on services_users.service_id = services.id " +
                    "where user_id = '" + id_user + "';";
            sqlConfiguration.LoadList(sql, "name_services", "id", list_services_users);

        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            AddSpitalist addSpitalist = new AddSpitalist(this, "", "Сохтан");
            addSpitalist.ShowDialog();
        }

        private void tool_add_spitalist_Click(object sender, EventArgs e)
        {
            AddSpitalist addSpitalist = new AddSpitalist(this, "", "Сохтан");
            addSpitalist.ShowDialog();
        }

        private void tool_edit_spitsalist_Click(object sender, EventArgs e)
        {
            string id = list_sipsalist.SelectedValue.ToString(); 

            AddSpitalist addSpitalist = new AddSpitalist(this, id, "Иваз кардан");
            addSpitalist.ShowDialog();
        }

        private void tool_delete_sipitsalist_Click(object sender, EventArgs e)
        {
            string id = list_sipsalist.SelectedValue.ToString();
            string sql = "select id, CONCAT_WS(' ', name, surname) as 'name' from users where point = '2' and deleted is null and id = '" + id +"'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataTable.Rows[0]["name"].ToString() +" - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update users set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                if (res2 == 1)
                {
                    loadListSpitsqlist();

                }
                else
                {
                    MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            string id = list_sipsalist.SelectedValue.ToString();
            string sql = "select id, CONCAT_WS(' ', name, surname) as 'name' from users where point = '2' and deleted is null and id = '" + id + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataTable.Rows[0]["name"].ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update users set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                if (res2 == 1)
                {
                    loadListSpitsqlist();

                }
                else
                {
                    MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_services_btn_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices(this, "", "Сохтан"); ;
            addServices.Show();
        }

        private void con_menu_add_services_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices(this, "", "Сохтан"); ;
            addServices.Show();
        }

        private void con_menu_edit_services_Click(object sender, EventArgs e)
        {
            string id = list_services.SelectedValue.ToString();
            AddServices addServices = new AddServices(this, id, "Иваз кардан");
            addServices.Show();
        }
        private void delete_services_bbn_Click(object sender, EventArgs e)
        {
            string id = list_services.SelectedValue.ToString();
            string sql = "select id, name from services where deleted is null and id = '" + id + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataTable.Rows[0]["name"].ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update services set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                if (res2 == 1)
                {
                    loadListServices();

                }
                else
                {
                    MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void tool_delete_services_Click(object sender, EventArgs e)
        {
            string id = list_services.SelectedValue.ToString();
            string sql = "select id, name from services where deleted is null and id = '" + id + "'";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + dataTable.Rows[0]["name"].ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update services set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                if (res2 == 1)
                {
                    loadListServices();

                }
                else
                {
                    MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ServicesFormDisplay_Shown(object sender, EventArgs e)
        {
            loadListSpitsqlist();
            loadListServices();
            loadListServicesUser(list_sipsalist.SelectedValue.ToString());
        }

        private void list_sipsalist_Click(object sender, EventArgs e)
        {
            loadListServicesUser(list_sipsalist.SelectedValue.ToString());
        }

        private void delete_service_user_Click(object sender, EventArgs e)
        {
            string id = list_services_users.SelectedValue.ToString();

            string sqlDelete_service_user = "delete from services_users where id = '" + id + "'";
            int res2 = sqlConfiguration.sqlQuery(sqlDelete_service_user);
            if (res2 == 1)
            {
                loadListServicesUser(list_sipsalist.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show(@"Хатоги хангоми нест кардани хизматрасони ба спитсалист додашуда!" + Environment.NewLine + "!!!Агар шумо бо чунин бино ҳуҷра сохтаги бошед." + Environment.NewLine + "Биноро нест карда наметавонед", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sevices_to_users_Click(object sender, EventArgs e)
        {
            string id_services = list_services.SelectedValue.ToString();
            string id_users = list_sipsalist.SelectedValue.ToString();

            string sql_check_services_user = "";


        }
    }
}
