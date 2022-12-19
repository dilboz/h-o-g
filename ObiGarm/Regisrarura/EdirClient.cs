using ObiGarm.ClassDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura
{
    public partial class EdirClient : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly IsClient isClientFrom;
        public string id_client;
        private DataTable dataTable_me;
        private bool is_not_money;
        private string id_vrach_me;
        private string id_room;
        private string id_kort;
        public EdirClient(IsClient isClient, string id)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            isClientFrom = isClient;
            id_client = id;
            displaySex();
            setTextToTextbox(id_client);
        }

        void displaySex()
        {
            string sql = "select * from sex";
            sqlConfiguration.LoadCombo(sql, "name", "id", com_sex);
        }

        private string setsex(string id)
        {
            string sql = $"select name from sex where id={id}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            return dataTable.Rows[0]["name"].ToString(); 
        }

        void change_money()
        {
            if (radio_is_money.Checked==true)
            {
                panel3.Visible = true;
                is_not_money = true;

                txt_number_money.Text = dataTable_me.Rows[0]["nuber_money"].ToString(); ;
                txt_commen_money.Text = dataTable_me.Rows[0]["comment_money"].ToString();
            }
            if (radio_no_money.Checked == true)
            {
                panel3.Visible = false;
                is_not_money = true;
            }
        }

        void money_change(int money_my_id)
        {
            if (money_my_id == 1)
            {
                is_not_money = true;
                panel3.Visible = true;
                radio_is_money.Checked = true;
                radio_no_money.Checked = false;
            }
            else
            {
                is_not_money = false;
                panel3.Visible = false;
                radio_is_money.Checked = false;
                radio_no_money.Checked = true;
            }
        }

        void setmoney(string index_money)
        {
            if (index_money=="0")
            {
                radio_is_money.Checked = false;
                radio_no_money.Checked = true;
            }
            else
            {
                radio_is_money.Checked = true;
                radio_no_money.Checked = false;
            }
            change_money();
        }

        private string name_vrach(string id_vrach)
        {
            string sql = $"select id, concat(surname, ' ', name, ' (', summa_cliet, ')') as 'full_name'  from users where id={id_vrach}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            id_vrach_me= dataTable.Rows[0]["id"].ToString();
            return dataTable.Rows[0]["full_name"].ToString();
        }

        private string room(string id_vrach)
        {
            string sql = "select room.id, concat('Бинои ', frame.name, ' Ҳуҷраи ', room.name) as 'name_room' " +
                         "from room "+
                         "inner join frame on room.id_freme = frame.id "+"" +
                         $"where room.id = {id_vrach}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            id_room = dataTable.Rows[0]["id"].ToString();
            return dataTable.Rows[0]["name_room"].ToString();
        }

        private string kort(string id_kort) {

            string sql = "select kort.id, type_kort.name " +
                        "from kort " +
                        "inner join type_kort on kort.id_type_kort = type_kort.id " + 
                        $"where kort.id = {id_kort}";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            id_kort = dataTable.Rows[0]["id"].ToString();
            return dataTable.Rows[0]["name"].ToString();
        }

        private void setTextToTextbox(string id)
        {
            string sql = $"select * from client where id= {id};";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);
            dataTable_me = dataTable;
            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {

                    txt_surname.Text = dataTable.Rows[0]["surname"].ToString();
                    txt_name.Text = dataTable.Rows[0]["name"].ToString();
                    txt_name_patronymic.Text = dataTable.Rows[0]["patromic"].ToString();
                    date_birthday.Value = Convert.ToDateTime(dataTable.Rows[0]["birthday"].ToString());
                    com_sex.Text = setsex(dataTable.Rows[0]["id_sex"].ToString());
                    date_first_dey.Value= Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());
                    time_first_dey.EditValue= Convert.ToDateTime(dataTable.Rows[0]["date_time_start"].ToString());                    
                    date_end_dey.Value= Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());
                    time_end_dey.EditValue = Convert.ToDateTime(dataTable.Rows[0]["date_time_end"].ToString());
                    setmoney(dataTable.Rows[0]["money"].ToString());
                    txt_name_doctor.Text = name_vrach(dataTable.Rows[0]["id_varch"].ToString());
                    txt_room.Text = room(dataTable.Rows[0]["id_room"].ToString());
                    txt_kort.Text = kort(dataTable.Rows[0]["id_kort"].ToString());
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }


        void updateClient(string id)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void radio_is_money_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_no_money_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_no_money_Click(object sender, EventArgs e)
        {
            money_change(0);
        }

        private void radio_is_money_Click(object sender, EventArgs e)
        {
            money_change(1);
        }
    }
}
