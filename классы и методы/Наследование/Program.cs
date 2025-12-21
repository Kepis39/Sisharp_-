Console.Write("Введите значение напряжения: ");
double v = double.Parse(Console.ReadLine());
Console.Write("Введите значение сопротивления: ");
double r = double.Parse(Console.ReadLine());
Console.Write("Введите значение времени: ");
double t = double.Parse(Console.ReadLine());
Console.Write("Введите КПД резистора (0-1): ");
double k = double.Parse(Console.ReadLine());
Console.Write("Введите температуру окружающей среды: ");
double temp = double.Parse(Console.ReadLine());

ResistorWorkChild rwc = new ResistorWorkChild(v, r, t, k, temp);
rwc.Print();
class ResistorWork
{
    private double v;
    private double r; 
    private double t; 

    public ResistorWork(double v, double r, double t)
    {
        this.v = v;
        this.r = r;
        this.t = t;
    }

    public double getv() { return v; }
    public double getr() { return r; }
    public double gett() { return t; }

    public double getWork()
    {
       
        return (v * v / r) * t;
    }

    public double getPower()
    {
     
        return v * v / r;
    }

    public void Print()
    {
        Console.WriteLine($"Работа резистора по основной формуле: {getWork():F2} Дж");
        Console.WriteLine($"Мощность резистора: {getPower():F2} Вт");
    }
}

class ResistorWorkChild : ResistorWork
{
    private double k; 
    private double temp;

    public ResistorWorkChild(double v, double r, double t, double k, double temp) : base(v, r, t)
    {
        this.k = k;
        this.temp = temp;
    }

    public double GetEffectiveWork()
    {
        
        return getWork() * k;
    }

    public double GetHeatLoss()
    {
       
        return getWork() * (1 - k);
    }

    public new void Print()
    {
        base.Print(); 
        Console.WriteLine($"Эффективная работа с учетом КПД: {GetEffectiveWork():F2} Дж");
        Console.WriteLine($"Тепловые потери: {GetHeatLoss():F2} Дж");
        Console.WriteLine($"Температура окружающей среды: {temp}°C");
    }
}