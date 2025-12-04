using Lab6_library;
//функции. высокий. вариант 11

Console.Write("Введите первое двоичное число: ");
string a = Console.ReadLine();

Console.Write("Введите второе двоичное число: ");
string b = Console.ReadLine();

int aInt = Convert.ToInt32(a, 2);
int bInt = Convert.ToInt32(b, 2);

string result = AddBinary(aInt, bInt);

Console.WriteLine($"Сумма = {result}");

static string AddBinary(int a, int b)
{
    if (b == 0)
        return Convert.ToString(a, 2);
    int sum = a ^ b;
    int carry = (a & b) << 1;
    return AddBinary(sum, carry);
}

//библиотеки. вариант 11. средний уровень

double[,] myMas = new double[6, 6];
for (int i = 0; i < myMas.GetLength(0); i++)
{
    for (int j = 0; j < myMas.GetLength(1); j++)
    {
        myMas[i, j] = (Math.Pow(Math.Pow(Math.Log(i + 1), 2) / (3.5 - 0.5 * j), 2) + Math.Pow((-Math.E), (i + j)));
        Console.Write($"{myMas[i, j]:F2} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
double[] res1 = Lab6_library.Matrix.vectorSqrt(myMas);
for (int i = 0; i < res1.Length; i++)
{
    Console.Write($"{res1[i]:F2} ");
}
double sum = Lab6_library.Matrix.SumMinMax(myMas);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"сумма:{sum:F2}");