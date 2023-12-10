using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskayIV.Sprint4.Task6.V30.Lib;

namespace Tyuiu.BreslavskayIV.Sprint4.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                        *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан cтроковый массив [Береза, Дуб, Клен, Сосна, Пихта, Осина],           *");
            Console.WriteLine("* вывести элементы массива, длина которых больше 5                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            string[] mas = { "Береза", "Дуб", "Клен", "Сосна", "Пихта", "Осина" };
            
            DataService ds = new DataService();



            Console.WriteLine("****************************************************************************");
           
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string[] res = ds.Calculate(mas);
            Console.WriteLine(res[0]);
            Console.ReadKey();
        }
    }
}