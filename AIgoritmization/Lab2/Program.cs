//Лабораторная работа 2. Логические выражения
//Вариант 18. Высокий
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(y>=x*x-2&&y<=x);

//Условные операторы
//Вариант 15. Высокий
Console.WriteLine("Введите координаты трех вершин:");

Console.Write("Вершина 1: ");
string[] v1 = Console.ReadLine().Split();
int x1 = int.Parse(v1[0]);
int y1 = int.Parse(v1[1]);

Console.Write("Вершина 2: ");
string[] v2 = Console.ReadLine().Split();
int x2 = int.Parse(v2[0]);
int y2 = int.Parse(v2[1]);

Console.Write("Вершина 3: ");
string[] v3 = Console.ReadLine().Split();
int x3 = int.Parse(v3[0]);
int y3 = int.Parse(v3[1]);

int x4 = x1 ^ x2 ^ x3;
int y4 = y1 ^ y2 ^ y3;


Console.WriteLine($"Четвертая вершина: {x4} {y4}");

//Оператор выбора.
//Вариант 11. Средний
Console.WriteLine("Вычисление функции y");
Console.WriteLine("====================");
Console.WriteLine("Доступные варианты:");
Console.WriteLine("1. a = -1; b = 3.4; z = tg(bx)");
Console.WriteLine("2. a = -3.2; b = 5.5; z = tg(bx^2)");
Console.WriteLine("3. a = -5.2; b = 7.2; z = tg(bx^3)");
Console.Write("Выберите вариант (1, 2 или 3): ");

int variant = int.Parse(Console.ReadLine());

Console.Write("Введите значение x: ");
double xx = double.Parse(Console.ReadLine());

double a = 0, b = 0, z = 0, yy = 0;

switch (variant)
{
    case 1:
        a = -1.0;
        b = 3.4;
        z = Math.Tan(b * x);
        Console.WriteLine($"Выбран вариант 1: a = {a}, b = {b}, z = tg({b}*x)");
        break;

    case 2:
        a = -3.2;
        b = 5.5;
        z = Math.Tan(b * x * x);
        Console.WriteLine($"Выбран вариант 2: a = {a}, b = {b}, z = tg({b}*x^2)");
        break;

    case 3:
        a = -5.2;
        b = 7.2;
        z = Math.Tan(b * x * x * x);
        Console.WriteLine($"Выбран вариант 3: a = {a}, b = {b}, z = tg({b}*x^3)");
        break;

    default:
        Console.WriteLine("Ошибка: неверный вариант");
        return;
}

if (xx <= a)
{
    // y = e^(ax) - 3.5 * cos^2(z + bx)
    yy = Math.Exp(a * xx) - 3.5 * Math.Pow(Math.Cos(z + b * xx), 2);
    Console.WriteLine("Использована первая формула (x <= a)");
}
else if (xx <= Math.Pow(b, 3))
{
    // y = a + ln|a + bx| - 2x
    yy = a + Math.Log(Math.Abs(a + b * xx)) - 2 * xx;
    Console.WriteLine("Использована вторая формула (a < x <= b^3)");
}
else
{
    // y = a + cos^3.5(a + bxz)
    yy = a + Math.Pow(Math.Cos(a + b * xx * z), 3.5);
    Console.WriteLine("Использована третья формула (x > b^3.5)");
}

Console.WriteLine($"Результат: y = {yy:F2}");
