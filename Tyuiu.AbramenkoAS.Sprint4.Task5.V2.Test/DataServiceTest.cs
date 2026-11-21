using Tyuiu.AbramenkoAS.Sprint4.Task5.V2.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -1, 0, 1, 2, 3 },
                                          { -2, 4, 5, 0, 1 },
                                          { 0, 0, 0, 0, 0 },
                                          { 1, 2, 3, 4, 5 },
                                          { -3, -4, -5, 0, 0 } };

            int res = ds.Calculate(mas2);
            int wait = 5; 

            Assert.AreEqual(wait, res);
        }
    }
}
