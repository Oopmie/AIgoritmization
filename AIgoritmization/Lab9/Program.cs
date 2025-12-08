//инкапсуляция. вариант 29. средний
Console.WriteLine("Введите длину комнаты");
double length = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ширину комнаты");
double width = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите высоту комнаты");
double height = double.Parse(Console.ReadLine()!);
Room room = new Room(length, width, height);
Console.WriteLine($"площадь стен = {room.getArea()}");
Console.WriteLine($"площадь стен без окна и двери = {room.getAreaW()}");
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
    public double getArea()
    {
        return 2 * (Width * Height) + 2 * (Length * Height);
    }
    public double getAreaW()
    {
        return 2 * (Width * Height) + 2 * (Length * Height) - (2 * 15) - (2 * 8);
    }
}