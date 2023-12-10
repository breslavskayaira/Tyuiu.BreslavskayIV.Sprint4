using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] nums = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                          {5, 5, 5, 4, 6},
                                          {8, 5, 7, 4, 7},
                                          {7, 6, 7, 4, 7},
                                          {5, 4, 7, 4, 4} };

            int [,] res = ds.Calculate(nums);
            int [,] wait = new int[5, 5] { { 0, 0, 6, 6, 0 },
                                          {0, 0, 0, 4, 6},
                                          {8, 0, 0, 4, 0},
                                          {0, 6, 0, 4, 0},
                                          {0, 4, 0, 4, 4} };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}