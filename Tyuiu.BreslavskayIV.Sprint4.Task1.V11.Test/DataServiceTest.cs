using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task1.V11.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsarray = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            int res = ds.Calculate(numsarray);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
