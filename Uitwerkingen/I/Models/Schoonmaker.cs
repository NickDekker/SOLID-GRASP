using I.Models.Interfaces;

namespace I.Models;

public class Schoonmaker : IOrganisatielid, IKrijgtSalaris
{
    public Schoonmaker(string naam, string woonplaats, double salaris)
    {
        Naam = naam;
        Woonplaats = woonplaats;
        Salaris = salaris; 
    }

    public string Naam { get;  }

    public string Woonplaats { get; }

    public double Salaris { get; private set; }
    
    public double GetVakantiegeld()
    {
        return Salaris * 0.8; 
    }

    public void UpdateSalaris(int percentage)
    {
        Salaris = Salaris / 100 * (100 + percentage);
    }
}
