using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
                bool result3 = Program.IsOdd(3);
                Assert.AreEqual(true, result3);

                bool result4 = Program.IsOdd(4);
                Assert.AreEqual(false, result4);
        }

        [TestMethod]
        public void TestIsEven()
        {
                bool result8 = Program.IsEven(8);
                Assert.AreEqual(true, result8);

                bool result15 = Program.IsEven(15);
                Assert.AreEqual(false, result15);
        }

        [TestMethod]
        public void TestIsPrime()
        {
                bool result1 = Program.IsPrime(1);
                Assert.AreEqual(false, result1);
                
                 bool result0 = Program.IsPrime(0);
                 Assert.AreEqual(false, result0);

                 bool result2 = Program.IsPrime(2);
                 Assert.AreEqual(false, result2);

                 bool result3 = Program.IsPrime(3);
                 Assert.AreEqual(false, result3);

                 bool result4 = Program.IsPrime(4);
                 Assert.AreEqual(true, result4);

                 bool result5 = Program.IsPrime(5);
                 Assert.AreEqual(false, result5);

                 bool resultNegative = Program.IsPrime(-10);
                 Assert.AreEqual(false, resultNegative);
        }

        [TestMethod]
        public void TestSquare()
        {
                int resultNega = Program.Square(2);
                Assert.AreEqual(4, resultNega);
        }

        [TestMethod]
        public void TestCube()
        {
                int resultPo = Program.Cube(-2);
                Assert.AreEqual(-8, resultPo);
        }
    }
}
