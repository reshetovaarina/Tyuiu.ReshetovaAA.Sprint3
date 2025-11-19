using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReshetovaAA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 - 2 * x;

                double value;

                if (denominator == 0)
                {
                    value = 0; 
                }
                else
                {
                    value = Math.Cos(x) + (Math.Sin(x) / denominator) - 4 * x;
                }

                result[index] = Math.Round(value, 2);
                index++;
            }

            return result;
        }
    }
}