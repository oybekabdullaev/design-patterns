using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.AbstractFactory;

public class MazeFactory
{
    public virtual Maze MakeMaze()
    {
        return new Maze();
    }

    public virtual Room MakeRoom(int roomNumber)
    {
        return new Room(roomNumber);
    }

    public virtual Door MakeDoor(Room room1, Room room2)
    {
        return new Door(room1, room2);
    }

    public virtual Wall MakeWall()
    {
        return new Wall();
    }
}