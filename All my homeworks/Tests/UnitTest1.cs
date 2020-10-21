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
        public void DoesItWorkWithNullReference()
        {
            Series.Program.Series10(10, null);
        }
    }
}
