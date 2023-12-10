using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayIV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #18                                                              *");
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

            
            Console.Write("*Введите количество строк массива                                          ");
            int lenr = Convert.ToInt32(Console.ReadLine());
            Console.Write("*Введите количество столбцов массива                                          ");
            int lenc = Convert.ToInt32(Console.ReadLine());


            int[,] nums = new int[lenr, lenc];


            for (int i = 0; i < lenr; i++)
            {
                for (int j = 0; j < lenc; j++)
                {
                    Console.Write($" Введите {i},{j} элемент массива ");
                    nums[i, j] = Convert.ToInt32(Console.ReadLine());
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

            int[,] res = ds.Calculate(nums);
            Console.WriteLine("Итоговый массив: ");
            for (int i = 0; i < lenr; i++)
            {
                for (int j = 0; j < lenc; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

