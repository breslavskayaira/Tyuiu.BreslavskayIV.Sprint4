using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task0.V9.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsarray = {4,6,2,8,4,5,6,9,8,7};
            int res = ds.GetSumEvenArrEl(numsarray);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
