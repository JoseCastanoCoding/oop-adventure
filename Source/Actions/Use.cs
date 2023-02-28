

namespace oop_adventure;

public class Use : Action
{
    private readonly House _house; // this is the field!
    
    public Use(House house) // constructor, so that we can save a reference to the house that gets passed in when we make a new instance of the use class.
    {
        _house = house;
    }

    public override string Name => Text.Language.Use;

    public override void Execute(string[] args)
    {
        if(args.Length < 1)
        {
            Console.WriteLine(Text.Language.UseError);

            return;
        }

        var itemName = args[1];

        if(_house.Player.Contains(itemName))
        {
            var item = _house.Player.Take(itemName);

            Console.WriteLine(Text.Language.UseSuccess, item.Name);

            item.Use(itemName);
        }
        else
        {
            Console.WriteLine(Text.Language.UseError);
        }

    }
}

