﻿using ObiGarm.ClassDatabase;
using System;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura.Lists
{
    public partial class ListRoom : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly AddCllient addCllient_;
        public ListRoom(AddCllient addCllient)
        {
            addCllient_ = addCllient;
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }
        string id_room;
        void dispLay()
        {
            string sql = "select room.id, concat('Бинои ', frame.name, ' Ҳучраи ',  room.name) as 'name_room' " +
                         "from room " +
                         "inner join frame on room.id_freme = frame.id and active =0;";
            sqlConfiguration.LoadList(sql, "name_room", "id", list_load_room);
        }

        private void ListRoom_Shown(object sender, EventArgs e)
        {
            dispLay();
            if (list_load_room.ItemCount == 0)
            {
                MessageBox.Show("Дар система бино ва ҳуҷра надоред", "Хатоги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_room.PlaceholderText = "Дар система бино ва ҳуҷра надоред";
            }
            else
            {
                id_room = list_load_room.SelectedValue.ToString();

                txt_room.Text = list_load_room.GetDisplayItemValue(0).ToString();
            }

        }



        private void btn_inser_docrot_Click(object sender, EventArgs e)
        {
            string sql = $"update room SET active = '1' where id = {id_room}";
            sqlConfiguration.sqlSelectQuery(sql);
            addCllient_.name_room = txt_room.Text;
            addCllient_.id_room = id_room;
            this.Close();
        }

        private void list_load_room_Click(object sender, EventArgs e)
        {
            id_room = list_load_room.SelectedValue.ToString();
            txt_room.Text = list_load_room.GetDisplayItemValue(list_load_room.SelectedIndex).ToString();
        }

        private void btn_clear_doctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
