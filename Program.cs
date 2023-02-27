using oop_adventure;
using oop_adventure.Source.Characters;

Text.loadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name); // adding the player to our game! Create an instance of the player class that accepts the name

Console.WriteLine(Text.Language.Welcome, player.Name); // replacing name with player.Name (Name is the public property)

var house = new House(player);
house.CreateRooms(3, 3);
house.DecorateRooms();

Actions.Instance.Register(new Go(house));
Actions.Instance.Register(new Backpack(player));

house.GoToStartingRoom();

var run = true;

Room lastRoom = null;

while(run)
{
    if(lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }

    Console.WriteLine(Text.Language.WhatToDo);

    var input = Console.ReadLine().ToLower();

    if(input == Text.Language.Quit)
        run = false;
    else
        Actions.Instance.Execute(input.Split(" "));
}