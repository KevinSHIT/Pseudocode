using Microsoft.VisualStudio.TestTools.UnitTesting;

using static Kevin.Pseudocode.Type;

namespace Kevin.Pseudocode.Test
{
    [TestClass]
    public class OperatorTest
    {
        [TestMethod]
        public void LetByInt()
        {
            int i = 12;
            LET m = new LET(12);
            System.Console.WriteLine("SRC -> " + m);

            m++;
            i++;
            System.Console.WriteLine("m++ -> " + m);
            Assert.IsTrue(m == i);

            ++m;
            ++i;
            System.Console.WriteLine("++m -> " + m);
            Assert.IsTrue(m == i);

            System.Console.WriteLine((int)m);

            m = m + 1;
            i = i + 1;
            System.Console.WriteLine("+12 -> " + m);
            Assert.IsTrue(m == i);

            m += 12;
            i += 12;
            System.Console.WriteLine("+=x -> " + m);
            Assert.IsTrue(m == i);
        }
    }
}
