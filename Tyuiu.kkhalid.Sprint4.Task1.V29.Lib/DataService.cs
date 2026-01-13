using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kkhalid.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int sumOdd = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0) // нечётное
                {
                    sumOdd += num;
                }
            }
            return sumOdd;
        }
    }
}