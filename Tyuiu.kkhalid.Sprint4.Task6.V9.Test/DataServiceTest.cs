using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.kkhalid.Sprint4.Task6.V9.Lib;

namespace Tyuiu.kkhalid.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
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
            int res = ds.Calculate(array);

            // Подсчёт вручную:
            // Красный = 7 → нет
            // Оранжевый = 9 → нет
            // Желтый = 6 → да
            // Зеленый = 7 → нет
            // Синий = 5 → да
            // Индиго = 6 → да
            // Фиолетовый = 9 → нет
            // Итого: 3
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}