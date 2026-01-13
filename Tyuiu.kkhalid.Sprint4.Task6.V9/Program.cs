using System;
using Tyuiu.kkhalid.Sprint4.Task6.V9.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] array = new string[] {
                "Красный",
                "Оранжевый",
                "Желтый",
                "Зеленый",
                "Синий",
                "Индиго",
                "Фиолетовый"
            };

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Обработка строковых массивов                                     *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных:                                           *");
            Console.WriteLine("* [\"Красный\", \"Оранжевый\", \"Желтый\", \"Зеленый\", \"Синий\", \"Индиго\", \"Фиолетовый\"]");
            Console.WriteLine("* используя класс Array, подсчитайте количество элементов,               *");
            Console.WriteLine("* длина которых меньше 7.                                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.Write("* Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\"{array[i]}\"");
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");

            int result = ds.Calculate(array);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Количество элементов с длиной меньше 7 = {result}                      *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}