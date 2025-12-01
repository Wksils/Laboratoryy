//Работа с датой и временем.
//вариант 13
//средний уровень

Console.Write("Введиете колличество каналов: ");
int n = int.Parse(Console.ReadLine()!);
TelevisionStudio[] televisionStudio = new TelevisionStudio[n];
TimeOnly preventionTime;
TimeOnly nightStart = new TimeOnly(22, 00);
TimeOnly nightEnd = new TimeOnly(6, 00);
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Заполните данные {i +1} канала");
    Console.Write("Введите название канала: ");
    televisionStudio[i].programName = Console.ReadLine()!;
    Console.Write("Введиете Планируемую дату проведения профилактики (год месяц число): ");
    televisionStudio[i].preventionDate = DateOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите время начала профилактических работ: ");
    televisionStudio[i].preventionTimeStart = TimeOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите время конца профилактических работ: ");
    televisionStudio[i].preventionTimeEnd = TimeOnly.Parse(Console.ReadLine()!);
}

foreach (TelevisionStudio item in televisionStudio)
{
    TimeSpan timeSpan = item.preventionTimeEnd - item.preventionTimeStart;
    Console.WriteLine($"{item.programName} : длительность профилактических работ {timeSpan.TotalMinutes}");
}
foreach (TelevisionStudio item in televisionStudio)
{

    if (item.preventionTimeStart >= nightStart || item.preventionTimeStart <= nightEnd) { Console.WriteLine(item.ToString()); }
}
struct TelevisionStudio
{
    public string programName;
    public DateOnly preventionDate;
    public TimeOnly preventionTimeStart;
    public TimeOnly preventionTimeEnd;

    public override string? ToString() => $"{programName}: дата профилактики {preventionDate}, начало профилактики {preventionTimeStart}, коннец профилактики {preventionTimeEnd}";
}