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

namespace ObiGarm.Users.Kort
{
    public partial class ListKort : Form
    {
        SqlConfiguration sqlConfiguration;
        public ListKort()
        {
            InitializeComponent();

            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string select_sql = "select kort.id, kort.kod_kort, tk.name " +
                "from kort " +
                "inner join type_kort tk on kort.id_type_kort = tk.id " +
                "where deleted is  null";

            sqlConfiguration.displayListExpress(select_sql, grid_gontrol_list_kort);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddKort addKort = new AddKort(this, "", "Сохтан");
            addKort.ShowDialog();
        }

        private void ListKort_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            string id = grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["id"]).ToString();
            
            if (id != "")
            {
                AddKort addKort = new AddKort(this, id, "Иваз кардан");
                addKort.ShowDialog();
               
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string id = grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["id"]).ToString();
            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["kod_kort"]).ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update kort set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
                int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                if (res2 == 1)
                {
                    display();

                }
                else
                {
                    MessageBox.Show("Хатоги хангоми нест кардан!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
