using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DescendingOrderTests
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void ValidateNegativeValue()
        {
            Assert.AreEqual(Kata.Kata.DescendingOrder(-25), 0);
        }

        [TestMethod]
        public void ValidateZeroValue()
        {
            Assert.AreEqual(0, Kata.Kata.DescendingOrder(0));
        }

        [TestMethod]
        public void ValidateValue1()
        {
            int value = 1;
            int expectedValue = 1;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }

        [TestMethod]
        public void ValidateValue15()
        {
            int value = 15;
            int expectedValue = 51;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }

        [TestMethod]
        public void ValidateValue42145()
        {
            int value = 42145;
            int expectedValue = 54421;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }

        [TestMethod]
        public void ValidateValue145263()
        {
            int value = 145263;
            int expectedValue = 654321;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }

        [TestMethod]
        public void ValidateValue123456789()
        {
            int value = 123456789;
            int expectedValue = 987654321;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }

        [TestMethod]
        public void ValidateValue1021()
        {
            int value = 1021;
            int expectedValue = 2110;
            Assert.AreEqual(Kata.Kata.DescendingOrder(value), expectedValue);
        }
    }
}
