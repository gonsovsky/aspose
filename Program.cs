using Aspose.Alphabet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose
{
    class Program
    {
        static void Main(string[] args)
        {
            ILocale locale = new EnglishLocale();

            //locale = new RussianLocale(); //for RU layout

            var t9keypad = new T9Keypad(locale);

            var qqqq = t9keypad.Encode("foo  bar");
            Console.ReadLine();
        }
    }
}
