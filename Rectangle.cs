namespace Figure.app;

public class Rectangle : Figure
{
    public double Length { get; init; }
    public double Width { get; init; }


    public override double CalcArea() => Length * Width;
}