////1.12.25 DateTime
//DateTime data1 = new DateTime();
//Console.WriteLine(data1);
//DateTime data2 = DateTime.Now;
//Console.WriteLine(data2);
//DateTime data3 = new DateTime(2025, 11, 23, 23, 22, 45);
//Console.WriteLine(data3);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(data2.Year);
//Console.WriteLine(data2.Month);
//Console.WriteLine(data2.Day);
//Console.WriteLine(data2.Hour);
//Console.WriteLine(data2.Minute);
//Console.WriteLine(data2.Second);
//Console.WriteLine(data2.Millisecond);
//Console.WriteLine(data2.Microsecond);
//Console.WriteLine(data2.Nanosecond);
//Console.WriteLine(DateTime.MinValue);
//Console.WriteLine(DateTime.MaxValue);
//Console.WriteLine(data2.Kind);
//DateTime data5 = DateTime.Parse("2025-12-3");
//Console.WriteLine(data5.Add(new TimeSpan(4, 5, 6, 45)));
//Console.WriteLine(data5.AddDays(7));
//Console.WriteLine(data5.AddDays(-3));
//Console.WriteLine(data5==DateTime.Now);
//Console.WriteLine(data2.ToLocalTime());
//Console.WriteLine(data2.ToLongDateString());
//Console.WriteLine(data2.ToUniversalTime());
//Console.WriteLine(data2.ToShortTimeString());
//Console.WriteLine(data2.ToLongTimeString());

////дата и время во всех форматах
//Console.WriteLine();
//Console.WriteLine($"D:{data2.ToString("D")}");
//Console.WriteLine($"d:{data2.ToString("d")}");
//Console.WriteLine($"F:{data2.ToString("F")}");
//Console.WriteLine($"f:{data2.ToString("f")}");
//Console.WriteLine($"G:{data2.ToString("G")}");
//Console.WriteLine($"g:{data2.ToString("g")}");
//Console.WriteLine($"M:{data2.ToString("M")}");
//Console.WriteLine($"O:{data2.ToString("O")}");
//Console.WriteLine($"o:{data2.ToString("o")}");
//Console.WriteLine($"R:{data2.ToString("R")}");
//Console.WriteLine($"s:{data2.ToString("s")}");
//Console.WriteLine($"T:{data2.ToString("T")}");
//Console.WriteLine($"t:{data2.ToString("t")}");
//Console.WriteLine($"U:{data2.ToString("U")}");
//Console.WriteLine($"u:{data2.ToString("u")}");
//Console.WriteLine($"Y:{data2.ToString("Y")}");
//Console.WriteLine(data2.ToString("yyyy-MM-dd H:mm:ss"));

////DateOnly
//Console.WriteLine();
//DateOnly d1 = DateOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(d1);
//DateOnly d2 = new DateOnly();
//Console.WriteLine(d2);
//DateOnly d3 = new DateOnly(2025,12,3);
//Console.WriteLine(d3);
//Console.WriteLine(d3.Day);
//Console.WriteLine(d3.Month);
//Console.WriteLine(d3.Year);
//Console.WriteLine(d3.DayOfWeek);
//Console.WriteLine(d3.DayOfYear);
//Console.WriteLine(DateOnly.MinValue);
//Console.WriteLine(DateOnly.MaxValue);
//Console.WriteLine(d1.ToLongDateString());

////TimeOnly
//Console.WriteLine();
//TimeOnly T1 = new TimeOnly();
//Console.WriteLine(T1);
//TimeOnly T2 =TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(T2);
//Console.WriteLine(T2.Hour);
//Console.WriteLine(T2.Minute);
//Console.WriteLine(T2.Second);
//Console.WriteLine(T2.Ticks);





//4.12.2025
//null
//using System.Numerics;

//int? x1= 6;
//if (x1.HasValue)
//{
//    int x2 = (int)x1;
//    Console.WriteLine(x2);
//}
//int? x3 = x1 + 6;

////?? null-объединение
//string? text = "my";
//string name = text ?? "";
//Console.WriteLine(name);

