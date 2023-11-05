using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestCalculadora
{
    [TestFixture]
    public class CalculatorTests
    {
        private DeepThought_From_the_Hitchhikers_guide_to_the_galaxy c;

        [SetUp]
        public void Setup()
        {
            c = new DeepThought_From_the_Hitchhikers_guide_to_the_galaxy();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, c.Add(2, 3));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(-1, c.Subtract(2, 3));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(6, c.Multiply(2, 3));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(2, c.Divide(6, 3));
        }

        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => c.Divide(6, 0));
        }

        [Test]
        public void TestUltimateQuestion()
        {
            TestContext.WriteLine(c.UltimateQuestion());
        }
    }
}