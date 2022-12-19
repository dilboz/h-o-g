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

namespace ObiGarm.Users.Frame
{
    public partial class AddFrame : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly ListFrameRoom listFrameRoomForm;
        private string text_button;
        public string id;
        public AddFrame(ListFrameRoom listFrameRoom, string id, string text_button)
        {
            sqlConfiguration = new SqlConfiguration();
            listFrameRoomForm = listFrameRoom;
            this.id = id;
            this.text_button = text_button;
            InitializeComponent();
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select * from frame where id = '" + id + "'";

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
                   
                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани бино хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void AddFrame_Shown(object sender, EventArgs e)
        {
            if (this.id != "" && this.text_button != "Сохтан")
            {
                setTextToTextBoxs(this.id);
                btn_creat.Text = "Иваз кардан";
                group_name_frame.Text = "ИВАЗ КАРДАНИ АДМИН";
            }
        }

        private void addFrame()
        {
            string name_frame = txt_name.Text;
            string sql_user_farme= "select * from frame where name = '" + name_frame + "'";

            string sql_add_frame = "insert into frame (name) values('" +
               name_frame.ToUpper() + "');";

            if (name_frame.Trim()!="")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_farme).Rows.Count == 0)
                {
                    int result = sqlConfiguration.sqlQuery(sql_add_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        listFrameRoomForm.displayFrame();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин бино дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи биноро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void addUpdate(string id)
        {
            string name_frame = txt_name.Text;
            string sql_user_farme = "select * from frame where name = '" + name_frame + "'";

            
            string sql_update_frame = "update frame set " +
                "name = '" + name_frame.ToUpper() + "' " +
               " where id = '" + id + "'";

            if (name_frame.Trim() != "")
            {
                if (sqlConfiguration.sqlSelectQuery(sql_user_farme).Rows.Count >= 1)
                {
                    int result = sqlConfiguration.sqlQuery(sql_update_frame);
                    if (result == 500)
                    {
                        MessageBox.Show("Хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        listFrameRoomForm.displayFrame();
                        listFrameRoomForm.displayRoom();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин бино дар система вучуд дорад! Логини дигар интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи биноро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                addFrame();
            }
            else
            {
                addUpdate(this.id);
            }
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
