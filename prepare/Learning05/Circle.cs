public class Circle : Shape
{
    private double _Radius;

    public Circle(string color, double radius) : base(color)
    {
        _Radius = radius;
    }

    public override double GetArea()
    {
        return System.Math.PI * _Radius * _Radius;
    }
}