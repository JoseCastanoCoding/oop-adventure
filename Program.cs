using oop_adventure;
using oop_adventure.Source;
using oop_adventure.Source.Characters;
using oop_adventure.Source.Map;
using oop_adventure.Source.Text;

Text.loadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name); // adding the player to our game! Create an instance of the player class that accepts the name

Console.WriteLine(Text.Language.Welcome, player.Name); // replacing name with player.Name (Name is the public property)

var house = new House(player);

Actions.Instance.Register(new Go(house));
