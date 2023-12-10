using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task7.V21.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int r = 4;
            int c = 3;
            DataService ds = new DataService();

            string str = "425963128528";
            int res = ds.Calculate(r, c, str);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}