using System;
using Tyuiu.ReshetovaAA.Sprint3.Task7.V11.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулирование функции на диапазоне [-5;5]                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            double[] result = ds.GetMassFunction(start, stop);

            Console.WriteLine("РЕЗУЛЬТАТ:");

            int x = start;
            foreach (double v in result)
            {
                Console.WriteLine("x =" + x +  "→  F(x) = " + v);
                x++;
            }

            Console.ReadKey();
        }
    }
}