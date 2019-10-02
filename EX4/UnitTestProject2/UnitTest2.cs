using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX4b;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestIsContains5()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            bool rs = Program.IsContains5(A1);
            Assert.AreEqual(false, rs);

            int[] A2 = new int[] { 1, 2, 3, 5 };
            bool rs1 = Program.IsContains5(A2);
            Assert.AreEqual(true, rs1);
        }

        [TestMethod]
        public void TestIsContains5Or6()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            bool rs = Program.IsContains5Or6(A1);
            Assert.AreEqual(false, rs);

            int[] A2 = new int[] { 1, 2, 3, 6 };
            bool rs1 = Program.IsContains5Or6(A2);
            Assert.AreEqual(true, rs1);

            int[] A3 = new int[] { 1, 2, 3, 5 };
            bool rs2 = Program.IsContains5Or6(A3);
            Assert.AreEqual(true, rs2);
        }

        [TestMethod]
        public void TestIsContains5And6()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            bool rs = Program.IsContains5And6(A1);
            Assert.AreEqual(false, rs);

            int[] A2 = new int[] { 1, 2, 3, 6 };
            bool rs1 = Program.IsContains5And6(A2);
            Assert.AreEqual(false, rs1);

            int[] A3 = new int[] { 1, 2, 3, 5 };
            bool rs2 = Program.IsContains5And6(A3);
            Assert.AreEqual(false, rs2);

            int[] A4 = new int[] { 1, 2, 6, 5 };
            bool rs3 = Program.IsContains5And6(A4);
            Assert.AreEqual(false, rs3);
        }

        [TestMethod]
        public void TestCounts5()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            int rs = Program.Counts5(A1);
            Assert.AreEqual(0, rs);

            int[] A2 = new int[] { 1, 2, 3, 5 };
            int rs1 = Program.Counts5(A2);
            Assert.AreEqual(1, rs1);

            int[] A3 = new int[] { 1, 5, 3, 5 };
            int rs2 = Program.Counts5(A3);
            Assert.AreEqual(2, rs2);
        }

        [TestMethod]
        public void TestCounts5Or6()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            int rs = Program.Counts5Or6(A1);
            Assert.AreEqual(0, rs);

            int[] A2 = new int[] { 1, 2, 3, 5 };
            int rs1 = Program.Counts5Or6(A2);
            Assert.AreEqual(1, rs1);

            int[] A3 = new int[] { 1, 6, 3, 5 };
            int rs2 = Program.Counts5Or6(A3);
            Assert.AreEqual(2, rs2);

            int[] A4 = new int[] { 1, 2, 3, 6 };
            int rs3 = Program.Counts5Or6(A4);
            Assert.AreEqual(1, rs3);
        }

        [TestMethod]
        public void TestSum()
        {
            int[] A1 = new int[] { 1, 2, 3, 4 };
            int rs = Program.SumArray(A1);
            Assert.AreEqual(10, rs);

            int[] A2 = new int[] { 1, 10, 3, 5 };
            int rs1 = Program.SumArray(A2);
            Assert.AreEqual(19, rs1);

            int[] A3 = new int[] { 1, 2, 3, 4, 8, 9, 10 };
            int rs2 = Program.SumArray(A3);
            Assert.AreEqual(37, rs2);
        }
    }
}
