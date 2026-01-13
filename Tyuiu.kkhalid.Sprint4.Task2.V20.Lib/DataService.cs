using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kkhalid.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
        public int Calculate(int[] array)
        {
            int sumEven = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0) // чётное
                {
                    sumEven += num;
                }
            }
            return sumEven;
        }
    }
}