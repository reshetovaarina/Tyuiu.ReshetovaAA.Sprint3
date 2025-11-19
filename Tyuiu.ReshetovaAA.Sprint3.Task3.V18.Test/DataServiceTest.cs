using Tyuiu.ReshetovaAA.Sprint3.Task3.V18.Lib;

namespace Tyuiu.ReshetovaAA.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "4n5nvf 56 bgy";
            char item = 'n';
            string expected = "nnnnvf nn bgy";

            string result = ds.ReplaceNumOnChar(value, item);

            Assert.AreEqual(expected, result);
        }
    }
}