using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ReshetovaAA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1;
            double value = 0.1;
            for (int k = startValue; k <= stopValue; k++)
            {
                result *= (Math.Sin(value) + k);
            }

            return Math.Round(result, 3);

        }
    }
}