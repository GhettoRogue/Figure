namespace Figure.app;

public class Circle : Figure
{
    public double Radius {get; init;}
    
    public override double CalcArea() => Math.PI * Radius * Radius;
    
}