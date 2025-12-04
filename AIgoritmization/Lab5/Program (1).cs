//символьный тип данных. высокий. вариант 3

Console.WriteLine("Введите 23 символа:");
string s = Console.ReadLine();
s = s.Replace(" ", "");
bool pal = true;
for (int i = 0; i < s.Length / 2; i++)
{
    if (s[i] != s[s.Length - 1 - i])
    {
        pal = false;
        break;
    }
}
if (pal)
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");

//строковый тип данных. средний. вариант 3

Console.WriteLine("Введите строку:");
string v = Console.ReadLine();
string result = "";
foreach (char c in v)
{
    if (char.IsLetter(c) && c >= 'А' && c <= 'я')
        result += "*";
    else
        result += c;
}
Console.WriteLine(result);
