﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kazhahmetov.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            var res = (2 * (1 / Math.Tan(3 * x))) - ((Math.Log(Math.Cos(x))) / (Math.Log(1 + x * x)));
            return Math.Round(res, 3);
        }
    }
}
