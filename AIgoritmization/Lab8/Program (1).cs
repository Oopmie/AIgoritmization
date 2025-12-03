//дата и время. средний. вариант 3

using System.Xml.Linq;

try
{
    Console.WriteLine("Введите количество сеансов: ");
    int n = int.Parse(Console.ReadLine());
    Session[] sessions = new Session[n];

    for (int i = 0; i < sessions.Length; i++)
    {
        Console.WriteLine("введите данные о сеансе");
        Console.WriteLine("введите логин: ");
        sessions[i].login = Console.ReadLine();
        Console.WriteLine("введите дату выхода в онлайн (гггг-мм-дд): ");
        sessions[i].date_online = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("введите время начала сеанса (чч:мм:сс): ");
        sessions[i].time_start = TimeOnly.Parse(Console.ReadLine());
        Console.WriteLine("введите время окончания сеанса (чч:мм:сс): ");
        sessions[i].time_end = TimeOnly.Parse(Console.ReadLine());
        Console.WriteLine("введите объем принятой информации (Кб): ");
        sessions[i].incoming_info = int.Parse(Console.ReadLine());
        Console.WriteLine("введите объем отправленной информации (Кб): ");
        sessions[i].outgoing_info = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("информация по всем сеансам:");
    foreach (var s in sessions)
    {
        s.Print();
    }
    Console.WriteLine("Введите начальную дату (гггг-мм-дд):");
    DateOnly startDate = DateOnly.Parse(Console.ReadLine());

    Console.WriteLine("Введите конечную дату (гггг-мм-дд):");
    DateOnly endDate = DateOnly.Parse(Console.ReadLine());
    bool found = false;
    foreach (var s in sessions)
    {
        if (s.date_online >= startDate && s.date_online <= endDate && s.TrafficMb() > 20.0)
        {
            s.Print();
            found = true;
        }
    }
    if (!found)
        Console.WriteLine("Нет подходящих сеансов");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Session
{
    public string login;
    public DateOnly date_online;
    public TimeOnly time_start;
    public TimeOnly time_end;
    public int incoming_info;
    public int outgoing_info;
    public TimeSpan Duration()
    {
        return time_end.ToTimeSpan() - time_start.ToTimeSpan();
    }
    public double TrafficMb()
    {
        return (incoming_info + outgoing_info) / 1024.0;
    }
    public void Print()
    {
        Console.WriteLine($"{login}, {date_online}, {time_start}, {time_end}, {incoming_info} Кб, {outgoing_info} Кб, Длительность: {Duration()}, Трафик: {TrafficMb():F2} Мб");
    }
}