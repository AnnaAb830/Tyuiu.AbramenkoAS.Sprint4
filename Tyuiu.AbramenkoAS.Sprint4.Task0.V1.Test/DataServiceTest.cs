using Tyuiu.AbramenkoAS.Sprint4.Task0.V1.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            int res = 20;

            int wait = ds.GetSumEvenArrEl(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
