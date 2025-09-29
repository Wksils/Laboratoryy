//лабораторная работа 1

//арифметические выражения
//вариант 5
//высокий уровень
Console.WriteLine("Enter x: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Enter z: ");
double z = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine("Enter c: ");
double c = double.Parse(Console.ReadLine());

double tan = Math.Tan((Math.Pow(x, 4) - 6) * Math.PI / 180);
double cos1 = Math.Pow(Math.Cos((z + x * y) * Math.PI / 180), 3);
double cos2 = Math.Pow(Math.Cos((Math.Pow(x, 3) * (c * c)) * Math.PI / 180), 4);

Console.WriteLine($"G = {(tan - cos1) / cos2:f2}");


//линейные алгоритмы
//вариант 5
//высокий уровень
Console.WriteLine();
Console.WriteLine("Enter a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter s: ");
double s = double.Parse(Console.ReadLine());
double d = b * b - 4 * a * s;

Console.WriteLine($"D = {d}");

Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / 2 * a:f2}");
Console.WriteLine($"x2 = {(-b - Math.Sqrt(d)) / 2 * a:f2}");

//целочисленная арифметика
//вариант 3.27

Console.WriteLine("введите четырёхзначное число: ");
int four = int.Parse(Console.ReadLine());
int f1 = four / 1000;
int f2 = four / 100 % 10;
int f3 = four % 100 / 10;
int f4 = four % 10;
Console.WriteLine($"Сумма цифр четырёхзначного числа: {f1 + f2 + f3 + f4}");
Console.WriteLine("Введите пятизначное число: ");
int five = int.Parse(Console.ReadLine());
int fi1 = five / 10000;
int fi2 = five / 1000 % 10;
int fi3 = five % 1000 / 100;
int fi4 = five % 100 / 10;
int fi5 = five % 10;
Console.WriteLine($"Сумма цифр пятизначного числа: {fi1 + fi2 + fi3 + fi4 + fi5}");





