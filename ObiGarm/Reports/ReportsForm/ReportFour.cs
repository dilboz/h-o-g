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

namespace ObiGarm.Reports.ReportsForm
{
    public partial class ReportFour : Form
    {
        SqlConfiguration sqlConfiguration;

        private string imruzDI;
        private string IDImuqarari;
        private string IDInimalodaraja;
        private string rafta;
        private string Rmuqarari;
        private string Rnimalodaraja;
        private string darI;
        private string DImuqarari;
        private string DInimalodaraja;
        private string Oshkhona;
        private string Omuqarari;
        private string Onimalodaraja;
        private string hamguzariho;
        private string meraftagiho;
        private string Mmuqarari;
        private string Mnimalodaraja;
        private string rohhat;
        private string kvitansiy;
        private string darIstirohatgoh;
        private string Imuqarari;
        private string Inimalodaraja;

        private string[] ayyayParam = new string[22] {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

        public ReportFour()
        {
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();

            dateTimePicker.Value = DateTime.Now;
        }

        
        private void buttonAns_Click(object sender, EventArgs e)
        {
            imruzDI =
            ayyayParam[0] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_registration, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}';").Rows[0]["count"].ToString();
            IDImuqarari =
            ayyayParam[1] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_registration, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();
            IDInimalodaraja =
            ayyayParam[2] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_registration, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();
            rafta =
            ayyayParam[3] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' ;").Rows[0]["count"].ToString();
            Rmuqarari =
            ayyayParam[4] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();
            Rnimalodaraja =
            ayyayParam[5] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();
            darI =
            ayyayParam[6] = sqlConfiguration.sqlSelectQuery("select count(*) as count from client c where c.deleted is null  and c.enable  = '1' ;").Rows[0]["count"].ToString();
            DImuqarari =
            ayyayParam[7] = sqlConfiguration.sqlSelectQuery("select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and  c.id_type_money = '1' ;").Rows[0]["count"].ToString();
            DInimalodaraja =
            ayyayParam[8] = sqlConfiguration.sqlSelectQuery("select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and  c.id_type_money = '2' ;").Rows[0]["count"].ToString();
            Oshkhona =
            ayyayParam[9] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' ;").Rows[0]["count"].ToString();
            Omuqarari =
            ayyayParam[10] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();
            Onimalodaraja =
            ayyayParam[11] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();
            meraftagiho =
            ayyayParam[12] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' ;").Rows[0]["count"].ToString();
            Mmuqarari =
            ayyayParam[13] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();
            Mnimalodaraja =
            ayyayParam[14] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') = '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();
            rohhat =
            ayyayParam[15] = sqlConfiguration.sqlSelectQuery($"select sum(datediff(date_time_end, date_time_start)) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_registration, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();
            kvitansiy =
            ayyayParam[16] = sqlConfiguration.sqlSelectQuery($"select sum(datediff(date_time_end, date_time_start)) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_registration, '%Y-%m-%d') = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();

            Console.WriteLine("-----------------------------------------\n" + rohhat + " " + kvitansiy);

            hamguzariho =
             ayyayParam[17] = (int.Parse(rohhat.Replace(',', '.') == null || rohhat.Replace(',', '.') =="" ? "0" : rohhat.Replace(',', '.')) + int.Parse(kvitansiy.Replace(',', '.') == null || kvitansiy.Replace(',', '.') == "" ? "0" : kvitansiy.Replace(',', '.'))).ToString();
            darIstirohatgoh =
            ayyayParam[18] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' ;").Rows[0]["count"].ToString();
            Imuqarari =
            ayyayParam[19] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' and c.id_type_money = '1';").Rows[0]["count"].ToString();
            Inimalodaraja =
            ayyayParam[20] = sqlConfiguration.sqlSelectQuery($"select count(*) as count from client c where c.deleted is null  and c.enable  = '1' and date_format(c.date_time_end, '%Y-%m-%d') != '{dateTimePicker.Value.AddDays(1).ToString("yyyy-MM-dd")}' and c.id_type_money = '2';").Rows[0]["count"].ToString();

            ayyayParam[21] = dateTimePicker.Value.ToString("yyyy-MM-dd");

            label2.Text = $"Миқдори шахсони имрузомада ({imruzDI} н.): дар муқарари {IDImuqarari}(нафар) ва дар нимаълодараҷа {IDInimalodaraja}(нафар)\n\n" +
                          $"Миқдори шахсони имруз рафта({rafta}н.): аз муқарари {Rmuqarari}(нафар) ва аз нимаълодараҷа {Rnimalodaraja}(нафар)\n\n" +
                          $"Ҳамаги дар истироҳатгоҳ({darI}н.): дар муқарари {DImuqarari}(нафар) ва дар нимаълодараҷа  {DInimalodaraja}(нафар)\n\n";

            label3.Text = $"Ошхона мерафтагиҳо ({Oshkhona}н.): аз муқарари {Omuqarari}(нафар) аз нимаълодараҷа {Onimalodaraja}(нафар)";

            label4.Text = $"Ҳамагирузҳо: {hamguzariho}";

            label5.Text = $"Шахсони пагоҳ мерафтаги ({meraftagiho} н.): аз муқарари {Mmuqarari}(нафар) ва аз нимаълодараҷа {Mnimalodaraja}(нафар)";

            label6.Text = $"Роҳхат: {rohhat}(руз)";

            label7.Text = $"Квитансия: {kvitansiy}(руз)";

            label8.Text = $"Ҳамагипагоҳ дар истироҳатгоҳ ({darIstirohatgoh} н.): дар муқарари {Imuqarari}(нафар) ва дар нимаълодараҷа {Inimalodaraja}(нафар)";
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintRortForm printRortForm = new PrintRortForm(ayyayParam);
            printRortForm.ShowDialog();
        }
    }
}
