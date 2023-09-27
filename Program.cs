using System.Globalization;
using Figure.app;
using ConsoleLibrary;

/*var circle = new Circle { Radius = 20.5 };
Console.WriteLine(circle.CalcArea());

var triangle = new Triangle { A = 5, B = 6, C = 7 };
Console.WriteLine(triangle.CalcArea());

var rectangle = new Rectangle { Length = 10.5, Width = 10.5 };
Console.WriteLine(rectangle.CalcArea());*/

var circle = new Circle(10);
ConsoleHelper.PrintSuccess($"Площадь круга: {Geometry.GetArea(circle).ToString(CultureInfo.InvariantCulture)}");

// ConsoleHelper.PrintSuccess(Geometry.GetArea(circle).ToString(CultureInfo.InvariantCulture));

var triangle = new Triangle (5,6,7);
ConsoleHelper.PrintSuccess(Geometry.GetArea(triangle).ToString(CultureInfo.InvariantCulture));

var rectangle = new Rectangle(10, 10);
ConsoleHelper.PrintSuccess(Geometry.GetArea(rectangle).ToString(CultureInfo.InvariantCulture));

