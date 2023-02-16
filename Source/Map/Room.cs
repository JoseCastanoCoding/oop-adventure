using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop_adventure;

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

    public override string ToString()
    {
        var sb = new StringBuilder();

        if(Visited)
            sb.Append(string.Format(Text.Language.RoomOld, Name));
        else
            sb.Append(string.Format(Text.Language.RoomNew, Name));

        var names = Enum.GetNames(typeof(DirectionsEnum));

        var directions = (from p in names where Neighbors[(DirectionsEnum)Enum.Parse(typeof(DirectionsEnum), p)] > -1 select p.ToLower()).ToArray();

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

        sb.Append(description);

        return sb.ToString();
    }

}