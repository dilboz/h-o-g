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

namespace ObiGarm.Restorant
{
    public partial class RestorantForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private string id_type_kort;
        public RestorantForm()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            label_info_user.Text = $"Истифодабаранда: {SettingsDatabase.surname_user + " " + SettingsDatabase.name_user}";
            DataTable data_table_ = sqlConfiguration.sqlSelectQuery($"select * from users where id='{SettingsDatabase.id_user}'");
            id_type_kort = data_table_.Rows[0]["type_kort"].ToString();
            display_count();
        }

        public void display()
        {
            string sql = "select client.number_order, client.id, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', client.date_time_start, client.date_time_end, type_kort.name as 'type_kort' " +
                         "from client " +
                         "inner join kort on client.id_kort = kort.id " +
                         "inner join type_kort on kort.id_type_kort = type_kort.id " +
                         "where client.is_for_vrach=1 and client.enable=1 and client.deleted is null and client.is_arkhiv='0'" +
                         "order by id desc ";
            sqlConfiguration.displayListExpress(sql, grid_control_is_client);
        }

        private void RestorantForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void RestorantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        void check_klient(string kod_kort)
        {
                string sql_select = $"select kort.kod_kort, kort.id_type_kort " +
                                   "from client " +
                                   "inner join kort on client.id_kort = kort.id " +
                                   $"where" +
                                   $" (client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end>= '{DateTime.Now.ToString("yyyy-MM-dd")}') and kort.kod_kort = '{kod_kort}' and kort.id_type_kort='{id_type_kort}'; ";

            if (sqlConfiguration.sqlSelectQuery(sql_select).Rows.Count!=0) MessageBox.Show("Хуш омадед!");
            else MessageBox.Show("Хуш naомадед!");
        }

        void display_count()
        {
            string sql_select_today = $"select kort.kod_kort, kort.id_type_kort " +
                                      "from client " +
                                      "inner join kort on client.id_kort = kort.id " +
                                      $"where" +
                                      $" (client.date_time_start <= '{DateTime.Now.ToString("yyyy-MM-dd")}' and client.date_time_end>= '{DateTime.Now.ToString("yyyy-MM-dd")}'); ";
            
            string sql_select = $"select kort.kod_kort, kort.id_type_kort " +
                                 "from client " +
                                 "inner join kort on client.id_kort = kort.id " +
                                  $"where" +
                                  $" (client.date_time_start <= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}' and client.date_time_end>= '{DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}'); ";

            lbl_info_today.Text = $"Миқдори одамони имруз меомада: {sqlConfiguration.sqlSelectQuery(sql_select_today).Rows.Count} нафар";

            lbl_info_day.Text = $"Миқдори одамони фардо меомада: {sqlConfiguration.sqlSelectQuery(sql_select).Rows.Count} нафар";

        }

        private void txt_kort_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_kort.Text.Length == 20)
            {
                txt_kort.Text = txt_kort.Text.Substring(10, 10);
                check_klient(txt_kort.Text);
                btn_ansver.Focus();
                txt_kort.Focus();
            }
            if (txt_kort.Text.Length == 10)
            {
                check_klient(txt_kort.Text);
                btn_ansver.Focus();
                txt_kort.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            display_count();
        }

        private void btn_ansver_Click(object sender, EventArgs e)
        {
            btn_ansver.Focus();
            txt_kort.Focus();
        }
    }
}
