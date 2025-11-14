using Tyuiu.ReshetovaAA.Sprint3.Task1.V28.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double expected = -0.186;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}
