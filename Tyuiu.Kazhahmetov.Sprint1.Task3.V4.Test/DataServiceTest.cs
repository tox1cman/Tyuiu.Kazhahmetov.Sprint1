using Tyuiu.Kazhahmetov.Sprint1.Task3.V4.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckPurchaseAmount()
        {
            DataService ds = new DataService();
            double NoteBook = 2.75;
            double Cover = 0.5;
            int quantity = 7;
            var res = ds.PurchaseAmount(NoteBook, Cover, quantity);
            Assert.AreEqual(22.75, res);
        }
    }
}
