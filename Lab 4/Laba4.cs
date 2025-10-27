//массивы

//одномерные массивы
//вариант 15
//высокий уровень
Random rnd = new Random();
int a = rnd.Next(1, 10);

int[] numbers = new int[a];
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(100);
    sum += numbers[i];
}
double av = sum / numbers.Length;
Console.WriteLine($"среднее значение чисел: {av}");
Array.Sort(numbers);
string[] dv = new string[numbers.Length];
for(int i = 0;i < numbers.Length; i++)
{
    dv[i] = Convert.ToString(numbers[i], 2);
}
Console.WriteLine();
Console.WriteLine("Содержимое массива в двоичной сс:");
foreach(string i in dv)
{
    Console.Write(i + " ");
}
Console.WriteLine();


//двумерные массивы

//высокий уровень
//вариант 28
Console.WriteLine();
Console.WriteLine("введите количество строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] mas = new int[n, m];


//генерация массива
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = rnd.Next(5);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
int[] sr = new int[n];
Console.WriteLine();
//mas[j,i]
//генерация массива - столбца с которым будем сравнивать
for (int i =0; i < n; i++)
{
    sr[i] = mas[i, m - 1];
    Console.Write(sr[i] + " ");
}
//поиск похожих столбцов
Console.WriteLine();
int same = 0;
for (int i = 0; i < m; i++)
{
    int counter = 0;
    for (int j = 0; j < n; j++)
    {
        if (mas[j , i] == sr[j]) counter++;
    }
    if (counter == m) same++;
}
Console.WriteLine($"колличесто совпадающих столбцов: {same}");
