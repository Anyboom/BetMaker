using BetMaker.Services;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace BetMaker
{
    class Settings
    {
        public static string PathDatabase = "BetMaker.db";
        public static string TitleProject = "BetMaker";
        public static string ShowHelp
        {
            get
            {
                StringBuilder stringHelp = new StringBuilder();
                stringHelp.AppendLine("{Id} - идентификатор ставки");
                stringHelp.AppendLine("{HomeTeam} - домашняя команда");
                stringHelp.AppendLine("{GuestTeam} - гостевая команда");
                stringHelp.AppendLine("{Prognosis} - прогноз");
                stringHelp.AppendLine("{Competition} - название сореванования");
                stringHelp.AppendLine("{Coefficient} - коэффициент");
                stringHelp.AppendLine("{Result} - результат");
                stringHelp.AppendLine("{StartAt} - начало матча");
                stringHelp.AppendLine("{CreatedAt} - дата и время создания ставки");
                stringHelp.AppendLine("{Author} - автор ставки");

                return stringHelp.ToString();
            }
        }

        static string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        private static string Path;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        static Settings()
        {
            Path = new FileInfo(EXE + ".ini").FullName;
        }

        public static string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public static void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public static void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public static void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public static bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
