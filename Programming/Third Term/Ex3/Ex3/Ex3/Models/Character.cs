using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.Models
{
    public class Character
    {
        private string _name;
        private @class _class;
        private string _faction;
        private string _location;
        private int _lvl;
        // private string _img;
        public string Name 
        { 
            get { return _name; }
        }
        public @class Class
        {
            get { return _class; }
        }
        public string Faction
        {
            get { return _faction; }
        }
        public string Location
        {
            get { return _location; } 
        }
        public int Level
        {
            get { return _lvl; }
        }
        /*
        public string Image
        {
            get { return _img; }
        }
        */
        public enum @class
        {
            Paladin,
            DeathKnight,
            Priest,
            Mage,
            Warlock,
            Warrior,
            Rogue,
            Hunter,
            Druid,
            Shaman
        }
        public Character(string name, int className, string faction, string location, int lvl)
        {
            _name = name;
            _class = (@class)className;
            _faction = faction;
            _location = location;
            _lvl = lvl;
        }

        public static Character CreateCharacter(string name, int className, string faction, string location, int lvl)
        {
            if (string.IsNullOrEmpty(name) || className < 0 || className > 9 || (faction.ToUpper() != "HORDE" && faction.ToUpper() != "ALLIANCE") 
                || string.IsNullOrEmpty(location) || lvl <= 0 || lvl > 80)
            {
                return null;
            }
            
            return new Character(name, className, faction, location, lvl);
        }
    }
}
