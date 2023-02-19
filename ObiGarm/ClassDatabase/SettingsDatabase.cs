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

        public static bool setFaleActiveKort(string id)
        {
            string query = $"UPDATE kort SET active = '0' WHERE id = '{id}';";
            sqlConfiguration.sqlQuery(query);
            return false;
        }

        public static bool DeletedClient(string id)
        {
            DataTable dataTable = sqlConfiguration.sqlSelectQuery( $"select id_kort from client where  id ='{id}'");
            setFaleActiveKort(dataTable.Rows[0]["id_kort"].ToString());
            string query = $"UPDATE client SET enable = '0', deleted = '{DateTime.Now.ToString("yyyy'-'MM'-'dd'_'HH':'mm':'ss")}' WHERE id = '{id}';";
            sqlConfiguration.sqlQuery(query);

            Console.WriteLine(query);

            return false;
        }

        public static bool setTrueActiveKort(string id)
        {
            string query = $"UPDATE kort SET active = '1' WHERE id = '{id}';";
            sqlConfiguration.sqlQuery(query);
            return false;
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
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery(
                $"select users.id, concat(users.name, ' ', users.surname, ' (',count(client.id), ')') as name " +
                $"from users " +
                $"left join client on client.id_varch= users.id " +
                $"where users.point=3 and client.deleted is null and users.id = '{id}' " +
                $"group by users.id " +
                $"order by count(client.id); ");
            return dataTable_sex.Rows[0]["name"].ToString();
        }

        public static string setNmaeRoomToTextbox(string id)
        {
            DataTable dataTable_sex = sqlConfiguration.sqlSelectQuery(
                $"select r.id, concat(f.name, ' ', r.name) as 'name_room' from room r join frame f on (r.id_freme  = f.id) where r.id ='{id}'");
            return dataTable_sex.Rows[0]["name_room"].ToString();
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
