//Операторы цикла с предусловием и постусловием
//вариант 9
//высокий уровень
using System.Runtime.Serialization.Formatters;
Console.WriteLine("ЗАДАНИЕ 3.1");
Console.WriteLine("Введите последовательность чисел. 0 - завершение последовательности");
double a = 1;
do
{
    double y = int.Parse(Console.ReadLine());
    if (y == 0) break;
    a *= y;
}
while (true);
Console.WriteLine($"Произведение чисел : {a}");

//Оператор цикла for
//вариант 9
//средний уровень
Console.WriteLine("ЗАДАНИЕ 3.2");
Console.WriteLine("введите предел");
int k = int.Parse(Console.ReadLine());
while (k == 0)
{
    Console.WriteLine("некорректное значение");
    Console.Write("введите предел: ");
    k = int.Parse(Console.ReadLine());
}
double W = 0;
long F = 1;
for (int i = 1; i < k; i++)
{
    for (int j = 1; j <= i; j++)
    {
        F *= j;
    }
    W += (double)(Math.Pow(-1, i) * (i - 3) * (i - 3) / F);
}
Console.WriteLine($"W = {W:f2}");

//вычисление бесконечных сумм
//вариант 9
Console.WriteLine("ЗАДАНИЕ 3.3");
Console.WriteLine("введите n :");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите X :");
int x = int.Parse(Console.ReadLine());
double Sum = 0;
long Ff = 1;
for (int i = 1; i <= n; i += 4)
{
    for (int j = 1; j <= i; j++)
    {
        Ff *= j;
    }
    Sum += (Math.Pow(x, i) / Ff);
}
Console.WriteLine($"Сумма = {Sum:f2}");

//табулирование фкнкций 
//вариант 9
//высокий уровень
Console.WriteLine("ЗАДАНИЕ 3.4");
long F1 = 1;
double f = 0;
int k1 = 1;
Console.WriteLine("-----------------------------");
Console.WriteLine("|     x       |       y     |");
Console.WriteLine("-----------------------------");
for (double x1 = 0.5; x1 <= 2; x1 += 0.15)
{
    for (int j = 1; j <= k1; j++)
    {
        F1 *= j;
    }
    f += (Math.Pow(-3, k1) * Math.Pow(x1, k1) / F1);
    Console.WriteLine($"|{x1,9:f2} {" ", -3}|{f,12:f6}{" "}|");
    k1++;
}
Console.WriteLine("-----------------------------");
