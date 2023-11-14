using ConsoleApp7;

static double AtlagTerfogat(List<Henger> hengerek)
{
    double szumTerfogat = 0;
    foreach (var henger in hengerek)
    {
        szumTerfogat += henger.Terfogat();
    }
    return szumTerfogat / Henger.SzuletesSzamlalo;
}

static void Lista(List<Henger> hengerek)
{
    foreach (var henger in hengerek)
    {
        Console.WriteLine(henger);
    }
}
static void Main(string[] args)
{
    List<Henger> testek = new List<Henger>();
    testek.Add(new Henger(1, 4));
    testek.Add(new TomorHenger(0.5, 4, 2));
    testek.Add(new TomorHenger(0.5, 4));
    testek.Add(new Cso(5, 5, 0.5));
    testek.Add(new Cso(5, 5, 0.5, 2));
    Lista(testek);
    Console.WriteLine("Testek száma:" + testek.Count);
    Console.WriteLine("Létrehozott hengerek száma:" + Henger.SzuletesSzamlalo);
    Console.WriteLine($"Átlag térfogat: {AtlagTerfogat(testek):N2}");
}

class Cso : Henger
{
    private double falVastagsag;

    public Cso(double sugar, double magassag, double falVastagsag)
        : base(sugar, magassag)
    {
        this.falVastagsag = falVastagsag;
    }

    public Cso(double sugar, double magassag)
        : this(sugar, magassag, 1)
    {
    }

    public override double Terfogat()
    {
        double belsőSugar = sugar - falVastagsag;
        return Math.PI * belsőSugar * belsőSugar * magassag;
    }

    public override string ToString()
    {
        return $"Cso: Sugar = {sugar:N2}, Magasság = {magassag:N2}, Falvastagság = {falVastagsag:N2}, Térfogat = {Terfogat():N2}";
    }
}

class TomorHenger : Henger
{
    private double vasFajsuly;

    public TomorHenger(double sugar, double magassag, double vasFajsuly)
        : base(sugar, magassag)
    {
        this.vasFajsuly = vasFajsuly;
    }

    public TomorHenger(double sugar, double magassag)
        : this(sugar, magassag, 7.87)
    {
    }

    public override double Terfogat()
    {
        return base.Terfogat() - vasFajsuly;
    }

    public override string ToString()
    {
        return $"Tömör Henger: Sugar = {sugar:N2}, Magasság = {magassag:N2}, Vas Fajsúly = {vasFajsuly:N2}, Térfogat = {Terfogat():N2}";
    }
}