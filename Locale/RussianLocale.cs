using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
