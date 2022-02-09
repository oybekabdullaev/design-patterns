using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.Builder;

public class CountingMazeBuilder : MazeBuilder
{
    private Maze _maze;
    private int _rooms = 0;
    private int _doors = 0;

    public override void BuildMaze()
    {
        _maze = new Maze();
    }

    public override void BuildRoom(int roomNumber)
    {
        _rooms++;
    }

    public override void BuildDoor(int roomFromId, int roomToId)
    {
        _doors++;
    }

    public override Maze GetMaze()
    {
        return _maze;
    }

    public (int, int) GetCounts()
    {
        return (_rooms, _doors);
    }
}