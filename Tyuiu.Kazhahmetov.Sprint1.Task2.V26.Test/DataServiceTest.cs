using System.Net.WebSockets;
using Tyuiu.Kazhahmetov.Sprint1.Task2.V26.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalendarCheck()
        {
            DataService ds = new DataService();
            int value = 12;
            int valueTwo = 40;
            var res = ds.CalculateMinutesSinceStart(value, valueTwo);
            Assert.AreEqual(760, res);
        }
    }
}
