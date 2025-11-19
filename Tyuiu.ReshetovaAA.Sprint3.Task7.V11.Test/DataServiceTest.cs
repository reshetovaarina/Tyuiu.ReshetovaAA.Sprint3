using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint3.Task7.V11.Lib;
using System;

namespace Tyuiu.ReshetovaAA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] arr = ds.GetMassFunction(start, stop);

            Assert.AreEqual(11, arr.Length);

            double expected1 = Math.Round(Math.Cos(-5) + Math.Sin(-5) / (2 - 2 * (-5)) - 4 * (-5), 2);
            Assert.AreEqual(expected1, arr[0]);

            Assert.AreEqual(0, arr[6]);
        }
    }
}