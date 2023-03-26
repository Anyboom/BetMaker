using System;
using System.Collections.Generic;
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

            if (Settings.KeyExists("Token", "Telegram") == false)
            {
                Settings.Write("Token", string.Empty, "Telegram");
            }

            if (Settings.KeyExists("NameChannel", "Telegram") == false)
            {
                Settings.Write("NameChannel", string.Empty, "Telegram");
            }

            Application.Run(new MainForm());
        }
    }
}
