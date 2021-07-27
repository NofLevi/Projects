using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //init access by auto location :D

            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result
            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            // This will get the current PROJECT directory
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["dbx"].ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + projectDirectory + "\\Database1.accdb";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            //end access init
            SQLFuncs sqlfuncs = new SQLFuncs();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(sqlfuncs.FirstEntry() == true)
            {
                Application.Run(new FirstEntryForm());
            }
            else
            {
                Application.Run(new Login());
                //Application.Run(new Login());
            }
        }
    }
}
