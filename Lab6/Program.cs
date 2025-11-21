//функции
//вариант 9
//высокий уровень
Console.WriteLine("Введите 5 строк: ");
for (int i = 0; i < 5; i++)
{
    string s = Console.ReadLine();
    bool a = Simm(s);
    Simmetry(a);
}


bool Simm(string s)
{
    if(s.Length <= 1) return true;
    if (s[0] == s[s.Length - 1]) return Simm (s.Substring(1, s.Length-2));
    return false;
}

void Simmetry(bool sim)
{
    if (sim) Console.WriteLine("Симметричная строка");
    else Console.WriteLine("Несимметричная строка");
}