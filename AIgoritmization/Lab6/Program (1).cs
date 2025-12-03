using Lab6_library;
//библиотеки. вариант 11. средний уровень

double[,] myMas = new double[6, 6];
for (int i = 0; i < myMas.GetLength(0); i++)
{
    for (int j = 0; j < myMas.GetLength(1); j++)
    {
        myMas[i, j] = (Math.Pow(Math.Pow(Math.Log(i+1),2)/(3.5-0.5*j),2)+Math.Pow((-Math.E),(i+j)));
        Console.Write($"{myMas[i,j]:F2} ");
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