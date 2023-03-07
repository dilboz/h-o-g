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
using System.Web.UI.WebControls;
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
                MessageBox.Show("Шумо иваз карда наметавнонед!!");
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
                SettingsDatabase.DeletedClient(id);
                display();
            }
               
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            string id_client = grid_view_is_client.GetRowCellValue(grid_view_is_client.FocusedRowHandle, grid_view_is_client.Columns["id"]).ToString();

            if (id_client == null)
            {
                MessageBox.Show("Шумо рузми мондаро махкам карда наметавонед наметавнонед!!");
            }
            else
            {
                //AddCllient addCllient = new AddCllient(this, id_client, "Махкамкунии руз");
                AddArchiv addArchiv = new AddArchiv(this, id_client);
                addArchiv.ShowDialog();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            AddCllient addCllient = new AddCllient(this, "", "Сохтан");
            
            addCllient.ShowDialog();
        }

        private void grid_view_is_client_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            DateTime datetime_clients = Convert.ToDateTime(grid_view_is_client.GetRowCellValue(e.RowHandle, "date_time_end"));

            if (DateTime.Now.AddDays(-1) >= datetime_clients)
            {
                e.Appearance.BackColor = Color.FromArgb(191, 102, 94);
                e.HighPriority = true;
            }
            else if (DateTime.Now >= datetime_clients)
            {
                e.Appearance.BackColor = Color.FromArgb(255, 165, 175);
                e.HighPriority = true;
            }
            else
            {
                e.Appearance.BackColor = Color.White;
                e.HighPriority = false;
            }
        }
    }
}
