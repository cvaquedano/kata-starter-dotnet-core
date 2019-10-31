using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            var delimiters = new []{"\n",","};
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Contains("/"))
            {
                var textSplitted = s.Split("\n");
                var delimiter = textSplitted[0].Replace("/","");
                s = textSplitted[1];
                delimiters = new[] {delimiter};
            }

            
            var numbers = s.Split(delimiters,StringSplitOptions.None).Select(int.Parse).Where(x=> x < 1001);

            var negative = numbers.Where(x => x < 0);
            if (negative.Any())
            {
                throw new Exception("negatives not allowed: " + string.Join(", ", negative));
    
            }

            return numbers.Sum();
        }
    }
}