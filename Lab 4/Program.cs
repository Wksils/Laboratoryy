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



