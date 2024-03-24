using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    static class CustomFunctions
    {
        public static string FirstLetterToCapital(string word)
        {
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i > 0)
                    newWord += word[i].ToString().ToLower();
                else
                    newWord += word[i].ToString().ToUpper();
            }
            return newWord;
        }


    }
}
