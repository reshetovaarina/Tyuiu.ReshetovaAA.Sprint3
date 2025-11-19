using System;
using Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операторы continue и break в циклах                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет произведение*");
            Console.WriteLine("* ряда по формуле: p = ∏(k=1 до 9) (k/sin(1)^7)^(-2)                     *");
            Console.WriteLine("* с использованием операторов continue и break                            *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 9;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение ряда = {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}