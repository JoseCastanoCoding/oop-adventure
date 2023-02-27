
namespace oop_adventure;

public class Key : Item
{
    private readonly House _house; // a private field to store a reference to the house
    public Key(House house)
    {
        _house = house;

        CanTake = true;
        SingleUse = true;
    }

    public override string Name { get; set; } = Text.Language.Key;

    public override void Use(string source)
    {
        _house.CurrentRoom.Use(Text.Language.Chest, Name);
    }

}

