using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramenkoAS.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult = mult * array[i];
                }
            }
            return mult;
        }
    }
}
