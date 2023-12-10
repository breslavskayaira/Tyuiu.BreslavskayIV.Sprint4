using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayIV.Sprint4.Task1.V11.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных    *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            DataService ds = new DataService();
            int len;
            Console.Write("*Введите количество элементов массива                                          ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numar = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("*Введите значение " + i + " элемента массива                                     ");
                numar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numar[i]+ "\t");
              
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(numar);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
