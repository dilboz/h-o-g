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

namespace ObiGarm.Users.Spitalists
{
    public partial class SpitalistFormDisplay : Form
    {

        SqlConfiguration sqlConfiguration;

        public SpitalistFormDisplay()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_admin = "select id, name, surname, login, room_number, work_time_start, work_time_end, enable from users where point = '2' and deleted is null";

            sqlConfiguration.displayList(select_admin, datagridview_admin);
        }

        private void SpitalistFormDisplay_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void datagridview_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[2].Value.ToString();

                AddSpitalist addSpitalist = new AddSpitalist(this, id, "Иваз кардан");
                addSpitalist.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[2].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_admin.Rows[e.RowIndex].Cells[4].Value + " " + datagridview_admin.Rows[e.RowIndex].Cells[5].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteAdmin = $"update users set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
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
            AddSpitalist addSpitalist = new AddSpitalist(this, "", "Сохтан");
            addSpitalist.ShowDialog();
        }
    }
}
