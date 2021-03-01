using Microsoft.VisualStudio.TestTools.UnitTesting;

using static Kevin.Pseudocode.Type;

namespace Kevin.Pseudocode.Test
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void LetToInt()
        {
            System.Console.WriteLine("SRC -> " + 20);
            LET m = new(20);
            int mm = m;
            System.Console.WriteLine("MDL -> " + mm);
            LET k = (LET)mm;
            System.Console.WriteLine("FNL -> " + k);
            Assert.IsTrue(mm == k && m == k);

        }

        [TestMethod]
        public void LetToDouble()
        {
            System.Console.WriteLine("SRC -> " + 20.2);
            LET m = new(20.2);
            double mm = m;
            System.Console.WriteLine("MDL -> " + mm);
            LET k = (LET)mm;
            System.Console.WriteLine("FNL -> " + k);
            Assert.IsTrue(mm == k && m == k);
        }

        [TestMethod]
        public void LetToString()
        {
            System.Console.WriteLine("SRC -> " + "HHH");
            LET m = new("HHH");
            string mm = m;
            System.Console.WriteLine("MDL -> " + mm);
            LET k = (LET)mm;
            System.Console.WriteLine("FNL -> " + k);
            Assert.IsTrue(mm == k && m == k);
        }
    }
}
