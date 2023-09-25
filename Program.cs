using Figure.app;

/*var circle = new Circle { Radius = 20.5 };
Console.WriteLine(circle.CalcArea());

var triangle = new Triangle { A = 5, B = 6, C = 7 };
Console.WriteLine(triangle.CalcArea());

var rectangle = new Rectangle { Length = 10.5, Width = 10.5 };
Console.WriteLine(rectangle.CalcArea());*/

var circle = new Circle(10);
Console.WriteLine(Geometry.GetArea(circle));

var triangle = new Triangle (5,6,7);
Console.WriteLine(Geometry.GetArea(triangle));

var rectangle = new Rectangle(10, 10);
Console.WriteLine(Geometry.GetArea(rectangle));

