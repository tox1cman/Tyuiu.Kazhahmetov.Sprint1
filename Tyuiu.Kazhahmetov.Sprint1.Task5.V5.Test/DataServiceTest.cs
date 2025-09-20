using Tyuiu.Kazhahmetov.Sprint1.Task5.V5.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateCheck()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int res = 5;
            Assert.AreEqual(res, ds.Calculate(x));
        }
    }
}
