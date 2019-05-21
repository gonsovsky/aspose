using Aspose.Alphabet;
using Aspose.Converter;
using Aspose.Keypad;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aspose
{
    class Program
    {
        static void Main(string[] args)
        {
            ILocale locale = new EnglishLocale();
            IKeypad keypad = new T9Keypad(locale);

            var tasks = new List<Task>();
            foreach (var file in FileConverter.InputFiles)
            {
                var task = Task.Factory.StartNew(() =>
                    new FileConverter(keypad, file).Convert()
                );
                tasks.Add(task);             
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("See .in and .out files in /bin/debug\r\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}
