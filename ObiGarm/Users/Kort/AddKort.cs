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

namespace ObiGarm.Users.Kort
{
    public partial class AddKort : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private readonly ListKort listKort;
        private string text_button;
        public string id;
        public AddKort()
        {
            InitializeComponent();
        }

        public AddKort(ListKort listKort, string id, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();

            this.listKort = listKort;
            this.text_button = text_button;
            this.id = id;

            loadCombo();
        }

        void loadCombo()
        {
            string sql = "SELECT * FROM type_kort";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_type_kort);
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select kort.id, kort.kod_kort, tk.name " +
                "from kort " +
                "inner join type_kort tk on kort.id_type_kort = tk.id " +
                $"where deleted is  null and kort.id = '{id}'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    combo_type_kort.Text = dataTable.Rows[0]["name"].ToString();
                    txt_number_kort.Text = dataTable.Rows[0]["kod_kort"].ToString();

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани корт хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void add()
        {
            if (combo_type_kort.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_type_kort = combo_type_kort.SelectedValue.ToString();
            string number_kort = txt_number_kort.Text;
            string sql_check_kort = "select * from kort  where id_type_kort = '" + id_type_kort + "' and kod_kort ='" + number_kort.Trim() + "' and deleted is  null;";

            string sql_add_kort = "insert into kort (id_type_kort, kod_kort) values('" +
               id_type_kort + "', '" +
               number_kort.Trim() + "');";

            if (number_kort.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_check_kort).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_kort);
                    if (result == 500)
                    {
                        txt_number_kort.Text = sql_add_kort;
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        listKort.display();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин корт дар система вучуд дорад! Ҳуҷраи дигаро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо рамзи кортро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void update(string id)
        {
            if (combo_type_kort.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_type_kort = combo_type_kort.SelectedValue.ToString();
            string number_kort = txt_number_kort.Text;
            string sql_check_kort = "select * from kort  where id_type_kort = '" + id_type_kort + "' and kod_kort ='" + number_kort.Trim() + "' and deleted is  null;";


            string sql_update_frame = "update kort set " +
                    "id_type_kort = '" + id_type_kort + "', " +
                    "kod_kort = '" + number_kort.Trim() + "' " +
                   "where id = '" + id + "'";

                if (number_kort.Trim() != "")
                {
                    if (sqlConfiguration.sqlSelectQuery(sql_check_kort).Rows.Count <= 1)
                    {
                        int result = sqlConfiguration.sqlQuery(sql_update_frame);
                        if (result == 500)
                        {
                            MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            listKort.display();

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Чунин корт дар система вучуд дорад! Ҳуҷраи дигарро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Шумо рамзи кортро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                add();
            }
            else
            {
                update(this.id);
            }
        }

        private void AddKort_Shown(object sender, EventArgs e)
        {
            loadCombo();
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
                group_add_get_kort.Text = "ИВАЗ КАРДАН";
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_number_kort_TextChanged(object sender, EventArgs e)
        {
            if (txt_number_kort.Text.Length == 20)
            {
                txt_number_kort.Text = txt_number_kort.Text.Substring(10, 10);
                combo_type_kort.Focus();
                txt_number_kort.Focus();
            }
        }
    }
}
