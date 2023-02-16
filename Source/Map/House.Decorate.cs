namespace oop_adventure;

public partial class House
{
    public void DecorateRooms()
    {
        foreach (var room in Rooms)
        {
            var roomDescription = Text.Language.RoomDescriptions[0];

            if(Text.Language.RoomDescriptions.Count > 1 && _rnd.Next(0, 2) == 1)
            {
                roomDescription = Text.Language.RoomDescriptions[_rnd.Next(1, Text.Language.RoomDescriptions.Count)];

                Text.Language.RoomDescriptions.Remove(roomDescription);
            }
                
            room.Description = string.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}");
                

        }
    }
}