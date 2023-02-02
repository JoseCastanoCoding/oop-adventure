﻿using oop_adventure.Source.Text;

namespace oop_adventure.Source.Map;

public partial class House
{
    public Room CurrentRoom { get; set; }
    public void GoToRoom(int index)
    {
        if (CurrentRoom != null)
            CurrentRoom.Visited = true;

        CurrentRoom = Rooms[index];

    }
    public void GoToStartingRoom() 
    {
        GoToRoom(_rnd.Next(0, Rooms.Length));
    }
}
