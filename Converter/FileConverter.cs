using Aspose.Keypad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Aspose.Converter
{
    public class FileConverter: Converter
    {
        private string _inFile;
        private string _outFile;

        public FileConverter(IKeypad keypad, string inFile): base(keypad)
        {
            _inFile = inFile;
            _outFile = Path.ChangeExtension(_inFile, ".out");
        }

        public static string WorkingFolder =>
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static IEnumerable<string> InputFiles =>
            Directory.GetFiles(WorkingFolder, "*.in", SearchOption.TopDirectoryOnly);

        public override void Convert()
        {
            using (FileStream outfile = new FileStream(_outFile, FileMode.Create, FileAccess.Write, FileShare.Read))
            using (StreamWriter writer = new StreamWriter(outfile, Encoding.Unicode))
            {
                FileStream infile = new FileStream(_inFile, FileMode.Open,FileAccess.Read);
                var no = 0;
                using (StreamReader reader = new StreamReader(infile, Encoding.UTF8))
                {
                    string line = String.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        no++;
                        if (no <= 2) //Skip first 2 lines of Google's input file. 
                            continue;
                        line = Keypad.Encode(line);
                        writer.WriteLine($"Case #{no-2} {line}");
                    }
                }
            }
        }
    }
}
