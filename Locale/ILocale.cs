using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Alphabet
{
    public interface ILocale
    {
        IEnumerable<char> Alphabet { get;}

        int KeyCapacity(char aKey);
    }
}
