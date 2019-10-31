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

            
            var numbers = s.Split(delimiters,StringSplitOptions.None).Select(int.Parse);

            return numbers.Sum();
        }
    }
}