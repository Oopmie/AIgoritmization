//Лабораторная работа 3. циклы с предусловием и постусловием
//вариант 11. высокий
Console.WriteLine("Введите последовательность чисел. 0 - завершение последовательности");
double a = 1;
do
{
    double y = int.Parse(Console.ReadLine());
    if (y == 0) break;
    if (y < 0) a *= y;
}
while (true);
Console.WriteLine($"Произведение чисел : {a}");

//for
//вариант 11. средний
Console.WriteLine("введите x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите предел");
int n = int.Parse(Console.ReadLine());

double w = 0;
double p = 1;
for (int k = 1; k <= n; k++)
{
    w += (Math.Pow(-1, 3 * k + 1)) / ((k - 5) * Math.Pow(x, k));
    
    for (int m = 1; m <= k + 7; m++)
    {
        if (m == 2 ||m==3) continue;
        p *= (m * m - 9) / (m - 2);
    }
}
double s = 0;
s = w * p;
Console.WriteLine($"s={s:F2}");


//вычисление бесконечных сумм
//вариант 11
Console.Write("введите n:");
int n1 = int.Parse(Console.ReadLine());
Console.Write("введите x:");
int xx = int.Parse(Console.ReadLine());
double s1 = 0;
long F = 1;
for (int i = 1; i < n1; i ++)
{
    for (int j = 1; j <= i; j ++)
    {
        F *= j;
    }
    s1+=((2*i+1)*Math.Pow(xx,n1)/F);
}
Console.WriteLine($"s={s1}");

//табулирование функций
//вариант 11. высокий
Console.WriteLine("-----------------------------");
Console.WriteLine("|     x       |       y     |");
Console.WriteLine("-----------------------------");
double f = 0;
for (double x1 = -1; x1 <= 1; x1 += 0.25)
{
    double u = Math.Pow(x1, 2) - Math.Asin(Math.Pow(x1, 2) * Math.PI / 180);
    if (x1 > Math.PI/180)
    {
        f = Math.Pow(u, Math.Abs(Math.Cos(x1*Math.PI/180)));
    }
    else if (x1 <= Math.PI/180)
    {
        f = Math.Pow(u, Math.Sin(x1 * Math.PI / 180));
    }
    Console.WriteLine($"|{x1,9:f2} {" ",-3}|{f,12:f2}{" "}|");
}

Console.WriteLine("-----------------------------");

