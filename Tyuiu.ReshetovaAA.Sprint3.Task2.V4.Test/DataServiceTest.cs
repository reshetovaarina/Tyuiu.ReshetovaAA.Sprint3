using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double expected = 1;
            double sin1 = Math.Sin(1);
            double numerator = Math.Pow(sin1, 7);

            for (int k = 1; k <= 9; k++)
            {
                expected *= Math.Pow(k * numerator, -2);
            }
            expected = Math.Round(expected, 3);

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}