//Лабораторная работа 4. Одномерные массивы
//вариант 9. высокий

int[]mas= new int[7];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(10, 100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Console.WriteLine();
int[] mas1  = new int[7];
for (int i = 0; i < mas.Length; i++)
{
    mas1[i] = mas[i]/10;
    Console.Write(mas1[i] + "  ");
}
Console.WriteLine();

//Лабораторная работа 4. Двумерные массивы
//вариант 15. высокий

Console.Write("Введите n:");
int n=int.Parse(Console.ReadLine());
int[,] mas2 = new int[n, n];
for (int i = 0;i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i+j==n-1)
        {
            mas2[i, j] = 1;
        }
        else if (i+j<n-1)
        {
            mas2[i, j] = 0;
        }
        else
        {
            mas2[i, j] = 2;
        }
    }
}
Console.WriteLine("полученный массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}