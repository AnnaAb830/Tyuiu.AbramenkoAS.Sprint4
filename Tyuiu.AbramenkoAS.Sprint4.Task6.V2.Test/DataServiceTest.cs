using Tyuiu.AbramenkoAS.Sprint4.Task6.V2.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            string[] wait = new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };

            string[] res = ds.Calculate(colors);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
