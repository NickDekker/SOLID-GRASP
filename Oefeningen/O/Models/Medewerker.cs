namespace O.Models;

public class Medewerker
{
    public Medewerker(string naam, string woonplaats, double salaris, string voorkeursBetaalwijze = "bank")
    {
        Naam = naam;
        Woonplaats = woonplaats;
        Salaris = salaris;
        VoorkeursBetaalwijze = voorkeursBetaalwijze;
    }

    public string Naam { get; }

    public string Woonplaats { get; private set; }

    public double Salaris { get; private set; }

    public string VoorkeursBetaalwijze { get; private set; }   
}