using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kkhalid.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] resultArray = (int[,])array.Clone(); // копируем массив

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (resultArray[i, j] % 2 != 0) // нечётное
                    {
                        resultArray[i, j] = 0;
                    }
                }
            }
            return resultArray;
        }
    }
}