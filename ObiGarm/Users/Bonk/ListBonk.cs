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

namespace ObiGarm.Users.Bonk
{
    public partial class ListBonk : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;

        public ListBonk()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_admin = "select id, name from name_bank  where enable='1'";
            sqlConfiguration.displayList(select_admin, datagridview_bank);
        }

        private void ListBonk_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void datagridview_bank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = datagridview_bank.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.ColumnIndex == edit.Index)
            {
                AddBonk addBonk = new AddBonk(this, id, "Иваз кардан");
                addBonk.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_bank.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteRoom = $"update name_bank set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'"; ;
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteRoom);
                    if (res2 == 1)
                    {
                        display();

                    }
                    else
                    {
                        MessageBox.Show(@"Хатоги хангоми нест кардан!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void add_frame_Click(object sender, EventArgs e)
        {
            AddBonk addBonk = new AddBonk(this, "", "Сохтан");
            addBonk.ShowDialog();
        }
    }
}
