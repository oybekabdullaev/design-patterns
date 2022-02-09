namespace DesignPatterns.Creational.Models;

public class Maze
{
    private readonly Dictionary<int, Room> _rooms = new();

    public void AddRoom(Room room)
    {
        _rooms[room.RoomNumber] = room;
    }

    public Room GetRoom(int roomNumber)
    {
        return _rooms[roomNumber];
    }
}