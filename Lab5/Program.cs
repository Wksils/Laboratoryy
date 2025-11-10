//символьный тип данных
//вариант 8 
//высокий уровень

Console.WriteLine("Введите первые символы");
string s = Console.ReadLine();
char[] str1 = s.ToCharArray();
Console.WriteLine("введите вторые символы");
string s2 = Console.ReadLine();
char[] str2 = s2.ToCharArray();

int cnt = 0;
if (s.Length != s2.Length)
{
    Console.WriteLine("Не аннаграмма");
}
else
{
    for (int i = 0; i < str1.Length; i++)
    {
        for (int j = 0; j < str2.Length; j++)
        {
            if (str1[i] == str2[j]) { cnt++; break; }
        }
    }
    Console.WriteLine(cnt == str1.Length ? "Аннаграмма":"Не аннаграмма");
}


//строковый тип данных
//вариант 8 
//высокий уровень

Console.WriteLine();
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
string[] mas = str.Split(' ');
Array.Reverse(mas);
string newStr = String.Join(' ', mas);
Console.WriteLine(newStr);



















