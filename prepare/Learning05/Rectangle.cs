public class Rectangle : Shape
{
    private int _Width;
    private int _Height;

    public Rectangle(string color, int width, int height) : base(color)
    {
        _Width = width;
        _Height = height;
    }

    public override double GetArea()
    {
        return _Width * _Height;
    }
}