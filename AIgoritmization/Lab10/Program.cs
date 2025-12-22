Console.WriteLine("Введите длину комнаты");
double length = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ширину комнаты");
double width = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите высоту комнаты");
double height = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество комнат: ");
int count = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите площадь коридора: ");
double hollArea = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите расход краски на 1 кв метр: ");
double paint = double.Parse(Console.ReadLine()!);
RoomChild room = new RoomChild(length, width, height, count, hollArea, paint);
Console.WriteLine($"площадь стен = {room.getArea()}");
Console.WriteLine($"площадь стен без окна и двери = {room.getAreaW()}");
Console.WriteLine($"понадобится краски: {room.getCount()}");
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

class RoomChild:Room
{
    private int count;
    private double hollArea;
    private double paint;

    public RoomChild(double length, double width, double height, int _count, double _hollArea, double _paint) : base(length, width, height)
    {
        this.count = _count;
        this.hollArea = _hollArea;
        this.paint = _paint;
    }
    public double getCount()
    {
        return ((getAreaW() + Width * Length) * count + hollArea)*paint;
    }

}