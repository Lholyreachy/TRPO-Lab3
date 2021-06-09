using NUnit.Framework;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
       
    {

        [Test]
        public void Test1()
        {
            double h = 1;
            double r1 = 1;
            double r2 = 1;

            double expected = 3.14;

            var result = Class1.Konus(h, r1, r2);
            Assert.AreEqual(expected, result);

        }
    }
}