using Tyuiu.AbramenkoAS.Sprint4.Task2.V21.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] nums = { 4, 7, 5, 4, 6, 5, 2, 7, 4, 1, 2, 5, 6, 3, 3 };
            int res = ds.Calculate(nums);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
