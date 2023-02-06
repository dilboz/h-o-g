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

namespace ObiGarm.Users.Countr_Pr
{
    public partial class CountryRro : DevExpress.XtraEditors.XtraForm
    {
        SqlConfiguration sqlConfiguration;
        public CountryRro()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public void displaycountry()
        {
            string select_admin = "select id, name from country where deleted is null";
            sqlConfiguration.displayList(select_admin, datagridview_country);
        }

        public void displayPr()
        {
            string select_admin = "select province.id, country.name 'name_country', province.name " +
                "from province " +
                "inner join country on province.id_country = country.id " +
                "where province.deleted is null";
            sqlConfiguration.displayList(select_admin, datagridview_pr);
        }

        private void CountryRro_Shown(object sender, EventArgs e)
        {
            displaycountry();
            displayPr();
        }

        private void datagridview_country_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = datagridview_country.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.ColumnIndex == edit.Index)
            {
                addCountry addCountry = new addCountry(this,  "Иваз кардан", id);
                addCountry.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_country.Rows[e.RowIndex].Cells[3].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteRoom = $"UPDATE country SET deleted = '{DateTime.Now.ToString("yyyyy-MM-dd")}' WHERE (id = '{id}');";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteRoom);
                    if (res2 == 1)
                    {
                        displaycountry();

                    }
                    else
                    {
                        MessageBox.Show(@"Хатоги хангоми нест кардани кишвар!" + Environment.NewLine + "!!!Агар шумо бо чунин кишвар вилоят сохтаги бошед." + Environment.NewLine + "Кишварроо нест карда наметавонед", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void datagridview_pr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = datagridview_pr.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (e.ColumnIndex == edit.Index)
            {
                addPr addPr = new addPr(this, "Иваз кардан", id);
                addPr.ShowDialog();
            }
            if (e.ColumnIndex == delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Шумо дар хакикат " + datagridview_pr.Rows[e.RowIndex].Cells[4].Value + " - ро нест кардан мехохед?", "Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string sqlDeleteAdmin = $"UPDATE province SET deleted = '{DateTime.Now.ToString("yyyyy - MM - dd")}' WHERE (id = '{id}');";
                    int res2 = sqlConfiguration.sqlQuery(sqlDeleteAdmin);
                    if (res2 == 1)
                    {
                        displayPr();

                    }
                    else
                    {
                        MessageBox.Show("Хатоги хангоми нест кардани ҳуҷра!", "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void add_pr_Click(object sender, EventArgs e)
        {
            addPr addPr = new addPr(this, "Сохтан", "");
            addPr.ShowDialog();
        }

        private void add_country_Click(object sender, EventArgs e)
        {
            addCountry addcountry = new addCountry(this, "Сохтан", "");
            addcountry.ShowDialog();
        }
    }
}
