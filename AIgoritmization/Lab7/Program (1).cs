

//структуры. средний. вариант 18

using System.Xml.Linq;

try
{
    Console.WriteLine("Введите количество товаров: ");
    int n = int.Parse(Console.ReadLine());
    Products[] product = new Products[n];

    for (int i = 0; i < product.Length; i++)
    {
        Console.WriteLine("введите данные о товаре");
        Console.WriteLine("введите название: ");
        product[i].name = Console.ReadLine();
        Console.WriteLine("введите стоимость: ");
        product[i].price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("введите дату производства (гггг-мм-дд): ");
        product[i].year = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("введите срок годности в днях: ");
        product[i].ExpirationDate = int.Parse(Console.ReadLine());
        Console.WriteLine("введите количество: ");
        product[i].Quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("введите производителя: ");
        product[i].Manufacturer = Console.ReadLine();
    }
    int pr = 0;
    foreach (Products emp in product)
    {
        if (emp.ExpirationDate < 20 && emp.ExpirationDate > 0)
        {
            emp.Print();
        }
        else if (emp.ExpirationDate <= 0)
        {
            pr++;
        }
    }
    Console.WriteLine($"Количество просроченных товаров: {pr}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


struct Products
{
    public string name;
    public decimal price;
    public DateOnly year;
    public int ExpirationDate;
    public int Quantity;
    public string Manufacturer;
    public void Print()
    { Console.WriteLine($"{name},{price},{year},{ExpirationDate},{Quantity},{Manufacturer}"); }
}