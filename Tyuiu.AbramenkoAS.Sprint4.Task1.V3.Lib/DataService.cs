using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramenkoAS.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
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
