namespace Figure.app;

public class Circle : Figure
{
    private double Radius {get; init;}

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalcArea() => Math.PI * Radius * Radius;
    
}

