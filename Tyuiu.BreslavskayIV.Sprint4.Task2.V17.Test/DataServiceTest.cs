using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task2.V17.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsarray = { 4,4,4,4,4,4,4,4,4 };
            int res = ds.Calculate(numsarray);
            int wait = 1;

            Assert.AreEqual(wait, res);
        }
    }
}
