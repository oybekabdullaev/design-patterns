namespace DesignPatterns.Structural.Decorator;

public abstract class Decorator : IVisualComponent
{
    private readonly IVisualComponent _component;

    protected Decorator(IVisualComponent component)
    {
        _component = component;
    }

    public virtual void Draw()
    {
        _component.Draw();
    }

    public virtual void Resize()
    {
        _component.Resize();
    }
}