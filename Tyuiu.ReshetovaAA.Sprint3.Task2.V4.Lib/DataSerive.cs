using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1;
            int k = startValue;
            double sin1 = Math.Sin(1);
            double numerator = Math.Pow(sin1, 7);

            do
            {
                product *= Math.Pow(k * numerator, -2);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}