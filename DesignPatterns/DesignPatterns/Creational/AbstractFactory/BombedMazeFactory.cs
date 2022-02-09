using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.AbstractFactory;

public class BombedMazeFactory : MazeFactory
{
    public override Room MakeRoom(int roomNumber)
    {
        return new RoomWithABomb(roomNumber);
    }

    public override Wall MakeWall()
    {
        return new BombedWall();
    }
}

public class RoomWithABomb : Room
{
    public RoomWithABomb(int roomNumber) : base(roomNumber) { }
}

public class BombedWall : Wall { }