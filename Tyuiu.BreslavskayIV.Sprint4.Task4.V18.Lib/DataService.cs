using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BreslavskayIV.Sprint4.Task4.V18.Lib
{
    public class DataService : ISprint4Task4V18
    {
        public int[,] Calculate(int[,] array)
        {
            int r = array.GetUpperBound(0) + 1;
            int c = array.Length / r;

            
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                   if (array[i, j] %2 ==1)
                    {
                        array[i, j] = 0;
                    }
                }

            }
            return array;
        }
    }
}