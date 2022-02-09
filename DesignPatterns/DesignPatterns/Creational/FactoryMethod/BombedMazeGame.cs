using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.FactoryMethod;

public class BombedMazeGame : MazeGame
{
    protected override Room MakeRoom(int roomNumber)
    {
        return new RoomWithABomb(roomNumber);
    }

    protected override Wall MakeWall()
    {
        return new BombedWall();
    }
}

public class RoomWithABomb : Room
{
    public RoomWithABomb(int roomNumber) : base(roomNumber) { }
}

public class BombedWall : Wall { }