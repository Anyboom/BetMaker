using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BetMaker.Services
{
    class MessageService
    {
        public static string InputBox(string text, string title = null) => Interaction.InputBox(text, title is null ? Settings.TitleProject : title);
        public static void ShowError(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        public static void ShowWarn(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        public static void ShowInfo(string message) => MessageBox.Show(message, Settings.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        public static DialogResult ShowQuestion(string message, MessageBoxButtons buttons) => MessageBox.Show(message, Settings.TitleProject, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
    }
}
