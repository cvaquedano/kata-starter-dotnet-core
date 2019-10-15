using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var elementos =  s.Split(',');
            
            if (elementos.Length == 1)
            {
                return int.Parse(elementos[0]);
            }

            return int.Parse(elementos[0]) + int.Parse(elementos[1]);
           
        }
    }
}