using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    static class DataValidator
    {
        public static string IsCharacterValid(string name, string level, string faction, string location)
        {
            /* Instead of creating a class to check if my the data used is correct. Why
             * not create a static class which only feature is validate the data to
             * update. As this is just an optional task, I will test if this is a new way
             * to improve or code, or just a nonesense.*/

            // errorMessage will always be empty if our Character is valid.
            string errorMessage = "";
            if (string.IsNullOrEmpty(name) || name.Length < 3)
            {
                errorMessage += " name,";
            }
            if (CustomRegex.RegexLevel(level.ToString()))
            {
                errorMessage += " level,";
            }
            if (faction.ToUpper() != "Alliance" && faction.ToUpper() != "Horde")
            {
                errorMessage += " faction,";
            }
            if (string.IsNullOrEmpty(location))
            {
                errorMessage += " location,";
            }
            if (errorMessage != "")
            {
                // This will remove the last character, which is a coma.
                errorMessage.Remove(errorMessage.Length - 1);
            }
            return errorMessage;
        }
    }
}
