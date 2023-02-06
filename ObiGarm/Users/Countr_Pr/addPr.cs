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

namespace ObiGarm.Users.Countr_Pr
{
    public partial class addPr : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly CountryRro countryRro;
        private string text_button;
        public string id;

        public addPr(CountryRro countryRro, string text_button, string id)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.countryRro = countryRro;
            this.text_button = text_button;
            this.id = id;
        }

        void loadCombo()
        {
            string sql = "SELECT * FROM country";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_country);
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select province.id, country.name 'name_country', province.name " +
                "from province " +
                "inner join country on province.id_country = country.id " +
                "where province.id = '" + id + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    combo_country.Text = dataTable.Rows[0]["name_country"].ToString();
                    txt_name_pr.Text = dataTable.Rows[0]["name"].ToString();
                   

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани вилоят хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void addPrVoid()
        {
            if (combo_country.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_country = combo_country.SelectedValue.ToString();
            string pr = txt_name_pr.Text;

            string sql_check_farme = $"select * from province  where id_country = ' { id_country } ' and name =' { pr.Trim() }';";

            string sql_add_room = "insert into province (id_country, name) values('" +
               id_country + "', '" +
               
               pr.Trim() + "');";

            if (pr.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_check_farme).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_room);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        countryRro.displayPr();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин вилоят дар система вучуд дорад! Ҳуҷраи дигаро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи виляот дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void updateRoom(string id)
        {
            if (combo_country.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_county = combo_country.SelectedValue.ToString();
            string pr = txt_name_pr.Text;

            string sql_check_farme = "select * from province  where id_country = '" + id_county + "' and name ='" + pr.Trim() + "';";


            string sql_update_frame = "update province set " +
                "id_country = '" + id_county + "', " +
                $"name = ' " + pr.Trim() + $"' where id ='{id}'";

            if (pr.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_check_farme).Rows.Count <= 1)
                {
                    int result = sqlConfiguration.sqlQuery(sql_update_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        countryRro.displayPr();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин виляот дар система вучуд дорад! Ҳуҷраи дигарро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи виляот дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void addPr_Shown(object sender, EventArgs e)
        {
            loadCombo();
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
                group_name_frame.Text = "ИВАЗ КАРДАН";
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                addPrVoid();
            }
            else
            {
                updateRoom(this.id);
            }
        }
    }
}
