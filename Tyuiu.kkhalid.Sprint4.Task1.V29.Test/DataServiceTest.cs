using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.kkhalid.Sprint4.Task1.V29.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int res = ds.Calculate(array);
            int wait = 5 + 3 + 3 + 1 + 3 + 3 + 5 + 7 + 1; // = 31
            Assert.AreEqual(wait, res);
        }
    }
}