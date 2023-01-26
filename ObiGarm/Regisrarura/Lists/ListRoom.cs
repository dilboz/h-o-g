using ObiGarm.ClassDatabase;
using System;
using System.Data;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura.Lists
{
    public partial class ListRoom : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly AddCllient addCllient_;
        private string room_id;
        private string name_room_and_frame;
        public ListRoom(AddCllient addCllient,  string id_room)
        {
            addCllient_ = addCllient;
            this.room_id = id_room;
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            loadCombo();
        }

        void displayInfo(string id)
        {
            string sql = $"select * from room where id ='{id}';";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql);

            label_info.Appearance.Options.UseTextOptions = true;

            label_info.Text = $"<b>--- <color=255, 0, 0>-{name_room_and_frame}-</color>---</b><br>" +
                              $"<b>Наҳорӣ:</b>  <color=255, 0, 0>-{dataTable.Rows[0]["breakfast"].ToString()} -</color><br>" +
                              $"<b>Хуроки нисфирӯзӣ:</b>  <color=255, 0, 0>-{dataTable.Rows[0]["lunch"].ToString()} -</color><br>" +
                              $"<b>Хуроки пагоҳирӯҳӣ:</b>  <color=255, 0, 0>-{dataTable.Rows[0]["dinner"].ToString()} -</color><br>";

        }

        string id_room;
        void dispLay(string id)
        {
            string sql = "select room.id, concat('Бинои ', frame.name, ' Ҳучраи ',  room.name, ' (', room.count_per, ')') as 'name_room' " +
                         "from room " +
                         $"inner join frame on room.id_freme = frame.id where active =0 and frame.id = '{id}'";
            sqlConfiguration.LoadList(sql, "name_room", "id", list_load_room);
        }

        void loadCombo()
        {
            string sql = "SELECT * FROM frame";
            sqlConfiguration.LoadCombo(sql, "name", "id", combo_frame);
        }

        private void ListRoom_Shown(object sender, EventArgs e)
        {
            if (combo_frame.Items.Count!=0) dispLay(combo_frame.SelectedValue.ToString());
            else
            {
                messDilalog.Text = "Дар система бино надоред";
                messDilalog.Show();
                this.Close();
            }
          
            if (list_load_room.ItemCount == 0)
            {
                messDilalog.Text = "Дар система бино ва ҳуҷра надоред";
                messDilalog.Show();
                this.Close();
            }
            else
            {
                id_room = list_load_room.SelectedValue.ToString();
                name_room_and_frame = list_load_room.GetDisplayItemValue(0).ToString();
                displayInfo(list_load_room.SelectedValue.ToString());
            }

            
        }

        private void combo_frame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_frame.Items.Count != 0) dispLay(combo_frame.SelectedValue.ToString());
            else
            {
                messDilalog.Text = "Дар система бино надоред";
                messDilalog.Show();
                this.Close();
            }
        }

        private void list_load_room_Click(object sender, EventArgs e)
        {
            id_room = list_load_room.SelectedValue.ToString();
            name_room_and_frame = list_load_room.GetDisplayItemValue(list_load_room.SelectedIndex).ToString();
            displayInfo(list_load_room.SelectedValue.ToString());
        }

        private void btn_clear_doctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inser_docrot_Click(object sender, EventArgs e)
        {
            if (room_id != "")
            {
                addCllient_.name_room = name_room_and_frame;
                addCllient_.id_room = id_room;
            }
            else
            {
                string sql_query = $"update  room set active = '0', count_per = count_per -1 where id = '{room_id}'";
                sqlConfiguration.sqlQuery(sql_query);

                addCllient_.name_room = name_room_and_frame;
                addCllient_.id_room = id_room;
            }
            this.Close();
        }
    }
}
