using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task2.V4.Test
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
            int i = 1;
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
                expected *= Math.Pow(i / denominator, -2);
                i++;
            }
            expected = Math.Round(expected, 3);

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}}