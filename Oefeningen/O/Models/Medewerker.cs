namespace O.Models;

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

    public void UpdateWoonplaats(double nieuwSalaris)
    {
        Salaris = nieuwSalaris;
    }
}