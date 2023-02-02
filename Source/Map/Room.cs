using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_adventure.Source.Map;

namespace oop_adventure.Source.Text
{
    public class Room
    {
        public string Name { get; set; } = Text.Language.DefaultRoomName;
        public string Description { get; set; } = Text.Language.DefaultRoomDescription;
        public Dictionary<DirectionsEnum, int> Neighbors { get; set; } = new()
        {
            {DirectionsEnum.North, -1 },
            {DirectionsEnum.East, -1 },
            {DirectionsEnum.South, -1 },
            {DirectionsEnum.West, -1 },
            {DirectionsEnum.None, -1 },
        };
        public bool Visited { get; set; }
    }
}