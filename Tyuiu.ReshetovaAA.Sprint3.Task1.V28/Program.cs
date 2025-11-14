using System;
using Tyuiu.ReshetovaAA.Sprint3.Task1.V28.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая с помощью цикла while вычисляет сумму ряда  *");
            Console.WriteLine("* по формуле:                                                             *");
            Console.WriteLine("*       18                                                                *");
            Console.WriteLine("*  S =  Σ  (a^k + 0,25) cos k                                             *");
            Console.WriteLine("*      k = 1                                                              *");
            Console.WriteLine("* при a = 0,5                                                             *");
            Console.WriteLine("***************************************************************************");

            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
