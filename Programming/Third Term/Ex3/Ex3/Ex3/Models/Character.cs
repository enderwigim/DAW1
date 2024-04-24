using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Models
{
    public class Character
    {
        private string _name;
        private string _class;
        private string _faction;
        private string _location;
        private int _lvl;

        public Character(string name, string @class, string faction, string location, int lvl)
        {
            _name = name;
            _class = @class;
            _faction = faction;
            _location = location;
            _lvl = lvl;
        }

        public static Character CreateCharacter(string name, string @class, string faction, string location, int lvl)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(@class) || string.IsNullOrEmpty(faction) || string.IsNullOrEmpty(location) || lvl <= 0 || lvl >= 100)
            {
                return null;
            }
            return new Character(name, @class, faction, location, lvl);
        }
    }
}
