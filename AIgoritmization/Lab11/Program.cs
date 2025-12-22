//Полиморфизм. Вариант 22. Базовый

Console.WriteLine("Фамилия руководителя: ");
string? surname = Console.ReadLine();
Console.WriteLine("Самооценка руководителя: ");
int self_esteem = int.Parse(Console.ReadLine()!);
Console.WriteLine("Оценка: ");
int esteem = int.Parse(Console.ReadLine()!);
Console.WriteLine("оценка потомками P: ");
int p = int.Parse(Console.ReadLine()!);
Supervisor supervisor = new Supervisor (self_esteem, esteem, surname);
Console.WriteLine($"оценка работы Q: {supervisor.getEsteem()}");
SupervisorChild supervisor1 = new SupervisorChild (self_esteem, esteem, surname, p);
Console.WriteLine(supervisor1);

class Supervisor
{
    private int esteem;
    private int self_esteem;
    private string? surname;

    public Supervisor(int _esteem, int _self_esteem, string? _surname)
    {
        this.esteem = _esteem;
        this.self_esteem = _self_esteem;
        this.surname = _surname;
    }
    public int Esteem
    { get { return esteem; }
        set { if (value >= 0) esteem = value; } }
    public int Self_esteem
    { get { return self_esteem; }
        set {if(value>=0) self_esteem = value; }
    }
    public string? Surname
    { get { return surname; }
        set { surname = value; } }
    


    public virtual int getEsteem()
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

    public int P
    {
        get { return p; }
        set { p = value; }
    }

    public override int getEsteem()
    {
        return (int)(0.3*base.getEsteem()+0.7*p);
    }
    public override string ToString()
    {
        return $"Qp = {getEsteem()}";
    }
}

