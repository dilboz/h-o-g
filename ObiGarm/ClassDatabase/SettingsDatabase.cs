using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiGarm.ClassDatabase
{
    class SettingsDatabase
    {
        static SqlConfiguration sqlConfiguration;
        public static string id_user { get; set; }
        public static string name_user { get; set; }
        public static string surname_user { get; set; }
        public static string type_user { get; set; }

        /// <path_name>
        /// path file setting tadabse format *.txt
        public string path_name =Application.StartupPath +  @"\setting\setting_db.txt";
        /// </path_name>
        /// 

        public SettingsDatabase()
        {
            sqlConfiguration = new SqlConfiguration();
        }

        public static string setNmaeCountryToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select * from country where id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeSexToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select * from sex where id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeProvinceToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select * from province where id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeVrachToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select concat(surname, ' ', name) as 'name'  from users where id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeRoomToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select concat('Бинои ', frame.name , ' ҳуҷраи ', room.name) as 'name'  from room inner join frame on room.id_freme = frame.id where room.id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeTypeMoneyToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select * from type_money where id= '{id}';");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeKodKortToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery($"select * from kort where id= '{id}';");
            return dataTable_sex.Rows[0]["kod_kort"].ToString();
        }


    }
}
