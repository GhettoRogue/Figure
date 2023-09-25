namespace Figure.app;

public class Circle : Figure
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalcArea()
    {
        return Math.PI * radius * radius;
    }
}