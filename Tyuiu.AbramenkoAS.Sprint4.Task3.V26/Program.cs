using Tyuiu.AbramenkoAS.Sprint4.Task3.V26.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] {
                { 4, 3, 2, 6, 2 },
                { 5, 2, 2, 5, 6 },
                { 2, 5, 4, 5, 6 },
                { 4, 5, 2, 4, 6 },
                { 6, 5, 4, 3, 6 }
            };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы(статический ввод)                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент во второй строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Максимальный элемент во второй строке = " + res);

            Console.ReadKey();
        }
    }
}
