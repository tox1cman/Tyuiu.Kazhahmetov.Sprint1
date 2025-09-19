﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kazhahmetov.Sprint1.Task4.V29.Lib
{
    public class DataService : ISprint1Task4V29
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Sqrt(2 + Math.Abs(x - 2 * y))) / (3 * x * y * y), 3);
            return res;
        }
    }
}
