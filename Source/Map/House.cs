using oop_adventure.Source.Characters;
using oop_adventure.Source.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Map
{
    public partial class House
    {
        public Player Player { get; }
        
        private readonly Random _rnd = new(1234); // the seed (review)
        public int Width { get; set; }
        public int Height { get; set; }
        public Room[] Rooms { get; private set; }

        public House(Player player)
        {
            Player = player;
        }

    }
}
