using System.Collections.Generic;
using System.Linq;
using Aspose.Alphabet;

namespace Aspose.Keypad
{
    public class T9Keypad: Keypad
    {
        public T9Keypad(ILocale locale) : base(locale) { }

        protected override IEnumerable<char> KeyList =>
               Enumerable.Range('2', '9')
                                        .Select(i => (char)i);
                                     
    }
}
