using DesignPatterns.Creational.Models;

namespace DesignPatterns.Creational.Builder;

public abstract class MazeBuilder
{
    public abstract void BuildMaze();
    public abstract void BuildRoom(int roomNumber);
    public abstract void BuildDoor(int roomFromId, int roomToId);
    public abstract Maze GetMaze();
}