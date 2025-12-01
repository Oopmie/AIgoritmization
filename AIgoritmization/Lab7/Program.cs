////структуры. средний. вариант 18
//using System.Linq.Expressions;

//try
//{
//    Console.WriteLine("Введите количество продуктов:");
//    int n = int.Parse(Console.ReadLine());
//    product[] products = new product[n];
//    for (int i = 0; i < product.Length; i++)
//    {
//        Console.WriteLine("введите название продукта:");
//        products[i].name = Console.ReadLine();
//        Console.WriteLine("введите стоимость:");
//        products[i].price = Console.ReadLine();
//        Console.WriteLine("введите год выпуска:");
//        products[i].year = Console.ReadLine();
//        Console.WriteLine("введите срок годности продукта:");
//        products[i].ExpirationDate = Console.ReadLine();
//        Console.WriteLine("введите название продукта:");
//        products[i].name = Console.ReadLine();
//    }
//}
//catch {Exception ex}
//{
//    Console.WriteLine(Ex.massage
//}
//decimal sum = 0;
//foreach (product product in products)
//{
//    if (product.year==DateTime.Now.Year)
//    {
//        sum++;
//    }
//}
//struct product
//{
//    public string name;
//    public decimal price;
//    public int year;
//    public int ExpirationDate;
//    public int Quantity;
//    public string Manufacturer;
//    public void Print()
//    {
//        Console.WriteLine($"{name},{price},{year},{ExpirationDate},{Manufacturer}");
//    }
//}
//using System.Xml.Linq;

//try
//{
//    Console.WriteLine("Введите количество сотрудников: ");
//    int n = int.Parse(Console.ReadLine());
//    Employee[] people = new Employee[n];
//    for (int i = 0; i < people.Length; i++)
//    {
//        Console.WriteLine("введите данные о сотруднике");
//        Console.WriteLine("введите имя: ");
//        people[i].firstName = Console.ReadLine();
//        Console.WriteLine("введите отчество: ");
//        people[i].middleName = Console.ReadLine();
//        Console.WriteLine("введите фамилию: ");
//        people[i].lastName = Console.ReadLine();
//        Console.WriteLine("введите должность: ");
//        people[i].position = Console.ReadLine();
//        Console.WriteLine("введите зарплату: ");
//        people[i].salary = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("введите дату рождения: ");
//        people[i].dateBirth = DateTime.Parse(Console.ReadLine());
//    }
//    foreach (Employee emp in people)
//    {
//        if (emp.dateBirth.Month == 5)
//        {
//            emp.Print();
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//struct Employee
//{
//    public string firstName;
//    public string middleName;
//    public string lastName;
//    public string position;
//    public decimal salary;
//    public DateTime dateBirth;
//    public void Print()
//    { Console.WriteLine($"{firstName},{middleName},{lastName},{position},{salary},{dateBirth}"); }
//}

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
        Console.WriteLine("введите дату производства: ");
        product[i].year = int.Parse(Console.ReadLine());
        Console.WriteLine("введите срок годности: ");
        product[i].ExpirationDate = int.Parse(Console.ReadLine());
        Console.WriteLine("введите количество: ");
        product[i].Quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("введите производителя: ");
        product[i].Manufacturer = Console.ReadLine();
    }
    int pr = 0;
    foreach (Products emp in product)
    {
        if (emp.ExpirationDate < 20)
        {
            emp.Print();
        }
        else
        {
            pr++;
        }
    }
    Console.WriteLine("");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Products
{
    public string name;
    public decimal price;
    public int year;
    public int ExpirationDate;
    public int Quantity;
    public string Manufacturer;
    public void Print()
    { Console.WriteLine($"{name},{price},{year},{ExpirationDate},{Quantity},{Manufacturer}"); }
}