namespace Figure.app;

public abstract class Circle : Figure
{
    private readonly double radius;

    protected Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalcArea()
    {
        return Math.PI * radius * radius;
    }
}