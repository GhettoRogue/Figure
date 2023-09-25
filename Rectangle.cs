namespace Figure.app;

public class Rectangle : Figure
{
    private double Length { get; init; }
    private double Width { get; init; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalcArea() => Length * Width;
}