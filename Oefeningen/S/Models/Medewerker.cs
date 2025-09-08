namespace S.Models;

public class Medewerker
{
    public Medewerker(string naam, string woonplaats, double salaris)
    {
        Naam = naam;
        Woonplaats = woonplaats;
        Salaris = salaris;
    }

    public string Naam { get; }

    public string Woonplaats { get; private set; }

    public double Salaris { get; private set; }

    public void UpdateWoonplaats(string nieuweWoonplaats)
    {
        Woonplaats = nieuweWoonplaats;
    }

    public void UpdateSalaris(double nieuwSalaris)
    {
        Salaris = nieuwSalaris;
    }

    public void BetaalLoon()
    {
        var maand = DateTime.Now.Month;

        var uitTebetalen = Salaris;

        if (maand == 5) // in mei Krijg je vakantiegeld
        {
            var vakantiegeld = uitTebetalen * 0.8;
            uitTebetalen += vakantiegeld;
        }

        Console.WriteLine($"Medewerker {Naam} krijgt {uitTebetalen} euro salaris.");
    }
}