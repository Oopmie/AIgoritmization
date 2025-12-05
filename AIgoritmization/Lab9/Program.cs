//инкапсуляция. вариант 29. средний
Console.WriteLine("Введите длину комнаты");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ширину комнаты");
int width = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите высоту комнаты");
int height = int.Parse(Console.ReadLine()!);
Room room = new Room(length, width, height);
//Room.Print();
class Room
{
    private double length;
    private double width;
    private double height;

    public Room(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    public double Length
    { get { return length; } }
    public double Width
    { get { return width; } }
    public double Height
    { get { return height; } }
    public decimal getTotal()
    { 

    }
    public void Print()
    {
        Console.WriteLine($"стоимость {time} минут разговора = {getTotal():F2} рублей");
    }
}