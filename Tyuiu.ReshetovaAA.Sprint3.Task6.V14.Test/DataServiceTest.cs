using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCountDividers()
        {
            DataService ds = new DataService();

            int start = 7;
            int stop = 16;
            int expected = 13;

            int result = ds.GetCountDividers(start, stop);

            Assert.AreEqual(expected, result);
        }
    }
}
