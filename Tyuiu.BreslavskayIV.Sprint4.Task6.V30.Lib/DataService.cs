using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BreslavskayIV.Sprint4.Task6.V30.Lib
{
    public class DataService: ISprint4Task6V30
    {
        public string[] Calculate(string[] arrayStrings)
        {
            string[] mas = Array.FindAll(arrayStrings, week => week.Length > 5);
            return mas;

        }
    }
}
