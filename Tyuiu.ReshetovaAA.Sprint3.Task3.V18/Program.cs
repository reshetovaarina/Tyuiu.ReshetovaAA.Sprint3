using System;
using Tyuiu.ReshetovaAA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка строковых данных                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву 'n' в строке:           *");
            Console.WriteLine("* '4n5nvf 56 bgy'                                                         *");
            Console.WriteLine("***************************************************************************");

            string value = "4n5nvf 56 bgy";
            char item = 'n';
            string result = ds.ReplaceNumOnChar(value, item);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Преобразованная строка: {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}