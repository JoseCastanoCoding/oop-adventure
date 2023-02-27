using oop_adventure.Source.Characters;

namespace oop_adventure;

public partial class House
{
    public Player Player { get; }
    
    private readonly Random _rnd = new(1234); // the seed (review) - can't be changed at runtime 
    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; private set; }

    public House(Player player)
    {
        Player = player;
    }

}
