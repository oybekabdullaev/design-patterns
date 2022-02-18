namespace DesignPatterns.Structural.Decorator;

public class BorderDecorator : Decorator
{
    private readonly int _borderWidth;

    public BorderDecorator(IVisualComponent component, int borderWidth) : base(component)
    {
        _borderWidth = borderWidth;
    }

    public override void Draw()
    {
        base.Draw();
        DrawBorder(_borderWidth);
    }

    public override void Resize()
    {
        base.Resize();
    }

    private void DrawBorder(int width)
    {
        throw new NotImplementedException();
    }
}