//Полиморфизм. Вариант 22. Базовый

Console.WriteLine("Фамилия руководителя: ");
string? surname = Console.ReadLine();
Console.WriteLine("Самооценка руководителя: ");
int self_esteem = int.Parse(Console.ReadLine()!);
Console.WriteLine("Оценка: ");
int esteem = int.Parse(Console.ReadLine()!);
Console.WriteLine("оценка потомками P: ");
int p = int.Parse(Console.ReadLine()!);
SupervisorChild supervisor = new SupervisorChild (self_esteem, esteem, surname, p);
Console.WriteLine($"оценка работы Q: {supervisor.getEsteem()}");
Console.WriteLine($"оцека работы Qp: {supervisor.getQp()}");

class Supervisor
{
    private int esteem;
    private int self_esteem;
    private string? surname;

    public Supervisor(int esteem, int self_esteem, string? surname)
    {
        this.esteem = esteem;
        this.self_esteem = self_esteem;
        this.surname = surname;
    }
    public int Esteem
    { get { return esteem; } }
    public int Self_esteem
    { get { return self_esteem; } }
    public string? Surname
    { get { return surname; } }
    
    
    public int getEsteem()
    {
        return esteem/self_esteem;
    }
}
class SupervisorChild : Supervisor
{
    private int p;

    public SupervisorChild(int esteem, int self_esteem, string? surname, int p) : base(esteem, self_esteem, surname)
    {
        this.p = P;
    }

    public int P { get; private set; }

    public double getQp()
    {
        return  (int)(0.3 * getEsteem() + 0.7 * P);
    }
}

