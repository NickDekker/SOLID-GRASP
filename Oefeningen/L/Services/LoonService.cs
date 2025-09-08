using L.Models;

namespace L.Services;

public static class LoonService
{
    public static void Betaal(IMedewerker medewerker)
    {
        Console.WriteLine($"{medewerker.BerekenSalaris()} euro betaald voor {medewerker.Naam} ({medewerker.GetType().Name})");
    }
}
