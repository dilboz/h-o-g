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

namespace ObiGarm.Users.Bugalter
{
    public partial class ListBugalter : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        public ListBugalter()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_admin = "select enable, id, name, surname, login from users where point = '5' and deleted IS NULL";
            sqlConfiguration.displayList(select_admin, datagridview_admin);
        }

        private void ListBugalter_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void datagridview_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[3].Value.ToString();

                AddBugalter addBugalter = new AddBugalter(this, id, "Иваз кардан");
                addBugalter.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[3].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_admin.Rows[e.RowIndex].Cells[4].Value + " " + datagridview_admin.Rows[e.RowIndex].Cells[5].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteuser = $"update users set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteuser);
                    if (res2 == 1)
                    {
                        display();

                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми нест кардани Бақайдгир!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddBugalter addBugalter = new AddBugalter(this, "", "Сохтан");
            addBugalter.ShowDialog();
        }
    }
}
