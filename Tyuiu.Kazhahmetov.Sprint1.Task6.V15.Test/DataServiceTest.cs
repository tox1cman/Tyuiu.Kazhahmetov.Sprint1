using Tyuiu.Kazhahmetov.Sprint1.Task6.V15.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSymbols()
        {
            string value = "hello----";
            var wait = true;
            DataService ds = new DataService();
            var res = ds.CheckLettersCount(value);
            Assert.AreEqual(wait, res);
        }
    }
}
