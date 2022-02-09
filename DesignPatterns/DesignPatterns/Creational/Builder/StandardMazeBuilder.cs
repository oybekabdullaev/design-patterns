using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.Builder;

public class StandardMazeBuilder : MazeBuilder
{
    private Maze _maze;

    public override void BuildMaze()
    {
        _maze = new Maze();
    }

    public override void BuildRoom(int roomNumber)
    {
        var room = new Room(roomNumber);
        room.SetSide(Direction.North, new Wall());
        room.SetSide(Direction.West, new Wall());
        room.SetSide(Direction.East, new Wall());
        room.SetSide(Direction.South, new Wall());
        
        _maze.AddRoom(new Room(roomNumber));
    }

    public override void BuildDoor(int roomFromId, int roomToId)
    {
        var roomFrom = _maze.GetRoom(roomFromId);
        var roomTo = _maze.GetRoom(roomToId);
        var door = new Door(roomFrom, roomTo);

        roomFrom.SetSide(CommonWall(roomFrom, roomTo), door);
        roomTo.SetSide(CommonWall(roomTo, roomFrom), door);
    }

    public override Maze GetMaze()
    {
        return _maze;
    }

    private static Direction CommonWall(Room roomFrom, Room roomTo)
    {
        throw new NotImplementedException();
    }
}