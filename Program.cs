using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShareOnDeskTop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Common.dbServer = args[0];
            Common.dbName = args[1];
            Common.dbPassword = args[2];
            //;Password=zeka7744;Trusted_Connection=True;TrustServerCertificate=True;
            Common._connectionString = "Server=" + Common.dbServer + ";Database=" + Common.dbName + ";User Id=sa" + Common.dbPassword;
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
