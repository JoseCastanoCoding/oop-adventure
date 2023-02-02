using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Characters
{
    public abstract class Character // this is not a class that can be instantiated - because of the abstract keyword
    {
        public string Name { get; set; } // public property 
        public Character(string name) // constructor - this is what is called when the class is created 
        {
            Name = name; // assign the property to the same argument that's been passed in the constructor
        }
    }
}
