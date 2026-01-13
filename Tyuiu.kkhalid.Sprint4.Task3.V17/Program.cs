using System;
using Tyuiu.kkhalid.Sprint4.Task3.V17.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] {
                {6, 4, 2, 2, 1},
                {3, 6, 5, 4, 1},
                {5, 2, 3, 1, 6},
                {8, 8, 4, 5, 3},
                {7, 4, 5, 1, 6}
            };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8.                         *");
            Console.WriteLine("* Найти сумму элементов в четвёртом столбце массива.                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("* Массив 5x5:                                                            *");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма элементов в четвёртом столбце = {result}                        *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}