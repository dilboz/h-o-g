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
    public partial class AddRoom : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly ListFrameRoom listFrameRoomForm;
        private string text_button;
        public string id;
        public AddRoom(ListFrameRoom listFrameRoom, string id, string text_button)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            listFrameRoomForm = listFrameRoom;
            this.id = id;
            this.text_button = text_button;
        }

        void loadCombo()
        {
            string sql = "SELECT * FROM frame";
            sqlConfiguration.LoadCombo(sql, "name", "id" , combo_frame);
        }

        private void setTextToTextBoxs(string id)
        {
            string sql = "select room.id, frame.name 'name_frame', room.name, room.max_per, room.breakfast ,room.lunch ,room.dinner ,  active " +
                "from room " +
                "inner join frame on room.id_freme = frame.id "+
                "where room.id = '" + id + "'";
            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            if (dataTable == null)
            {
                MessageBox.Show("Хатоги ба вучуд омад!!!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataTable.Rows.Count == 1)
                {
                    combo_frame.Text= dataTable.Rows[0]["name_frame"].ToString();
                    txt_name_room.Text = dataTable.Rows[0]["name"].ToString();
                    txt_max_count.Text = dataTable.Rows[0]["max_per"].ToString();

                    txt_time_breakfast.EditValue = dataTable.Rows[0]["breakfast"].ToString();
                    txt_time_lunch.EditValue = dataTable.Rows[0]["lunch"].ToString();
                    txt_time_dinner.EditValue = dataTable.Rows[0]["dinner"].ToString();

                }
                else
                {
                    MessageBox.Show("Хангоми ёфтани коргар хатоги ба вучуд омад!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (this.id == "" && this.text_button == "Сохтан")
            {
                addRoom();
            }
            else
            {
                updateRoom(this.id);
            }
        }
        private void addRoom()
        {
            if (combo_frame.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_fmame = combo_frame.SelectedValue.ToString();
            string room = txt_name_room.Text;
            string max_per = txt_max_count.Text;
            string breakfast = Convert.ToDateTime(txt_time_breakfast.Text).ToString("HH:mm"); 
            string lunch = Convert.ToDateTime(txt_time_lunch.Text).ToString("HH:mm");
            string dinner = Convert.ToDateTime(txt_time_dinner.Text).ToString("HH:mm");

            string sql_check_farme = $"select * from room  where id_freme = ' { id_fmame } ' and name =' { room.Trim() }' and enable ='1';";

            string sql_add_room = "insert into room (id_freme, max_per, breakfast, lunch, dinner, name) values('" +
               id_fmame + "', '"+
               max_per + "', '" +
               breakfast + "', '" +
               lunch + "', '" +
               dinner + "', '" +
               room.Trim()+"');";

            if (room.Trim() != "")
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

                        listFrameRoomForm.displayRoom();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин ҳуҷра дар система вучуд дорад! Ҳуҷраи дигаро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи ҳуҷраро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void updateRoom(string id)
        {
            if (combo_frame.Text == "")
            {
                MessageBox.Show("Бино интихоб нашуддаст!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            string id_fmame = combo_frame.SelectedValue.ToString();
            string room = txt_name_room.Text;
            string max_per = txt_max_count.Text;

            string breakfast = Convert.ToDateTime(txt_time_breakfast.Text).ToString("HH:mm");
            string lunch = Convert.ToDateTime(txt_time_lunch.Text).ToString("HH:mm");
            string dinner = Convert.ToDateTime(txt_time_dinner.Text).ToString("HH:mm");

            string sql_check_farme = "select * from room  where id_freme = '" + id_fmame + "' and name ='" + room.Trim() + "' and deleted is  null;";


            string sql_update_frame = "update room set " +
                "id_freme = '" + id_fmame + "', " +
                "name = '"+ room.Trim() + "', "+
                "breakfast = '" + breakfast + "', " +
                "lunch = '" + lunch + "', " +
                "dinner = '" + dinner + "', " +
                "max_per = '" + max_per + "' " +
               "where id = '" + id + "'";

            if (room.Trim() != "")
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
                        listFrameRoomForm.displayRoom();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Чунин ҳуҷра дар система вучуд дорад! Ҳуҷраи дигарро интихоб кунед!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("Шумо номи ҳуҷраро дохил накаред!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void AddRoom_Shown(object sender, EventArgs e)
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
    }
}
