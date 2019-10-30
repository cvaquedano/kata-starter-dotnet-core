using System;
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

            var delimiters = new string[] { ",", "\n" };

            if (s.Contains("//"))
            {
                var splittedText = s.Split("\n");
                var delimiter = splittedText[0].Replace("/", "");
                delimiters = new[] {delimiter};
                s = splittedText[1];


            }
            
            var numbers = s.Split(delimiters, StringSplitOptions.None).Select(int.Parse);

            var negatives = numbers.Where(x => x < 0);
            if (negatives.Count() == 1)
            {
                throw new Exception("negatives not allowed: " + negatives.First());
            }
            return numbers.Sum();
        }
    }
}