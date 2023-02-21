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

namespace ObiGarm.Users.Restorant
{
    public partial class ListRestorant : Form
    {
        SqlConfiguration sqlConfiguration;

        public ListRestorant()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_restorant = "select users.id, users.name as 'name', users.surname, users.login, type_kort.name as 'type_kort' " +
                "from users " +
                "inner join type_kort on users.type_kort = type_kort.id " +
                "where users.point='7' and  deleted is null; ";
            sqlConfiguration.displayList(select_restorant, datagridview_restorant);
        }

        private void ListRestorant_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            AddResrorant addResrorant = new AddResrorant(this, "", "Сохтан");
            addResrorant.ShowDialog();
        }

        private void datagridview_restorant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                string id = datagridview_restorant.Rows[e.RowIndex].Cells[3].Value.ToString();

                AddResrorant addResrorant = new AddResrorant(this, id, "Иваз кардан");
                addResrorant.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                string id = datagridview_restorant.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_restorant.Rows[e.RowIndex].Cells[4].Value + " " + datagridview_restorant.Rows[e.RowIndex].Cells[5].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}
