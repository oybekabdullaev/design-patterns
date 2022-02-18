namespace DesignPatterns.Structural.Decorator;

public class ScrollDecorator : Decorator
{
    public ScrollDecorator(IVisualComponent component) : base(component)
    {
        
    }

    public override void Draw()
    {
        base.Draw();
    }

    public override void Resize()
    {
        base.Resize();
    }
}