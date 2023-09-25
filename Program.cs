using Figure.app;

var figure1 = new Circle { Radius = 20.5 };
Console.WriteLine(figure1.CalcArea());

var figure2 = new Triangle { A = 5, B = 6, C = 7 };
Console.WriteLine(figure2.CalcArea());

var figure3 = new Rectangle { Length = 10.5, Width = 10.5 };
Console.WriteLine(figure3.CalcArea());