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
                 Assert.AreEqual(true, result2);

                 bool result3 = Program.IsPrime(3);
                 Assert.AreEqual(true, result3);

                 bool result4 = Program.IsPrime(4);
                 Assert.AreEqual(false, result4);

                 bool result5 = Program.IsPrime(5);
                 Assert.AreEqual(true, result5);

                 bool resultNegative = Program.IsPrime(-10);
                 Assert.AreEqual(false, resultNegative);
        }

        [TestMethod]
        public void TestSquare()
        {
                int resultNega = Program.Square(3);
                Assert.AreEqual(9, resultNega);
        }

        [TestMethod]
        public void TestCube()
        {
                int resultPo = Program.Cube(-2);
                Assert.AreEqual(-8, resultPo);
        }

        [TestMethod]
        public void TestPow()
        {
                double resultPow = Program.Pow(3,5);
                Assert.AreEqual(243, resultPow);

                double resultPow1 = Program.Pow(2, -3);
                Assert.AreEqual(0.125, resultPow1);
        }

        [TestMethod]
        public void TestAbs()
        {
                int resultAbs = Program.Abs(-5);
                Assert.AreEqual(5, resultAbs);

                int resultAbs1 = Program.Abs(10);
                Assert.AreEqual(10, resultAbs1);
        }

        [TestMethod]
        public void TestCeil()
        {
                int resultCeil = Program.Ceil(3.7);
                Assert.AreEqual(4, resultCeil);

                int resultCeil1 = Program.Ceil(-3);
                Assert.AreEqual(-3, resultCeil1);

                int result2 = Program.Ceil(-2.7f);
                Assert.AreEqual(-2, result2);

                int result3 = Program.Ceil(5);
                Assert.AreEqual(5, result3);

        }

        [TestMethod]
        public void TestFloor()
        {
                int resultFloor = Program.Floor(5.67);
                Assert.AreEqual(5, resultFloor);

                int resultFloor1 = Program.Floor(10.19);
                Assert.AreEqual(10, resultFloor1);

                int resultFloor2 = Program.Floor(-2.3f);
                Assert.AreEqual(-3, resultFloor2);

                int resultFloor3 = Program.Ceil(-9);
                Assert.AreEqual(-9, resultFloor3);

                int resultFloor4 = Program.Ceil(5);
                Assert.AreEqual(5, resultFloor4);
        }

        [TestMethod]
        public void TestFactorial()
        {
                int resultF = Program.Factorial(10);
                Assert.AreEqual(3628800, resultF);

                int resultF1 = Program.Factorial(5);
                Assert.AreEqual(120, resultF1);

                int resultF2 = Program.Factorial(0);
                Assert.AreEqual(1, resultF2);

                int resultF3 = Program.Factorial(-4);
                Assert.AreEqual(0, resultF3);
                
        }
    }
}
