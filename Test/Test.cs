using Aspose.Alphabet;
using Aspose.Keypad;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestEnglish()
        {
            var locale = new EnglishLocale();
            var keypad = new T9Keypad(locale);
            var input = "hello world";
            var output = "4433555 555666096667775553";
            var fact = keypad.Encode(input);
            Assert.AreEqual(output, fact);
        }

        [TestMethod]
        public void TestRussian()
        {
            var locale = new RussianLocale();
            var keypad = new T9Keypad(locale);
            var input = "привет";
            var output = "55556422233666";
            var fact = keypad.Encode(input);
            Assert.AreEqual(output, fact);
        }
    }
}
