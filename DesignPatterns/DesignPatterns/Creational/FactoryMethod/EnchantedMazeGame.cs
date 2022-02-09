using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.FactoryMethod;

public class EnchantedMazeGame : MazeGame
{
    protected override Room MakeRoom(int roomNumber)
    {
        return new EnchantedRoom(roomNumber, new Spell());
    }

    protected override Door MakeDoor(Room room1, Room room2)
    {
        return new DoorNeedingSpell(room1, room2);
    }
}

public class EnchantedRoom : Room
{
    private readonly Spell _spell;

    public EnchantedRoom(int roomNumber, Spell spell) : base(roomNumber)
    {
        _spell = spell;
    }
}

public class DoorNeedingSpell : Door
{
    public DoorNeedingSpell(Room room1, Room room2) : base(room1, room2) { }
}

public class Spell { }