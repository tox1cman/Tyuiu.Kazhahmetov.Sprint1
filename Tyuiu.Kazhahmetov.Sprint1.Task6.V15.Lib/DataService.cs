using System.Linq.Expressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Kazhahmetov.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            var symb = 0;
            var word = 0;
            foreach(var ch in value)
            {
                if (char.IsLetter(ch))
                {
                    word++;
                }
                else
                {
                    symb++;
                }
            }
            if (word > symb)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
