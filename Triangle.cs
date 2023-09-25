namespace Figure.app;

public class Triangle : Figure
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }

    public override double CalcArea()
    {
        var perimeter = A + B + C;
        var halfPerimeter = perimeter / 2;
        var square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        return square;
    }
}