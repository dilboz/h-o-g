using ObiGarm.ClassDatabase;
using ObiGarm.Regisrarura.Arkhiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura
{
    public partial class IsClient : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        public IsClient()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }



        public void display()
        {
                string sql = "select client.id, client.number_order, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', client.date_time_start, client.date_time_end, type_kort.name as 'type_kort' " +
                             "from client " +
                             "inner join kort on client.id_kort = kort.id " +
                             "inner join type_kort on kort.id_type_kort = type_kort.id " +
                             "where  client.enable=1 and client.deleted is null " +
                             "order by id desc ";

            sqlConfiguration.displayListExpress(sql, grid_control_is_client);
        }

        private void IsClient_Shown(object sender, EventArgs e)
        {
            display();
        }


        private void edit_Click(object sender, EventArgs e)
        {
            string id_client = grid_view_is_client.GetRowCellValue(grid_view_is_client.FocusedRowHandle, grid_view_is_client.Columns["id"]).ToString();

            if (id_client == null)
            {
                MessageBox.Show("Шумо ба врач равон карда наметавонд");
            }
            else
            {
                AddCllient addCllient = new AddCllient(this, id_client, "Иваз кардан");
                addCllient.ShowDialog();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = grid_view_is_client.GetRowCellValue(grid_view_is_client.FocusedRowHandle, grid_view_is_client.Columns["id"]).ToString();
            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + grid_view_is_client.GetRowCellValue(grid_view_is_client.FocusedRowHandle, grid_view_is_client.Columns["full_name"]).ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update client set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
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

        private void pause_btn_Click(object sender, EventArgs e)
        {
            string id = grid_view_is_client.GetRowCellValue(grid_view_is_client.FocusedRowHandle, grid_view_is_client.Columns["id"]).ToString();
            if (id == null)
            {
                MessageBox.Show("Шумо ба врач равон карда наметавонд");
            }
            else
            {
                AddArchiv addArchiv = new AddArchiv(this, id);
                addArchiv.ShowDialog();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddCllient addCllient = new AddCllient();
            addCllient.ShowDialog();
        }
    }
}
