using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayIV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив на 5 на 5 элементов, заполненный      *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4 подсчитать количество       *");
            Console.WriteLine("* положительных элементов массива.                                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("*Введите количество строк массива ");
            int lenr = Convert.ToInt32(Console.ReadLine());
            Console.Write("*Введите количество столбцов массива ");
            int lenc = Convert.ToInt32(Console.ReadLine());

            int[,] nums = new int[lenr, lenc];

            Random rnd = new Random();
            for (int i = 0; i < lenr; i++)
            {
                for (int j = 0; j < lenc; j++)
                {
                    int a = rnd.Next(-4, 5);
                    nums[i,j] = a;
                }

            }
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < lenr; i++)
            {
                for (int j = 0; j < lenc; j++)
                {
                    Console.Write($"{nums[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(nums);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
