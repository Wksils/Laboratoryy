//массивы

//одномерные массивы
//вариант 15
//высокий уровень
Console.Write("задайте размерность массива: ");
int a = 0;
do
{
    a = int.Parse(Console.ReadLine());
}
while (a == 0);

int[] numbers = new int[a];
int sum = 0;
Console.WriteLine("Введите элементы массива в двоичной сс: ");
for(int i = 0; i < numbers.Length; i++)
{
    string s = Console.ReadLine();
    numbers[i] = Convert.ToInt32(s, 2);
    sum += numbers[i];
}
double av = sum / numbers.Length;
Console.WriteLine($"среднее значение чисел: {av}");
Array.Sort(numbers);
foreach(int i in numbers)
{
    Console.Write(i + " ");
}


