using Tyuiu.AbramenkoAS.Sprint4.Task0.V1.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы(статический ввод)                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
            Console.WriteLine("* чётных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            Console.Write("Исходный массив: { ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i]);
                if (i < numsArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sum = ds.GetSumEvenArrEl(numsArray);

            Console.WriteLine("Сумма чётных элементов массива = " + sum);

            Console.ReadKey();
        }
    }
}
