//полиморфизм
//вариант 12


using System.Xml.Linq;

Console.Write("Введите название алмаза: ");
string name = Console.ReadLine()!;
Console.Write("Введите вес: ");
double ves = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите качество огранки: ");
int cut = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите цвет: ");
string color = Console.ReadLine()!;


class Dimond
{
    private string? name;
    private double ves;
    private int cut;

    public Dimond(string? _name, double _ves, int _cut)
    {
        this.name = _name;
        this.ves = _ves;
        this.cut = _cut;
    }

    public string Name { get => name!; set => name = value; }
    public double Ves { get => ves; set { if (value > 0) ves = value; } }
    public int Cut { get => cut; set { if (value > 0) cut = value; } }

    public virtual double Q()
    {
        return 0.4 * ves + 0.6 * cut;
    }
}

class PDimond : Dimond
{
    private string? color;

    public PDimond(string _color,string? _name, double _ves, int _cut) : base(_name, _ves, _cut)
    {
        color = _color;
    }
    public string Color { get => color!; set => color = value; }

    public override double Q()
    {
        if (color == "blue") return base.Q()+1;
        else if (color == "yellow")return base.Q()-0.5;
        return base.Q();
    }
}