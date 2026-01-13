using System;
using Tyuiu.kkhalid.Sprint4.Task1.V29.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[14];

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9.                         *");
            Console.WriteLine("* Подсчитать сумму нечётных элементов массива.                           *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("* Введите 14 элементов массива (целые числа от 1 до 9):                  *");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"* Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма нечётных элементов = {result}                                    *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}