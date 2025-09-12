using I.Models.Interfaces;

namespace I.Models;

public class Vrijwilliger : IOrganisatielid
{
    public Vrijwilliger(string naam, string woonplaats)
    {
        Naam = naam;
        Woonplaats = woonplaats;      
    }

    public string Naam { get; }

    public string Woonplaats { get; }   
}
