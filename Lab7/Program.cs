using Library1;

//библиотеки
//вариант 9
//средний уровень

Console.WriteLine("матрица");
double[,] mas = new double[7, 7];
double number;
for (int i = 0; i < 7; i++)
{
    for(int j = 0; j < 7; j++)
    {
        if (j == 0) 
        { 
            Console.Write($"{mas[i, j]} "); 
            continue; 
        }
        number = Math.Pow(Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(j), 2), 3) - Math.Pow(-3, i + j) * Math.Log10(Math.Pow(Math.E, (i + 5) / j));
        mas[i, j] = number;
        Console.Write($"{mas[i, j]:F2} ");
    }
    Console.WriteLine();
}
double[] vector = Library1.Lib.Vector(mas);
foreach (double x in vector)
{
    Console.Write($"{x:F2} ");
}
Console.WriteLine();
double g = Library1.Lib.G(vector);
Console.WriteLine($"g: {g:F2}");