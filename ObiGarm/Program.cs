using ObiGarm.Regisrarura;
using ObiGarm.Administration;
using ObiGarm.Services;
using ObiGarm.Users.Spitalists;
using ObiGarm.Users.Vracah;
using ObiGarm.Vrach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObiGarm.Mnitor;

namespace ObiGarm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
