using CalculatorCore.Infrastructure;
using NUnit.Framework;

namespace Tests
{
    public class SumTest
    {
        Sum instance;

        [SetUp]
        public void Setup() => instance = new();
        

        [Test]
        public void ResultsTest()
        {
            double x = 4, y = 6;
            Assert.AreEqual(x + y, instance.Result(x, y));
        }
    }
}