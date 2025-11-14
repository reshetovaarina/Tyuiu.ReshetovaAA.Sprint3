using Tyuiu.ReshetovaAA.Sprint3.Task0.V4.Lib;
namespace Tyuiu.ReshetovaAA.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.1;
            int startValue = 1;
            int stopValue = 7;

            double expected =
                Math.Round(
                (Math.Sin(value) + 1) *
                (Math.Sin(value) + 2) *
                (Math.Sin(value) + 3) *
                (Math.Sin(value) + 4) *
                (Math.Sin(value) + 5) *
                (Math.Sin(value) + 6) *
                (Math.Sin(value) + 7), 3);

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}