//var tuple = (5, 10);
//Console.WriteLine(tuple.Item1);
//Console.WriteLine(tuple.Item2);
//(string, int, double) person = ("Tom", 5, 8.9);
//Console.WriteLine(person.Item1);
//Console.WriteLine(person.Item2);
//Console.WriteLine(person.Item3);

//int a = 6, b = 7;
//(a,b)=(b,a);
//Console.WriteLine(a+" "+b);

//int[] mas = new int[10];
//Random rnd = new Random(); 
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next();
//    Console.WriteLine(mas[i]+" ");
//}
//Console.WriteLine();
//var tuple = GetData(mas);
//Console.WriteLine(res.max);
//Console.WriteLine(res.min);
//Console.WriteLine(res.sum);
//Console.WriteLine(res.mult);
//(int max, int min, int sum, int milt) GetData(int[]mas)
//{
//    int _max = mas[0], _min = mas[0], s = 0, p = 1;
//    var res (max: _max, min: _min, sum: s, mult: p);
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i]> _max) _max=mas[i];
//        if (mas[i] < _min) _min = mas[i];
//        sum += mas[i];
//        mult*= mas[i] ;
//    }





//5.12.2025
//ООП
//Rectangle rectangle1 = new Rectangle();
//Console.WriteLine($"{rectangle1.getArea():F2}");
//Console.WriteLine($"{rectangle1.getPerimetr():F2}");

//Rectangle rectangle2 = new Rectangle();
//Console.WriteLine($"{rectangle2.Width()}*{rectangle2.Height()}={rectangle2.getArea()}");
//Console.WriteLine($"2*({rectangle2.Width()}+{rectangle2.Height()})={rectangle2.getPerimetr()}");

//rectangle2.setWidth(150);
//rectangle2.setHeight(500);
//Console.WriteLine($"{rectangle2.getWidth()}*{rectangle2.getHeight()}={rectangle2.getArea()}");
//Console.WriteLine($"2*({rectangle2.getWidth()}+{rectangle2.getHeight()})={rectangle2.getPerimetr()}");

//class Rectangle
//{

//    private double width;
//    private double height;

//    public Rectangle(double _width, double _height)
//    {
//        this.width = _width;
//        this.height = _height;
//    }
//    public Rectangle() //конструктор по умолчанию
//    {
//        width = 1;
//        height = 1;
//    }
//    public double Width 
//    {
//        get { return width; }
//        set { if (value > 0) width = value; }
//    }
//    public double Height
//    {
//        get { return Height; }
//        set { if (value > 0) Height = value; }
//    }
//    //геттеры
//    //public double getWidth()
//    //    { return width; }
//    //public double getHeight()
//    //{ return height; }
//    public double getPerimetr()
//    {
//        return 2 * (width + height);
//    }
//    public double getArea()
//    {
//        return width * height;
//    }
//    ////сеттеры
//    //public void setWidth(double _width)
//    //    { width = _width; }
//    //public void setHeight(double _height)
//    //        { height = _height; }
//}

Console.WriteLine("Введите день");
int day = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите время разговора в минутах");
int time = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите цену минуты разговора");
int price = int.Parse(Console.ReadLine()!);
Tel tel = new Tel(day,time,price);
tel.Print();
class Tel
{
    private int day;
    private double time;
    private decimal price;

    public Tel(int day, double time, decimal price)
    {
        this.day = day;
        this.time = time;
        this.price = price;
    }
    public int Day
    { get { return day; } }
    public double Time
    { get { return time; } }
    public decimal Price
    { get { return price; } }
    public decimal getTotal()
    {
        return day switch
        {
            1 => (decimal)time * price,
            2 => (decimal)time * price,
            3 => (decimal)time * price,
            4 => (decimal)time * price,
            5 => (decimal)time * price,
            6 => (decimal)0.9 * ((decimal)time * price),
            7 => (decimal)0.9 * ((decimal)time * price),
        };
    }
    public void Print()
    {
        Console.WriteLine($"стоимость {time} минут разговора");
    }
}