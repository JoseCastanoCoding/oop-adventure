using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Text
{
    public class English : Language
    {
        public English() 
        {
            ChooseYourName = "Hello, what is your name?";   
            DefaultName = "No Name";
            Welcome = "Welcome {0} to your OOP Adventure";
            DefaultRoomName = "Room {0} ({1}, {2})";
            DefaultRoomDescription = "You are in a room with doors to the {0}.";
        }

    }
}
