namespace Figure.app;

public class Triangle : Figure
{
    private double A { get; init; }
    private double B { get; init; }
    private double C { get; init; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double CalcArea()
    {
        var perimeter = A + B + C;
        var halfPerimeter = perimeter / 2;
        var square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        
        return square;
    }
}