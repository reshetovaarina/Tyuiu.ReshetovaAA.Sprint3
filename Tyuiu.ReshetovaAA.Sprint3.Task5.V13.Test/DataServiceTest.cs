using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint3.Task5.V13.Lib;
using System;

namespace Tyuiu.ReshetovaAA.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int x = 5;
            int startI = 1;
            int stopI = 3;
            int startK = 1;
            int stopK = 12;

            double expected = 0;
            double c = Math.Cos(x);

            for (int i = startI; i <= stopI; i++)
            {
                for (int k = startK; k <= stopK; k++)
                {
                    expected += c + (k / 2.0);
                }
            }

            expected = Math.Round(expected, 3);

            double result = ds.GetSumSumSeries(x, startI, startK, stopI, stopK);

            Assert.AreEqual(expected, result);
        }
    }
}