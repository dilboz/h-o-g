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

namespace ObiGarm.Regisrarura.Arkhiv
{
    public partial class ArkhivForm : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        private readonly Ristratura ristratura;
        public ArkhivForm(Ristratura ristratura)
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            this.ristratura = ristratura;
        }

        public void display()
        {
            string sql = "select client.id, client.number_order, concat(client.surname, ' ', client.name, ' ', client.patromic) as 'full_name', client.date_time_start, client.date_time_end " +
                         "from client " +
                         "where client.enable=0 and client.deleted is not null " +
                         "order by id desc  ";
            sqlConfiguration.displayListExpress(sql, grid_yet_not_client);
        }

        private void ArkhivForm_Shown(object sender, EventArgs e)
        {
            display();
        }

        public void click_home()
        {
            ristratura.click_home();
        }

        private void to_vrach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            string id_client = grid_view_client.GetRowCellValue(grid_view_client.FocusedRowHandle, grid_view_client.Columns["id"]).ToString();

            if (id_client == null)
            {
                MessageBox.Show("Шумо иваз карда наметавнонед!!");
            }
            else
            {
                AddCllient addCllient = new AddCllient(this, id_client, "");
                addCllient.ShowDialog();
            }
        }
    }
}
