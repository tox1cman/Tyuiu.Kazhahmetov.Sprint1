using Tyuiu.Kazhahmetov.Sprint1.Task7.V10.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateCheck()
        {
            DataService ds = new DataService();
            var x = 1;
            var res = ds.Calculate(x);
            var wait = -13.142;
            Assert.AreEqual(wait, res);
        }
    }
}
