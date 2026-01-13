using System;
using Tyuiu.kkhalid.Sprint4.Task7.V22.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 5; // строки
            int m = 3; // столбцы
            string value = "695324951753684";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Обработка строк и преобразование в матрицу                       *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #22                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"695324951753684\".                  *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение чётных чисел.");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* n (строки) = {n}                                                       *");
            Console.WriteLine($"* m (столбцы) = {m}                                                      *");
            Console.WriteLine($"* Строка цифр = \"{value}\"                                              *");
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(n, m, value);

            // Вывод матрицы для наглядности
            Console.WriteLine("* Матрица 5x3:                                                           *");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} ");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Произведение чётных чисел = {result}                                   *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}