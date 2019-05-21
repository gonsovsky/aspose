using Aspose.Alphabet;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose
{
    public abstract class Keypad
    {
        protected ILocale Locale;

        protected abstract List<char> KeyList { get; }

        protected Dictionary<char, Tuple<string,char>> Map;

        public Keypad(ILocale locale)
        {
            Locale = locale;
            Map = MakeMap();
        }

        protected Dictionary<char, Tuple<string, char>> MakeMap()
        {
            var result = new Dictionary<char, Tuple<string, char>>();
            var key = KeyList[0];
            var maxcapacity = Locale.KeyCapacity(key);
            var capacity = 0;
            foreach (var letter in Locale.Alphabet)
            {
                var sequence = "".PadRight(capacity + 1, key);
                result[letter] = new Tuple<string, char>(sequence, key);
                capacity++;
                if (capacity == maxcapacity)
                {
                    capacity = 0;
                    key = (char)(key + 1);
                    maxcapacity = Locale.KeyCapacity(key);
                }
            }
            result[' '] = new Tuple<string, char>("0",'0');
            return result;
        }

        public string Encode(string input)
        {
            var result = new StringBuilder();
            char? prevKey =null;
            for (int i=0; i<= input.Length-1; i++)
            {
                var c = input[i];
                var x = Map[c];
                if (prevKey == x.Item2)
                    result.Append(' ');
                result.Append(x.Item1);
                prevKey = x.Item2;
            }
            return result.ToString();
        }
    }
}
