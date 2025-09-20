using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kazhahmetov.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            var d = Math.Floor((x * 10) % 10);
            return Convert.ToInt32(d);
        }
    }
}
