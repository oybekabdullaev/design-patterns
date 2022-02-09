using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.FactoryMethod;

public class MazeGame
{
    public static Maze CreateMaze()
    {
        var maze = new Maze();
        var room1 = new Room(1);
        var room2 = new Room(2);
        var door = new Door(room1, room2);

        maze.AddRoom(room1);
        maze.AddRoom(room2);

        room1.SetSide(Direction.North, new Wall());
        room1.SetSide(Direction.East, door);
        room1.SetSide(Direction.South, new Wall());
        room1.SetSide(Direction.West, new Wall());

        room2.SetSide(Direction.North, new Wall());
        room2.SetSide(Direction.East, new Wall());
        room2.SetSide(Direction.South, new Wall());
        room2.SetSide(Direction.West, door);

        return maze;
    }

    protected virtual Maze MakeMaze()
    {
        return new Maze();
    }

    protected virtual Room MakeRoom(int roomNumber)
    {
        return new Room(roomNumber);
    }

    protected virtual Door MakeDoor(Room room1, Room room2)
    {
        return new Door(room1, room2);
    }

    protected virtual Wall MakeWall()
    {
        return new Wall();
    }
}