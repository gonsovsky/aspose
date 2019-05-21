using Aspose.Keypad;

namespace Aspose.Converter
{
    public abstract class Converter
    {
        protected IKeypad Keypad;

        public Converter(IKeypad keypad)
        {
            Keypad = keypad;
        }

        public abstract void Convert();

    }
}
