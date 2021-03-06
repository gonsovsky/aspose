﻿using System.Collections.Generic;
using System.Linq;

namespace Aspose.Alphabet
{
    public class RussianLocale : ILocale
    {
        public IEnumerable<char> Alphabet => 
            Enumerable.Range('а', 'я' - 'а' + 1)
                                        .Select(i => (char)i);

        public int KeyCapacity(char aKey) => 4;
    }
}
