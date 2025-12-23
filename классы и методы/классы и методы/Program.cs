// Базовый уровень 28 вариант
Console.WriteLine("Введите значение напряжения: ");
double u = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение сопротивления: ");
double r = double.Parse(Console.ReadLine());

ElectroCalc calc = new ElectroCalc(u, r);
calc.Print();

class ElectroCalc
{
    private double u;
    private double r;
    
    public ElectroCalc(double u, double r)
    {
        this.u = u;
        this.r = r;
    }
    
    public double getu() { return u; }
    public double getr() { return r; }
    
    public double getI()
    {
        return u / r;
    }
    
    public void Print()
    {
        Console.WriteLine("Ток по основной формуле (getI): " + getI());
    }
}
