namespace DesignPatterns.Structural.Decorator;

public static class Window
{
    public static void Create()
    {
        var borderedTextView = new BorderDecorator(new TextView(), 10);
        var scrolledTextView = new ScrollDecorator(new TextView());
        var scrolledBorderedTextView = new BorderDecorator(new ScrollDecorator(new TextView()), 15);
    }
}