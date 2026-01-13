using System;
using Tyuiu.kkhalid.Sprint4.Task4.V30.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5];

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7.                         *");
            Console.WriteLine("* Заменить нечётные элементы массива на 0.                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("* Введите элементы массива 5x5 (целые числа от 3 до 7):                  *");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"* Элемент [{i},{j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Исходный массив:                                                       *");
            PrintArray(array);

            int[,] result = ds.Calculate(array);

            Console.WriteLine("* Массив после замены нечётных элементов на 0:                           *");
            PrintArray(result);

            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}