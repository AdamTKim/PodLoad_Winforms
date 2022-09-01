using Serilog;
using System;
using System.Windows.Forms;

namespace PodLoad
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
            var log = new LoggerConfiguration().WriteTo.File(Application.StartupPath + "/Data/Archive/Log.txt").CreateLogger();
            Application.Run(new PodForm(log));
        }
    }
}