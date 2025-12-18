//классы
//вариант 8
//средний уовень

using System.Runtime.CompilerServices;

Console.WriteLine("Введите x1:");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2:");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1:");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2:");
double y2 = double.Parse(Console.ReadLine()!);
Rectangle rectangle = new Rectangle(x1, y1, x2, y2);
Console.WriteLine($"{rectangle.Diagonal():f2}");
Console.WriteLine("Введите радиус окружности:");
Circle circle = new Circle(double.Parse(Console.ReadLine()!), rectangle);
Console.WriteLine($"{circle.AreaCircleRect():f2}");

public class Rectangle
{
    protected double x1;
    protected double y1;
    protected double x2;
    protected double y2;


    public double X1 { get => x1; set => x1 = value; }
    public double Y1 { get => y1; set => y1 = value; }
    public double X2 { get => x2; set => x2 = value; }
    public double Y2 { get => y2; set => y2 = value; }


    public Rectangle(double _x1, double _y1, double _x2, double _y2)
    {
        this.x1 = _x1;
        this.y1 = _y1;
        this.x2 = _x2;
        this.y2 = _y2;
    }
    public Rectangle()
    {
        this.x1 = 1;
        this.y1 = 1;
        this.x2 = 1;
        this.y2 = 1;
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
    }
    
}

//наследование
//средний уровень

public class Circle : Rectangle
{
    private double r;
    private Rectangle rect;
    public Circle(double _r, Rectangle _rect)
    {
        if (_r < Math.Abs(rect.X2 - rect.X1) / 2 && _r < Math.Abs(rect.Y2 - rect.Y1) / 2) this.r = _r;
        this.rect = _rect;
    }
    public double R 
    {
        get => r;
        set { if (value < Math.Abs(rect.X2 - rect.X1)/2 && value < Math.Abs(rect.Y2 - rect.Y1)/2) r = value; }
    }
    public double AreaCircleRect()
    {
        double CircleArea = Math.PI * r * r;
        Console.WriteLine(CircleArea);
        double RectangleArea = Math.Abs(rect.X2 - rect.X1) * Math.Abs(rect.Y2 - rect.Y1);
        Console.WriteLine(RectangleArea);
        return RectangleArea - CircleArea;
    }
}