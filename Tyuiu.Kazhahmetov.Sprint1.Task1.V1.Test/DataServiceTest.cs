﻿using Tyuiu.Kazhahmetov.Sprint1.Task1.V1.Lib;
namespace Tyuiu.Kazhahmetov.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 9.0;
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(54.67, res);
            
        }
    }
}
