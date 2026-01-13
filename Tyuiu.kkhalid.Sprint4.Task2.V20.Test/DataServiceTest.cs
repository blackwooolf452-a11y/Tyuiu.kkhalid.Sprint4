using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.kkhalid.Sprint4.Task2.V20.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 4, 6, 3, 7, 2, 4, 5, 6, 3, 7, 4, 6, 2, 7 };
            int res = ds.Calculate(array);
            int wait = 2 + 4 + 6 + 2 + 4 + 6 + 4 + 6 + 2; // чётные: 2,4,6,2,4,6,4,6,2 = 36
            Assert.AreEqual(wait, res);
        }
    }
}