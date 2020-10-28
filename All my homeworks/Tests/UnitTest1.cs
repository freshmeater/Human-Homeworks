using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFor1()
        {
            int a = 2;
            Assert.AreEqual(For.Program.For13(a), a switch
            {
                1 => 1.1,
                2 => -0.09999999999999987,
                3 => 1.2000000000000002,
                _ => For.Program.For13(a)
            });
        }
        [TestMethod]
        public void IsSetOfNumberLastDigitIsZero()
        {
            int[] a;
            for(int i = 0;i<100;i++)
            {
                a = Input.Program.SetOfNumbers();
                Assert.AreEqual(a[a.Length - 1], 0);
            }
        }
        [TestMethod]
        public void IsSeries10AnswerIsCorrect()
        {
            int[] a=new int[10];
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++) a[j] = r.Next(11);
                Assert.AreEqual(Series.Program.Series10(10, a), true);
            }
            {
                for (int j = 0; j < 10; j++) a[j] = r.Next(11)-10;
                Assert.AreEqual(Series.Program.Series10(10, a), false);
            }
        }
        [TestMethod]
        public void DoesSeries10WorkWithNullReference()
        {
            Series.Program.Series10(10, null);
        }
        [TestMethod]
        public void Func6AbramiansTestingTask()
        {
            int a, b;

            Func.Program.DigitCountSum(12, out a, out b);
                Assert.AreEqual(a, 2);
                Assert.AreEqual(b, 3);

            Func.Program.DigitCountSum(236, out a, out b);
                Assert.AreEqual(a, 3);
                Assert.AreEqual(b, 11);

            Func.Program.DigitCountSum(9999, out a, out b);
                Assert.AreEqual(a, 4);
                Assert.AreEqual(b, 36);

            Func.Program.DigitCountSum(123456789, out a, out b);
                Assert.AreEqual(a, 9);
                Assert.AreEqual(b, 45);

            Func.Program.DigitCountSum(36743, out a, out b);
                Assert.AreEqual(a, 5);
                Assert.AreEqual(b, 23);
        }
        [TestMethod]
        public void Func8AbramiansTestingTask()
        {
            int k = 10;
            Func.Program.AddRightDigit(9, ref k);
            Func.Program.AddRightDigit(6, ref k);
            Assert.AreEqual(k, 1096);
        }
        [TestMethod]
        public void Func16AbramiansTestingTask()
        {
            Assert.AreEqual(Func.Program.Sign(0) + Func.Program.Sign(-1), -1);
        }
    }
}
