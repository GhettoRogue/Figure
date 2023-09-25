namespace Figure.app;

public class Triangle : Figure
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double CalcArea()
    {
        var perimeter = a + b + c;
        var halfPerimeter = perimeter / 2;
        var square = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return square;
    }
}