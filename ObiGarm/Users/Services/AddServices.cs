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

namespace ObiGarm.Services
{
    
    public partial class AddServices : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly ServicesFormDisplay servicesFormDisplayForm;
        private string text_button;
        public string id;
        public AddServices(ServicesFormDisplay servicesFormDisplay, string id, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            servicesFormDisplayForm = servicesFormDisplay;
            this.id = id;
            this.text_button = text_button;
        }
        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from services where id = '" + id + "'";
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
                    txt_time_services.EditValue = dataTable.Rows[0]["time_services"].ToString();

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани хизматрасони хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        void addServices()
        {
            string name_services = txt_name.Text.Trim();
            string time_setvices = Convert.ToDateTime(txt_time_services.Text).ToString("HH:mm");

            string sql_chage_services= "select* from services where name = '" + name_services + "' and time_services = '" + time_setvices + "';";
            
            string sql_add_services= "insert into services (name, time_services) values('" +
               name_services + "', '" +
               time_setvices + "');";

            if (Name != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_chage_services).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_services);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        servicesFormDisplayForm.allDisplayList();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин хизматрамони дар система вучуд дорад! Ҳуҷраи дигаро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи хизматрамони дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        void updateServices(string id)
        {
            string name_services = txt_name.Text.Trim();
            string time_setvices = Convert.ToDateTime(txt_time_services.Text).ToString("HH:mm");

            string sql_chage_services = "select * from services where id = '" + id +"';";

            

            string sql_update_services = "update services set " +
                "name = '" + name_services + "', " +
                "time_services = '" + time_setvices + "' " +
               "where id = '" + id + "'";

            if (Name != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_chage_services).Rows.Count >=1)
                {
                    int result = sqlConfiguration.sqlQuery(sql_update_services);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        servicesFormDisplayForm.allDisplayList();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин хизматрамони дар система вучуд дорад! Ҳуҷраи дигаро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи хизматрамони дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                addServices();
            }
            else
            {
                updateServices(this.id);
            }
        }
        private void AddServices_Shown(object sender, EventArgs e)
        {
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
                group_services.Text = "ИВАЗ КАРДАНИ АДМИН";
                this.Text = "ИВАЗ КАРДАНИ АДМИН";
            }
        }
    }
}
