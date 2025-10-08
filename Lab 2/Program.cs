//разветвляющиеся алгоритмы


//логические выражения
//вариант 5 
//высокий уровень

using System.Reflection.Metadata;
Console.WriteLine("ЗАДАНИЕ 1");
Console.WriteLine("Введите X: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
double y = double.Parse(Console.ReadLine());
double r = 1;

bool circle = x * x + y * y <= r;
bool side = x * y < 0;
bool area = y + x > 0;

if (circle && side && area) { Console.WriteLine("Принадлежит"); }
else { Console.WriteLine("Не принадлежит"); }

//условные операторы
//вариант 22
//высокий уровень
Console.WriteLine();
Console.WriteLine("ЗАДАНИЕ 2");

Console.Write("введите удельное сопротивление первого проводника: ");
double p1 = double.Parse(Console.ReadLine());
Console.Write("введите площадь сечения первого проводника: ");
double s1 = double.Parse(Console.ReadLine());
Console.WriteLine();
double R1 = p1 / s1;

Console.Write("введите удельное сопротивление второго проводника: ");
double p2 = double.Parse(Console.ReadLine());
Console.Write("введите площадь сечения второго проводника: ");
double s2 = double.Parse(Console.ReadLine());
double R2 = p2 / s2;
Console.WriteLine();

Console.Write("введите удельное сопротивление третьего проводника: ");
double p3 = double.Parse(Console.ReadLine());
Console.Write("введите площадь сечения третьего проводника: ");
double s3 = double.Parse(Console.ReadLine());
double R3 = p3 / s3;
Console.WriteLine();

double max = R1;
int maxName = 1;
if (R2 > max) { max = R2; maxName = 2; }
if (R3 > max) { max = R3; maxName = 3; }
Console.WriteLine($"Проводник с максимальным сопротивлением - {maxName}, его сопротивление = {max:f2}");

//операторы выбора
//вариант 9
//высокая сложность 
Console.WriteLine();
Console.WriteLine("ЗАДАНИЕ 3");

Console.Write("Выберете уровень гостинницы (3/4/5 звезд): ");
int stars = int.Parse(Console.ReadLine());
Console.Write("Выберите колличество комнат (1/2): ");
int rooms = int.Parse(Console.ReadLine());
Console.Write("Нужно ли проживание с питанием? (да/нет)");
string food = Console.ReadLine();
int price = 0;

switch (stars)
{
    case 3:
        switch (rooms)
        {
            case 1:
                switch (food)
                {
                    case "да": price += 500; break;
                    case "нет": price += 300; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            case 2:
                switch (food)
                {
                    case "да": price += 800; break;
                    case "нет": price += 450; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            default: Console.WriteLine("неверно введены параметры"); break;
        }
        break;

    case 4:
        switch (rooms)
        {
            case 1:
                switch (food)
                {
                    case "да": price += 900; break;
                    case "нет": price += 600; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            case 2:
                switch (food)
                {
                    case "да": price += 1500; break;
                    case "нет": price += 900; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            default: Console.WriteLine("неверно введены параметры"); break;
        }
        break;
    case 5:
        switch (rooms)
        {
            case 1:
                switch (food)
                {
                    case "да": price += 1500; break;
                    case "нет": price += 1000; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            case 2:
                switch (food)
                {
                    case "да": price += 2500; break;
                    case "нет": price += 1500; break;
                    default: Console.WriteLine("неверно введены параметры"); break;
                }
                break;
            default: Console.WriteLine("неверно введены параметры"); break;
        }
        break;
    default: Console.WriteLine("неверно введены параметры"); break;
}
Console.WriteLine($"Стоимость проживания : {price}");

//средний уровень
//вариант 9
Console.WriteLine();
Console.WriteLine("ЗАДАНИЕ 3.1");

Console.WriteLine("выберите вариант: ");
Console.WriteLine("1. a=1.2; b=7.2; z=e^x");
Console.WriteLine("2. a=-1.5; b=3.2; z=e^2x");
Console.WriteLine("2. a=1.7; b=5.5; z=e^3");
byte num = byte.Parse(Console.ReadLine());
double a = 0;
double b = 0;
double z = 0;
double result = 0;
Console.WriteLine("Введите x");
double xx = double.Parse(Console.ReadLine());

switch (num)
{
    case 1: a = 1.2; b = 7.2; z = Math.Pow(Math.E, xx); break;
    case 2: a = -1.5; b = 3.2; z = Math.Pow(Math.E, 2 * xx); break;
    case 3: a = 1.7; b = 5.5; z = Math.Pow(Math.E, 3); break;
}
if (xx < Math.Pow(a, 3))
{
    result = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a);
}
if (Math.Pow(a, 3) <= x && x <= b)
{
    result = Math.Pow(a + b * x, 2) - Math.Sin(a + z * x);
}
if (x > b)
{
    result = Math.Sqrt(x - (Math.Sin(b * x + z)));
}
Console.WriteLine($"y = {result}");
