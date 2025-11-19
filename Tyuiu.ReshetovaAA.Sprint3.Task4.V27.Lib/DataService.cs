using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ReshetovaAA.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                sum += x / (Math.Cos(x) + Math.Sin(x));
            }

            return Math.Round(sum, 3);
        }
    }
}