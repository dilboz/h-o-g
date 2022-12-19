using DevExpress.Spreadsheet.Charts;
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

namespace ObiGarm.Administration
{
    public partial class InfoReportsFromMoney : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;

        private static Decimal all_money = 0;
        private static Decimal money_consuption = 0;

        DataTable date_table_for_chart;

        DataTable date_tabel_money;
        DataTable date_tabel_money_consuption;

        string select_all_money = "";
        string select_money_consuption = "";

        public InfoReportsFromMoney()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
            combo_type_money.Text = "Отчёт дар бораи маблағи нақд";
        }

        void dispaly (string type_money, DateTime start_date, DateTime end_date)
        {

            if (type_money == "Отчёт дар бораи маблағи нақд")
            {
                name_bank.Visible = false;
                bank_name.Visible = false;

                label_grid_control_money.Text = "Намоиши маблағҳои гирифташуда";
                label_grid_control_consuption.Text = "Намоиши маблағҳои расхошуда";

                select_all_money = $"select name as  'name_money', number_money as 'number_money', date from list_money where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";
                select_money_consuption = $"select name, number_money as 'money_number',  date as 'date_consuption' from consuption_moneys where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";

                date_tabel_money = sqlConfiguration.sqlSelectQuery($"select sum(number_money) as 'sum_money', date  from list_money where enable=1 and date BETWEEN  '{start_date.ToString("yyyy - MM - dd")}' and '{end_date.ToString("yyyy - MM - dd")}'");
                date_tabel_money_consuption = sqlConfiguration.sqlSelectQuery($"select sum(number_money) as 'sum_consuption_moneys', date  from consuption_moneys where enable=1 and date BETWEEN  '{start_date.ToString("yyyy - MM - dd")}' and '{end_date.ToString("yyyy - MM - dd")}'");

                if (date_tabel_money != null && date_tabel_money_consuption != null)
                {
                    if (date_tabel_money != null)
                    {
                        if (date_tabel_money.Rows[0]["sum_money"].ToString() != "")
                        {
                            all_money = Convert.ToDecimal(date_tabel_money.Rows[0]["sum_money"].ToString());

                        }
                    }

                    if (date_tabel_money_consuption != null)
                    {
                        if (date_tabel_money_consuption.Rows[0]["sum_consuption_moneys"].ToString() != "")
                        {
                            money_consuption = Convert.ToDecimal(date_tabel_money_consuption.Rows[0]["sum_consuption_moneys"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Маълумот вучуд надорад");
                }
                

            }
            else if (type_money == "Отчёт дар бораи маблағи ғайринақди")
            {
                name_bank.Visible = true;
                bank_name.Visible = true;

                label_grid_control_money.Text = "Намоиши маблағҳои гирифташуда";
                label_grid_control_consuption.Text = "Намоиши маблағҳои расхошуда";

                select_all_money = "select list_money_bank.name as  'name_money', list_money_bank.number_money as 'number_money', name_bank.name as 'bank_name', list_money_bank.date " +
                    "from list_money_bank " +
                    "inner join name_bank on list_money_bank.id_name_bank = name_bank.id " +
                    $"where list_money_bank.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";

                select_money_consuption = "select consuption_money_bank.name, consuption_money_bank.number_money as 'money_number', name_bank.name as 'name bank', consuption_money_bank.date as 'date_consuption' " +
                    "from consuption_money_bank " +
                    "inner join name_bank on consuption_money_bank.id_name_bank = name_bank.id " +
                    $"where consuption_money_bank.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";

                date_tabel_money = sqlConfiguration.sqlSelectQuery($"select sum(number_money) as 'sum_money', date  from list_money_bank where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'");
                date_tabel_money_consuption = sqlConfiguration.sqlSelectQuery($"select sum(number_money) as 'sum_consuption_moneys', date  from consuption_money_bank where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'");

                if (date_tabel_money != null && date_tabel_money_consuption != null)
                {
                    if (date_tabel_money != null)
                    {
                        if (date_tabel_money.Rows[0]["sum_money"].ToString() != "")
                        {
                            all_money = Convert.ToDecimal(date_tabel_money.Rows[0]["sum_money"].ToString());

                        }
                    }

                    if (date_tabel_money_consuption != null)
                    {
                        if (date_tabel_money_consuption.Rows[0]["sum_consuption_moneys"].ToString() != "")
                        {
                            money_consuption = Convert.ToDecimal(date_tabel_money_consuption.Rows[0]["sum_consuption_moneys"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Маълумот вучуд надорад");
                }

               
               
            }
            else if (type_money == "Отчёт дар бораи ҳаммаи  маблағҳо")
            {
                name_bank.Visible = true;
                bank_name.Visible = true;

                label_grid_control_money.Text = "Намоиши ҳаммаи маблғҳои нақд";
                label_grid_control_consuption.Text = "Намоиши ҳаммаи маблғҳои гайринақдӣ";

                select_all_money = "select list_money_bank.name as  'name_money', name_bank.name as 'bank_name', list_money_bank.number_money as 'number_money',  list_money_bank.date " +
                    "from list_money_bank " +
                    "inner join name_bank on list_money_bank.id_name_bank = name_bank.id " +
                    $"where list_money_bank.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'" +
                    "union all " +
                    "select list_money.name,'' ,list_money.number_money, list_money.date " +
                    "from list_money " +
                    $"where list_money.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";

                select_money_consuption = "select consuption_money_bank.name, consuption_money_bank.number_money as 'money_number', name_bank.name as 'name bank', consuption_money_bank.date as 'date_consuption' " +
                    "from consuption_money_bank " +
                    "inner join name_bank on consuption_money_bank.id_name_bank = name_bank.id " +
                    $"where consuption_money_bank.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'" +
                    "union all " +
                    "select consuption_moneys.name,'' ,consuption_moneys.number_money, consuption_moneys.date " +
                    "from consuption_moneys " +
                    $"where consuption_moneys.enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}'";

                string str1 = "select sum(number_money) as 'sum_all_money' from( " +
                    $"(select sum(number_money) as 'number_money', date  from list_money where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}') " +
                    "union all " +
                    $"(select sum(number_money) as 'number_money', date  from list_money_bank where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}')) t1 ";
                string str2= "select sum(number_money) as 'sum_all_consuption_moneys'from( " +
                    $"(select sum(number_money) as 'number_money', date  from consuption_moneys where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}') " +
                    "union all " +
                    $"(select sum(number_money) as 'number_money', date  from consuption_money_bank where enable=1 and date BETWEEN  '{start_date.ToString("yyyy-MM-dd")}' and '{end_date.ToString("yyyy-MM-dd")}')) t1 ";


                date_tabel_money = sqlConfiguration.sqlSelectQuery(str1);
                date_tabel_money_consuption = sqlConfiguration.sqlSelectQuery(str2);

                if (date_tabel_money != null && date_tabel_money_consuption != null)
                {
                    if (date_tabel_money != null)
                    {
                        if (date_tabel_money.Rows[0]["sum_all_money"].ToString() != "")
                        {
                            all_money = Convert.ToDecimal(date_tabel_money.Rows[0]["sum_all_money"].ToString());

                        }
                    }

                    if (date_tabel_money_consuption != null)
                    {
                        if (date_tabel_money_consuption.Rows[0]["sum_all_consuption_moneys"].ToString() != "")
                        {
                            money_consuption = Convert.ToDecimal(date_tabel_money_consuption.Rows[0]["sum_all_consuption_moneys"].ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Маълумот вучуд надорад");
                }
            }

            date_table_for_chart = sqlConfiguration.sqlSelectQuery(select_all_money);

            dispaly_chart(date_table_for_chart);

            sqlConfiguration.displayListExpress(select_all_money, grid_control);
            sqlConfiguration.displayListExpress(select_money_consuption, grid_control_consuption);



            label_info.Text = $"Суммаи ҳаммаи маблағҳо:- {all_money.ToString()} сомонӣ{Environment.NewLine}" +
                                    $"Суммаи ҳаммаи маблағҳо расходшуда:- {money_consuption.ToString()} сомонӣ {Environment.NewLine}" +
                                    $"Суммаи ҳаммаи маблағҳо боқимонда:- {(all_money- money_consuption).ToString()} сомонӣ";

        }


        void dispaly_chart(DataTable dataTable)
        {
            chart_control_date.Series["series_line"].Points.Clear();
            //MessageBox.Show(dataTable.Rows[0]["date"].ToString() + Environment.NewLine + dataTable.Rows[0]["number_money"].ToString());

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //listBox1.Items.Add(Convert.ToDateTime(dataTable.Rows[i]["date"].ToString()).ToString() + " " + Convert.ToDouble(dataTable.Rows[i]["number_money"].ToString()).ToString());
                chart_control_date.Series["series_line"].Points.AddPoint(Convert.ToDateTime(dataTable.Rows[i]["date"].ToString()), Convert.ToDouble(dataTable.Rows[i]["number_money"].ToString()));

            }
        }

        private void btn_ansver_Click(object sender, EventArgs e)
        {
            dispaly(combo_type_money.Text,  Convert.ToDateTime (date_edit_start.EditValue), Convert.ToDateTime(date_edit_end.EditValue));
            

        }
    }
}
