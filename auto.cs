
public class Auto
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int RokProdukcji { get; set; }
    public int Predkosc { get; private set; }
    public int Przebieg { get; set; }

    public Auto(string marka, string model, int rokProdukcji, int przebieg)
    {
        Marka = marka;
        Model = model;
        RokProdukcji = rokProdukcji;
        Predkosc = 0;
        Przebieg = przebieg;

    }

    public void Przyspiesz(int oile)
    {
        if (oile > 0)
        {
            Predkosc += oile;
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"{Marka} {Model} ({RokProdukcji}) - prędkość: {Predkosc} km/h {Przebieg}km");
    }
}

public class Auto1
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int RokProdukcji { get; set; }
    public int Predkosc { get; private set; }
    public int Przebieg { get; set; }

    public Auto1(string marka, string model, int rokProdukcji, int przebieg)
    {
        Marka = marka;
        Model = model;
        RokProdukcji = rokProdukcji;
        Predkosc = 0;
        Przebieg = przebieg;

    }

    public void Przyspiesz(int oile)
    {
        if (oile > 0)
        {
            Predkosc += oile;
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"{Marka} {Model} ({RokProdukcji}) - prędkość: {Predkosc} km/h {Przebieg}km");
    }
}
