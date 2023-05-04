using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetMaker.Services
{
    class MarkdownService
    {
        public static string ToText(string text)
        {
            char[] symbols = new char[] {'['};

            foreach (char item in symbols)
            {
                text = text.Replace(item.ToString(), string.Concat("\\", item));
            }

            return text;
        }
    }
}
