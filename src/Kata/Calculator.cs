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

            var delimiters = new[] {"\n", ","};

            if (s.Contains("//"))
            {
                var splitText = s.Split("\n");
                delimiters = new[] {splitText[0].Replace("/", "")};
                s = splitText[1];
            }

            var numbers = s.Split(delimiters, StringSplitOptions.None).Select(int.Parse);

           
            return numbers.Sum();
        }
    }
}