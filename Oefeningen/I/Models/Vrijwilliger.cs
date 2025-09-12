using I.Models.Interfaces;

namespace I.Models;

public class Vrijwilliger : IMedewerker
{
    public Vrijwilliger(string naam, string woonplaats, double salaris)
    {
        Naam = naam;
        Woonplaats = woonplaats;
        Salaris = salaris;
    }

    public string Naam { get; }

    public string Woonplaats { get; }

    public double Salaris { get; private set; }

    public double GetBonus()
    {
        // Een vrijwilliger krijgt geen bonus;
        return 0;
    }

    public double GetDertiendeMaand()
    {
        // Een vrijwilliger krijgt geen dertiende maand.
        return 0;
    }

    public double GetVakantiegeld()
    {
        // Een vrijwilliger krijgt geen vakantiegeld.
        return 0;
    }

    public void UpdateSalaris(int percentage)
    {
        // Een vrijwilliger krijgt geen salaris;
    }
}
