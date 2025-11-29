using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReshetovaAA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 - 2 * x;

                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) + (Math.Sin(x) / denominator) - (4 * x), 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}