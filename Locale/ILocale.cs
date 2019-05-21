using System.Collections.Generic;

namespace Aspose.Alphabet
{
    public interface ILocale
    {
        IEnumerable<char> Alphabet { get;}

        int KeyCapacity(char aKey);
    }
}
