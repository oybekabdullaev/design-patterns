using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.AbstractFactory;

public static class MazeGame
{
    public static Maze CreateGame(MazeFactory factory)
    {
        var maze = factory.MakeMaze();
        var room1 = factory.MakeRoom(1);
        var room2 = factory.MakeRoom(2);
        var door = factory.MakeDoor(room1, room2);

        maze.AddRoom(room1);
        maze.AddRoom(room2);

        room1.SetSide(Direction.North, factory.MakeWall());
        room1.SetSide(Direction.East, door);
        room1.SetSide(Direction.South, factory.MakeWall());
        room1.SetSide(Direction.West, factory.MakeWall());

        room2.SetSide(Direction.North, factory.MakeWall());
        room2.SetSide(Direction.East, factory.MakeWall());
        room2.SetSide(Direction.South, factory.MakeWall());
        room2.SetSide(Direction.West, door);

        return maze;
    }
}