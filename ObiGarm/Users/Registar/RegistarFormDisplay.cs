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

namespace ObiGarm.Users.Registar
{
    public partial class RegistarFormDisplay : Form
    {
        SqlConfiguration sqlConfiguration;

        public RegistarFormDisplay()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_admin = "select enable, id, name, surname, login from users where point = '4' and deleted IS NULL";

            sqlConfiguration.displayList(select_admin, datagridview_admin);
        }

        private void RegistarFormDisplay_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddRegistar addRegistar = new AddRegistar(this, "", "Сохтан");
            addRegistar.ShowDialog();
        }

        private void datagridview_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == edit.Index)
            {
                string id = datagridview_admin.Rows[e.RowIndex].Cells[3].Value.ToString();

                AddRegistar addRegistar = new AddRegistar(this, id, "Иваз кардан");
                addRegistar.ShowDialog();
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
                        MessageBox.Show("Хатоги хангоми нест кардани Админ!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
