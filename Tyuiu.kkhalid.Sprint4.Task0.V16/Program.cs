using System;
using Tyuiu.kkhalid.Sprint4.Task0.V16.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9.                         *");
            Console.WriteLine("* Подсчитать произведение чётных элементов массива.                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.Write("* Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");
            Console.WriteLine("**************************************************************************");

            int result = ds.GetMultEvenArrEl(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Произведение чётных элементов = {result}                               *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}