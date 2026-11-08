using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramenkoAS.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int targetRow = 1;

            int max = array[targetRow, 0];

            for (int j = 1; j < columns; j++)
            {
                if (array[targetRow, j] > max)
                {
                    max = array[targetRow, j];
                }
            }

            return max;
        }
    }
}
