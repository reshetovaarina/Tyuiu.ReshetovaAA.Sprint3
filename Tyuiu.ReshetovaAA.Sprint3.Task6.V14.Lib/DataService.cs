using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReshetovaAA.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetCountDividers(int startValue, int stopValue)
        {
            int total = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                for (int d = 1; d <= n; d++)
                {
                    if (n % d == 0 && d > 5)
                    {
                        total++;
                    }
                }
            }

            return total;
        }

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}