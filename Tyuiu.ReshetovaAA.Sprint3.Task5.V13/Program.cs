using System;
using Tyuiu.ReshetovaAA.Sprint3.Task5.V13.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Решетова А.А. | Вариант 13";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Вариант 13                                                              *");
            Console.WriteLine("* Задание 5                                                               *");
            Console.WriteLine("* Условие: вычислить двойную сумму                                        *");
            Console.WriteLine("* y = Σ(i=1..3) Σ(k=1..12) (cos(x) + k/2), при x = 5                      *");
            Console.WriteLine("***************************************************************************");

            int x = 5;

            double result = ds.GetSumSumSeries(x, 1, 1, 3, 12);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"Значение функции = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}