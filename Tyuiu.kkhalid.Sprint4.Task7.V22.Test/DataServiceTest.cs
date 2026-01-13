using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.kkhalid.Sprint4.Task7.V22.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task7V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            string value = "695324951753684";
            int res = ds.Calculate(n, m, value);

            // Матрица 5x3:
            // 6 9 5
            // 3 2 4
            // 9 5 1
            // 7 5 3
            // 6 8 4
            // Чётные числа: 6,2,4,6,8,4
            // Произведение: 6*2=12 → 12*4=48 → 48*6=288 → 288*8=2304 → 2304*4=9216
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}