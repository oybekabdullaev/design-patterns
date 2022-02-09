namespace DesignPatterns.Creational.Models;

public class Door : IMapSite
{
    private readonly Room _room1;
    private readonly Room _room2;

    public Door(Room room1, Room room2)
    {
        _room1 = room1;
        _room2 = room2;
    }

    public Room OtherSideFrom(Room room)
    {
        return room == _room1 ? _room2 : _room1;
    }

    public virtual void Enter()
    {
        throw new NotImplementedException();
    }
}