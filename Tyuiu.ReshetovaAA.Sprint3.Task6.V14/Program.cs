using System;
using Tyuiu.ReshetovaAA.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";

            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #                                                               *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Вариант 14                                                              *");
            Console.WriteLine("* Задание 6                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Условие:                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найти среди чисел [7,16] количество делителей каждого числа,            *");
            Console.WriteLine("*         которые больше 5.                                               *");
            Console.WriteLine("***************************************************************************");

            int start = 7;
            int stop = 16;

            int result = ds.GetCountDividers(start, stop);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"Количество делителей > 5 = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}