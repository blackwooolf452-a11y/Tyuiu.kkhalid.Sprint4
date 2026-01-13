using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kkhalid.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int sum = 0;
            int colIndex = 3; // четвёртый столбец (индекс 3)

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, colIndex];
            }
            return sum;
        }
    }
}