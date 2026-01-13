using System;
using Tyuiu.kkhalid.Sprint4.Task5.V16.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task5.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            int[,] array = new int[5, 5];

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (генерация случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 3.                          *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("* Сгенерированный массив:                                                *");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-6, 4); // от -6 до 3 включительно
                    Console.Write($"{array[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");

            int[,] result = ds.Calculate(array);

            Console.WriteLine("* Массив после замены положительных элементов на 1:                      *");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{result[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}