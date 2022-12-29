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
    public partial class ListFrameRoom : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        public ListFrameRoom()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void displayFrame()
        {
            string select_admin = "select id, name from frame";
            sqlConfiguration.displayList(select_admin, datagridview_frame);
        }

        public void displayRoom()
        {
            string select_admin = "select room.id, frame.name 'name_frame', room.name, room.max_per " +
                "from room " +
                "inner join frame on room.id_freme = frame.id";
            sqlConfiguration.displayList(select_admin, datagridview_room);
        }

        private void ListFrameRoom_Shown(object sender, EventArgs e)
        {
            displayFrame();
            displayRoom();
        }

        private void datagridview_frame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = datagridview_frame.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.ColumnIndex == edit.Index)
            {


                AddFrame addFrame = new AddFrame(this, id, "Иваз кардан");
                addFrame.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_frame.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteRoom = "delete from frame where id = '" + id + "'";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteRoom);
                    if (res2 == 1)
                    {
                        displayFrame();

                    }
                    else
                    {
                        MessageBox.Show(@"Хатоги хангоми нест кардани Бино!" + Environment.NewLine + "!!!Агар шумо бо чунин бино ҳуҷра сохтаги бошед." + Environment.NewLine + "Биноро нест карда наметавонед", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void add_room_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom(this, "", "Сохтан");
            addRoom.ShowDialog();
        }

        private void add_frame_Click(object sender, EventArgs e)
        {
            AddFrame addFrame = new AddFrame(this, "", "Сохтан");
            addFrame.ShowDialog();
        }

        private void datagridview_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = datagridview_room.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.ColumnIndex == edit.Index)
            {
                AddRoom addroom = new AddRoom(this, id, "Иваз кардан");
                addroom.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_room.Rows[e.RowIndex].Cells[4].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteAdmin = "delete from room where id = '" + id + "'";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                    if (res2 == 1)
                    {
                        displayRoom();

                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми нест кардани ҳуҷра!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
