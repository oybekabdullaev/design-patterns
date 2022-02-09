namespace DesignPatterns.Creational.Models;

public class Room : IMapSite
{
    private readonly Dictionary<Direction, IMapSite> _sides = new();

    public Room(int roomNumber)
    {
        RoomNumber = roomNumber;
    }

    public int RoomNumber { get; }

    public void SetSide(Direction direction, IMapSite mapSite)
    {
        _sides[direction] = mapSite;
    }

    public IMapSite GetSide(Direction direction)
    {
        return _sides[direction];
    }

    public virtual void Enter()
    {
        throw new NotImplementedException();
    }
}