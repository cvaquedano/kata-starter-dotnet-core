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

            if (s.Contains("//"))
            {
                var splittedText = s.Split("\n");
                var delimiter = splittedText[0].Replace("/","");
                delimiters = new[] {delimiter};
                s = splittedText[1];
            }

            var numbers = s.Split(delimiters, StringSplitOptions.None).Select((int.Parse));

            var negative = numbers.FirstOrDefault(x => x < 0);

            if (negative != 0)
            {
                throw new Exception("negatives not allowed: " + negative);
            }
            
            return numbers.Sum();
        }
    }
}