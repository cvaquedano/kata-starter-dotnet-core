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
                delimiters = new []{ splittedText[0].Replace("/","")};
                s = splittedText[1];
            }
            var elementos =  s.Split(delimiters,StringSplitOptions.None).Select(int.Parse);

            return elementos.Sum();
        }
    }
}