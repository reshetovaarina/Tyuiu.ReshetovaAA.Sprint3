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
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+------------+--------------+");
            Console.WriteLine("|     x      |     f(x)     |");
            Console.WriteLine("+------------+--------------+");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0, 6:d}      |   {1, 6:f2}     |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+------------+--------------+");
            Console.ReadKey();
        }
    }
}