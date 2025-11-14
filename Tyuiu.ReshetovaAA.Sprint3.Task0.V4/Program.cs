using System;
using Tyuiu.ReshetovaAA.Sprint3.Task0.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая с помощью цикла for вычисляет произведение  *");
            Console.WriteLine("* ряда по формуле:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        7                                                                *");
            Console.WriteLine("*   P =  Π (sin(0.1) + k)                                                  *");
            Console.WriteLine("*       k = 1                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.1;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine($"Значение аргумента: {value}");
            Console.WriteLine($"Начало ряда: {startValue}");
            Console.WriteLine($"Конец ряда:  {stopValue}");

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
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
