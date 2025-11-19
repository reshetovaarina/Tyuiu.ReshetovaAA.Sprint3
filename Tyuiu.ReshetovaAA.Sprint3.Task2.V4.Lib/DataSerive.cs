using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiply = 1;
            int i = startValue;
            double sin1 = Math.Sin(1);
            double denominator = Math.Pow(sin1, 7);

            while (i <= stopValue)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 8)
                {
                    break;
                }

                multiply *= Math.Pow(i / denominator, -2);
                i++;
            }

            return Math.Round(multiply, 3);
        }
    }
}