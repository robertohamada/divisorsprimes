using NUnit.Framework;
using ServiceDivisorPrime.BLL;
using System;

namespace DividersPrimesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var divisorsBLL = new DivisorsBLL();
            var resultDto = divisorsBLL.Calc(45);
            Assert.AreEqual("1,3,5,9,15,45", String.Join(",", resultDto.DivisorsList), "divisorlist");
            Assert.AreEqual("1,3,5", String.Join(",", resultDto.PrimesList), "primelist");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var divisorsBLL = new DivisorsBLL();
            var resultDto = divisorsBLL.Calc(2);
            Assert.AreEqual("1,2", String.Join(",", resultDto.DivisorsList), "divisorlist");
            Assert.Pass();
        }


    }
}