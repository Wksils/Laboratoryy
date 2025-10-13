//Операторы цикла с предусловием и постусловием
//вариант 9
//высокий уровень
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
Console.WriteLine("введите предел");
int k = int.Parse(Console.ReadLine());
while(k == 0 || double.IsInfinity(k))
{
    Console.WriteLine("некорректное значение: ");
    Console.WriteLine("введите предел: ");
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