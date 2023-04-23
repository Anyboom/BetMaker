using System;
using System.IO;
using System.Windows.Forms;

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

            if (File.Exists(pathBackup) == false && File.Exists(Settings.PathDatabase))
            {
                File.Copy(Settings.PathDatabase, pathBackup);
            }

            Application.Run(new MainForm());
        }
    }
}
