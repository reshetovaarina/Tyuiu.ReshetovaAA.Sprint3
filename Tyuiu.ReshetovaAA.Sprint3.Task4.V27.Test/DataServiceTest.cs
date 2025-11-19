using Tyuiu.ReshetovaAA.Sprint3.Task4.V27.Lib;
namespace Tyuiu.ReshetovaAA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            double expected = 0;
            for (int x = -5; x <= 5; x++)
            {
                if (x == 0) continue;
                expected += x / (Math.Cos(x) + Math.Sin(x));
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}