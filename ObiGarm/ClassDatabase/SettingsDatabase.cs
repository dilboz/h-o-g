using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiGarm.ClassDatabase
{
    class SettingsDatabase
    {
        public static string id_user { get; set; }
        public static string name_user { get; set; }
        public static string surname_user { get; set; }
        public static string type_user { get; set; }

        /// <path_name>
        /// path file setting tadabse format *.txt
        public string path_name = @"setting\setting_db.txt";
        /// </path_name>
        /// 


    }
}
