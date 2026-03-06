public class Square : Shape
{
    private double _SideLength;

    public Square(string color, double sideLength) : base(color)
    {
        _SideLength = sideLength;
    }

    public override double GetArea()
    {
        return _SideLength * _SideLength;
    }
    
}