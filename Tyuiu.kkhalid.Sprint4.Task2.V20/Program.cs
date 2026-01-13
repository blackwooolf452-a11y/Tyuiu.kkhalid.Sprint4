using System;
using Tyuiu.kkhalid.Sprint4.Task2.V20.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[16];

            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Одномерные массивы (генерация случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов, заполненный       *");
            Console.WriteLine("* случайными числами в диапазоне от 2 до 7.                              *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            Console.WriteLine("* Сгенерированный массив:                                                *");
            Console.Write("* { ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 8); // от 2 до 7 включительно
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма чётных элементов = {result}                                      *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}