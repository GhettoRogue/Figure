namespace Figure.app;

public class Rectangle : Figure
{
    private readonly double length;
    private readonly double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalcArea()
    {
        return length * width;
    }
}