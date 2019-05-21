﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Alphabet
{
    public class EnglishLocale : ILocale
    {
        public IEnumerable<char> Alphabet =>
               Enumerable.Range('a', 'z' - 'a' + 1)
                                        .Select(i => (char)i);

        public int KeyCapacity(char aKey) =>
                aKey == '7' || aKey == '9' ? 4 : 3;
    }
}
