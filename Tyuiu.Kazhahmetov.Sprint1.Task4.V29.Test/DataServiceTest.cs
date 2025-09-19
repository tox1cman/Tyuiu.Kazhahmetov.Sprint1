using Tyuiu.Kazhahmetov.Sprint1.Task4.V29.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckMath()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double total = 0.17;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(total, res);
        }
    }
}
