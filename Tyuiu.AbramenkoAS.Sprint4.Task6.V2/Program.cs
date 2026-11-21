using Tyuiu.AbramenkoAS.Sprint4.Task6.V2.Lib;

namespace Tyuiu.AbramenkoAS.Sprint4.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Абраменко А. С. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Белый\", \"Черный\", \"Зеленый\",              *");
            Console.WriteLine("* \"Синий\", \"Красный\", \"Желтый\", \"Фиолетовый\"], используя класс            *");
            Console.WriteLine("* Array, выведите элементы массива, длина которых больше 5 символов.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= colors.Length - 1; i++)
            {
                Console.WriteLine(colors[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы, длина которых > 5:");

            string[] result = ds.Calculate(colors);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}
