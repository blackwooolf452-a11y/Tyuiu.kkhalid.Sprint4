using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.kkhalid.Sprint4.Task5.V16.Lib
{
    public class DataService : ISprint4Task5V16
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] resultArray = (int[,])array.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (resultArray[i, j] > 0) // положительное
                    {
                        resultArray[i, j] = 1;
                    }
                }
            }
            return resultArray;
        }
    }
}