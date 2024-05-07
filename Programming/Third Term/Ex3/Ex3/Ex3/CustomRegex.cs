using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex3
{
    static class CustomRegex
    {
        public static bool RegexLevel(string input)
        {
            // Valid if input is a number less than 99
            string regex = "^[1-9][0-9]?$";
            return new Regex(regex).IsMatch(input);
        }
    }
}
