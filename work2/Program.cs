using ClassLibraryWork;


Console.WriteLine("Треугольник:");
Triangle triangle = new Triangle(4, 2, 5);
Console.WriteLine($"Площадь треугольника: {triangle.GetSquare()}");
Console.WriteLine($"Является прямоугольным треугольноком? {triangle.IsTriangleRectangular()}");

Console.WriteLine();

Console.WriteLine("Круг:");
Circle circle = new Circle(6);
Console.WriteLine($"Площадь треугольника: {circle.GetSquare()}");