using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Characters
{
    public class Player : Character // it inherits from the class Character!
    {
        public Player(string name) : base(name) // the player is giving the character class the name that it requires
        {
            
        }
    }
}
