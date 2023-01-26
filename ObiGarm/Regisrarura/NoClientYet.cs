using DevExpress.XtraGrid.Views.Grid;
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

namespace ObiGarm.Regisrarura
{
    public partial class NoClientYet : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        public NoClientYet()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string sql = "select client.id,  concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', concat('Бинои ', frame.name, ' Ҳуҷраи ', room.name) as 'room', type_kort.name as 'type_kort' " +
                         "from client " +
                         "inner join kort on client.id_kort = kort.id " +
                         "inner join type_kort on kort.id_type_kort = type_kort.id " +
                         "inner join room  on client.id_room = room.id " +
                         "inner join frame on room.id_freme = frame.id " +
                         "where  client.enable=1 and client.deleted is null  and client.number_order ='0' " +
                         "order by id desc  ";
            sqlConfiguration.displayListExpress(sql, grid_yet_not_client);
        }

        private void NoClientYet_Shown(object sender, EventArgs e)
        {            
            display();
        }

        private void to_vrach_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string id = grid_view_yet_no_client.GetRowCellValue(grid_view_yet_no_client.FocusedRowHandle, grid_view_yet_no_client.Columns["id"]).ToString();
            if (id == null)
            {
                MessageBox.Show("Шумо ба врач ордер монда наметонед");
            }
            else
            {
                MoneyForm moneyForm = new MoneyForm(this, id);
                moneyForm.ShowDialog();
            }
        }
    }
}
