//Лабораторная работа #1
//Арифметические выражения
//Вариант 25. Высокий
Console.Write("введите a");
double a = double.Parse(Console.ReadLine());
Console.Write("введите y");
double y = double.Parse(Console.ReadLine());
Console.Write("введите x");
double x = double.Parse(Console.ReadLine());

double b = (Math.Pow(1 / Math.Tan(Math.Pow(a, 3) * Math.PI / 180), 3));
double c = (Math.Pow(Math.Atan(a), 2) * Math.PI / 180);
Console.WriteLine($"J={(b + c) / (Math.Sqrt(Math.Pow(y, Math.Tan(x) * Math.PI / 180))):f2}");

//линейные алгоритмы
//вариант 25. Высокий
Console.Write("введите p:");
double p = double.Parse(Console.ReadLine());
Console.Write("введите s:");
double s = double.Parse(Console.ReadLine());
double r = p / (s * 0.95) * 1;
Console.WriteLine($"r={r:f2}%");

//целочисленная арифметика
//вариант 3.13. высокий
Console.Write($"введите n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"номер строки:{((n - 1) % 10 + 1)}");
Console.WriteLine($"Значение находится в строке:{((n - 1) % 10 + 1)}");