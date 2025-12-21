// Базовый уровень 28 вариант
class ElectricCircuit
{
    private double voltage; 
    private double resistance; 

   
    public static double defaultResistance = 1;

   
    public static double DefaultResistance
    {
        get { return defaultResistance; }
        set { if (value > 0) defaultResistance = value; }
    }

    public ElectricCircuit(double voltage, double resistance)
    {
        this.voltage = voltage;
        this.resistance = resistance;
    }

    static ElectricCircuit()
    {
        defaultResistance = 1;
    }

    public void CalculateCurrent()
    {
        double current = voltage / resistance;
        Console.WriteLine($"Ток: {current:F2} А");
    }

    public static void CheckCurrent(double voltage, double resistance)
    {
        double current = voltage / resistance;
        Console.WriteLine($"Ток: {current:F2} А");
    }
}

public static class ElectricalCalculations
{
    public static double GetCurrent(double voltage, double resistance)
    {
        return voltage / resistance;
    }
}