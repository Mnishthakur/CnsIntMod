namespace interface
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

// Implementing the interface
class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
    }
}
