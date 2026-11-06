using Tyuiu.AbramenkoAS.Sprint4.Task1.V3.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] nums = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };
            int res = ds.Calculate(nums);
            int wait = 3072;
            Assert.AreEqual(wait, res);
        }
    }
}
