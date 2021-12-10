using CalculatorCore.Infrastructure;
using NUnit.Framework;

namespace Tests
{
    public class DivTest
    {
        Div instance;

        [SetUp]
        public void Setup() => instance = new();


        [Test]
        public void ResultsTest()
        {
            double x = 10, y = 2;
            Assert.AreEqual(x / y, instance.Result(x, y));
        }
    }
}