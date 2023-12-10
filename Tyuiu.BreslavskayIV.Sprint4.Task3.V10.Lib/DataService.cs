using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BreslavskayIV.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int r = array.GetUpperBound(0) + 1;
            int c = array.Length / r;

            int s = 0;
            for (int i = 0; i <r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 2)
                    {
                        if (array[i,j]>s)
                        {
                            s = array[i, j];
                        }
                    }
                }
                
            }
            return s;
        }
    }
}