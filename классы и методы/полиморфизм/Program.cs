// вариант 6
class Mob
{
    private string marka;
    private double cena;
    private int memory;

    public Mob(string _marka, double _cena, int _memory)
    {
        this.marka = _marka;
        this.cena = _cena;
        this.memory = _memory;
    }

    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public double Cena
    {
        get { return cena; }
        set { cena = value; }
    }

    public int Memory
    {
        get { return memory; }
        set { memory = value; }
    }

    public virtual double GetQ()
    {
        return memory / cena;
    }

    public virtual string GetWindow()
    {
        return $"Телефон {marka}, Цена: {cena}, Память: {memory} ГБ, Q = {GetQ():F6}";
    }
}

class MobSim : Mob
{
    public int sim;

    public MobSim(string _marka, double _cena, int _memory, int _sim)
        : base(_marka, _cena, _memory)
    {
        this.sim = _sim;
    }

    public override double GetQ()
    {
        double baseQ = base.GetQ();
        return baseQ * sim; 
    }

    public override string GetWindow()
    {
        return base.GetWindow() + $", SIM: {sim}, Qp = {GetQ():F6}";
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Введите марку телефона: ");
        string marka = Console.ReadLine();

        Console.Write("Введите цену: ");
        double cena = double.Parse(Console.ReadLine());

        Console.Write("Введите объем памяти (ГБ): ");
        int memory = int.Parse(Console.ReadLine());

        Mob telefon = new Mob(marka, cena, memory);
        Console.WriteLine(new string('-', 60));
        Console.WriteLine(telefon.GetWindow());

        Console.Write("Введите количество SIM-карт: ");
        int sim = int.Parse(Console.ReadLine());

        MobSim telefonSim = new MobSim(marka, cena, memory, sim);
        Console.WriteLine(new string('-', 60));
        Console.WriteLine(telefonSim.GetWindow());
    }
}
