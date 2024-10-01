// See https://aka.ms/new-console-template for more information
using TestLib;
using TestLib.ili_tak;

Console.WriteLine("Hello, World!");

AreaCounter areaCounter = new AreaCounter();

Triangle triangle = new Triangle() { a = 4, b = 5, c = 5 };
Circle circle = new Circle() { r = 10 };

Console.WriteLine(  "Triangle: ");
Console.WriteLine(  triangle.GetCount());

Console.WriteLine( "Circle: ");
Console.WriteLine(  circle.GetCount());


Console.WriteLine("______________________________________________");


areaCounter.GetAreaCount(triangle);
Console.WriteLine();
areaCounter.GetAreaCount(circle);

