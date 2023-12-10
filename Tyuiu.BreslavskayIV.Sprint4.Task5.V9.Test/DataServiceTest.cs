using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] nums = new int[5, 5] { { 1, 1, 1, 1, 1 },
                                          {1, 1, 1, 1, 1},
                                          {1, 1, 1, 1, 1},
                                          {1, 1, 1, 1, 1},
                                          {1, 1, 1, 1, 1} };

            int res = ds.Calculate(nums);
            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}