using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetMaker.Dialogs;

namespace BetMaker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string fileBackup = string.Concat(DateTime.Now.ToString("dd.MM.yyyy"), ".db"),
                dirBackup = "Backup",
                pathBackup = Path.Combine(dirBackup, fileBackup);

            if (Directory.Exists(dirBackup) == false)
            {
                Directory.CreateDirectory(dirBackup);
            }

            if (File.Exists(pathBackup) == false)
            {
                File.Copy(Settings.PathDatabase, pathBackup);
            }

            Application.Run(new MainForm());
        }
    }
}
