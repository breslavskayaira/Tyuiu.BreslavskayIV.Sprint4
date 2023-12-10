using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayIV.Sprint4.Task6.V30.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var nums = new string[] {"Береза", "Дуб", "Клен", "Сосна", "Пихта", "Осина"};

            string[] res = ds.Calculate(nums);
            string a = res[0];
            string wait = "Береза";

            Assert.AreEqual(wait, a);
        }
    }
}

