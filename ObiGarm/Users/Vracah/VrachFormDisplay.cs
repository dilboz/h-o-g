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

namespace ObiGarm.Users.Vracah
{
    public partial class VrachFormDisplay : Form
    {
        SqlConfiguration sqlConfiguration;

        public VrachFormDisplay()
        {
            InitializeComponent();

            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_admin = "select id, name, surname, login, room_number, work_time_start, work_time_end, enable from users where point = '3' ";

            sqlConfiguration.displayList(select_admin, datagridview_admin);
        }

        private void VrachFormDisplay_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void datagridview_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddVrach addVrach=new AddVrach (this, id, "Иваз кардан");
                addVrach.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_admin.Rows[e.RowIndex].Cells[4].Value + " " + datagridview_admin.Rows[e.RowIndex].Cells[5].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteAdmin = "delete from users where id = '" + id + "'";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                    if (res2 == 1)
                    {
                        display();

                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddVrach addVrach = new AddVrach(this, "", "Сохтан");
            addVrach.ShowDialog();
        }
    }
}
