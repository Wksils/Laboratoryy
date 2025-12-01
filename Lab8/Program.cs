//перечисления и структуры
//вариант 9
//средний уровень
Console.WriteLine("Введите колличество машин: ");
int quantity = int.Parse(Console.ReadLine()!);
Car[] car = new Car[quantity];
for (int i = 0; i < quantity; i++)
{
    Console.Write("Введите марку автомобиля: ");
    car[i].mark = Console.ReadLine()!;
    Console.Write("Ведите производителя: ");
    car[i].manufacturer = Console.ReadLine()!;
    Console.Write("Введите тип автомобиля: ");
    car[i].type = Console.ReadLine()!;
    Console.Write("Введите год выпуска автомобиля: ");
    car[i].year = new DateTime(int.Parse(Console.ReadLine()!),1,1);
    Console.Write("Введите дату регистрации автомобиля: ");
    car[i].registration = DateTime.Parse(Console.ReadLine()!);
    Console.WriteLine();
}
foreach (Car i in car)
{
    if (i.mark == "Ford" && i.year.Year < 2000)
    {
        Console.WriteLine(i.ToString());
    }
}
struct Car
{
    public string mark;
    public string manufacturer;
    public string type;
    public DateTime year;
    public DateTime registration;

    public override string? ToString() => $"Mark:{mark}, Manufacturer:{manufacturer}, Type:{type}, Year:{year.Year}, Date:{registration:d}";
}