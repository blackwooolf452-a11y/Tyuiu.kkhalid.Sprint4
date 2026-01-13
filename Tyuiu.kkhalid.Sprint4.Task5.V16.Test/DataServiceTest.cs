using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.kkhalid.Sprint4.Task5.V16.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] {
                { -2, 1, -5, 0, 3 },
                { 2, -3, -1, 2, -4 },
                { -6, 0, 1, -2, 3 },
                { 1, -5, 2, -1, 0 },
                { -3, 2, -4, 1, -6 }
            };
            int[,] res = ds.Calculate(array);
            int[,] wait = new int[5, 5] {
                { -2, 1, -5, 0, 1 },
                { 1, -3, -1, 1, -4 },
                { -6, 0, 1, -2, 1 },
                { 1, -5, 1, -1, 0 },
                { -3, 1, -4, 1, -6 }
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}