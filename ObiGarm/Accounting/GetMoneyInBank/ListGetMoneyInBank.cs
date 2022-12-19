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

namespace ObiGarm.Accounting.GetMoneyInBank
{
    public partial class ListGetMoneyInBank : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        public ListGetMoneyInBank()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void display()
        {
            string sql = "SELECT lmk.id,  lmk.name, name_bank.name as 'name_bank', lmk.number_money, lmk.date " +
                         "FROM list_money_bank lmk "+
                         "inner join name_bank on lmk.id_name_bank = name_bank.id "+
                         "where lmk.enable = 1 " +
                         "order by lmk.id desc";
            sqlConfiguration.displayListExpress(sql, grid_gontrol_list_money);

            string sql_load_all_sum_money = "SELECT sum(number_money) AS 'sum_money', max(date) as 'max_date', min(date) as 'min_date' FROM list_money_bank where enable = 1 ;";

            DataTable dataTable = sqlConfiguration.sqlSelectQuery(sql_load_all_sum_money);

            if (dataTable.Rows[0]["sum_money"].ToString()=="")
            {
                label_info.Text = $"<b>Суммаи ҳаммаи маблағҳо:</b> <color=0, 0, 255>- 00 сомонӣ-</color> <br>" +
                                    $"<b>Суммаи ҳаммаи маблағҳо расходшуда:</b> <color=0, 0, 255>- 00 - сомонӣ</color> <br>" +
                                    $"<b>Суммаи ҳаммаи маблағҳо боқимонда:</b> <color=0, 0, 255>- 00 - сомонӣ</color> <br>";
                label_info_date.Text = $"<b>Рузи аввли маблағи гиифтаги:</b> <color=0, 0, 255>- --/--/---- -</color> <br>" +
                                        $"<b>Рузи охири маблағи гиифтаги:</b> <color=0, 0, 255>- --/--/---- - </color> ";
            }
            else
            {
                label_info.Text = $"<b>Суммаи ҳаммаи маблағҳо:</b> <color=0, 0, 255>- {dataTable.Rows[0]["sum_money"].ToString()} - сомонӣ</color> <br>"; /*+*/
                                                                                                                                                          //$"<b>Суммаи ҳаммаи маблағҳо расходшуда:</b> <color=0, 0, 255>- {dataTable.Rows[0]["sum_consuption"].ToString()} - сомонӣ</color> <br>" +
                                                                                                                                                          //$"<b>Суммаи ҳаммаи маблағҳо боқимонда:</b> <color=0, 0, 255>- {Convert.ToDouble(dataTable.Rows[0]["sum_money"].ToString()) - Convert.ToDouble(dataTable.Rows[0]["sum_consuption"].ToString())} - сомонӣ</color> "

                label_info_date.Text = $"<b>Рузи аввли маблағи гиифтаги:</b> <color=0, 0, 255>- {dataTable.Rows[0]["min_date"].ToString()} -</color> <br>" +
                                $"<b>Рузи охири маблағи гиифтаги:</b> <color=0, 0, 255>- {dataTable.Rows[0]["max_date"].ToString()} - </color> ";
            }

        }

        private void ListGetMoneyInBank_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void edit_button_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string id = grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["id"]).ToString();
            
            if (id != "")
            {
                AddGetMoneyInBank addGetMoneyInBank = new AddGetMoneyInBank(this, id, "Иваз кардан");
                addGetMoneyInBank.ShowDialog();
            }
        }

        private void delete_button_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string id = grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["id"]).ToString();
            DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + grid_view.GetRowCellValue(grid_view.FocusedRowHandle, grid_view.Columns["name"]).ToString() + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string sqlDeleteAdmin = $"update list_money_bank set deleted= '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}',  enable='0' where id = '" + id + "'";
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

        private void btn_creat_Click(object sender, EventArgs e)
        {
            AddGetMoneyInBank addGetMoneyInBank = new AddGetMoneyInBank(this, "", "Сохтан");
            addGetMoneyInBank.ShowDialog();
        }
    }
}
