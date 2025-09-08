using O.Models;

namespace O.Services;

public class LoonService
{
    public string BetaalLoon(Medewerker medewerker)
    {
        if (medewerker.VoorkeursBetaalwijze == "bank")
        {
            return $"{medewerker.Naam} krijgt {medewerker.Salaris} loon via de bank.";
        }
        else if (medewerker.VoorkeursBetaalwijze == "zwart")
        {
            var belastingKorting = medewerker.Salaris * 0.3;
            return $"{medewerker.Naam} krijgt {medewerker.Salaris + belastingKorting} zwart loon.";
        }
        else if (medewerker.VoorkeursBetaalwijze == "bitcoin")
        {
            var aantalBitcoins = medewerker.Salaris / GetBitcoinKoers();
            return $"{medewerker.Naam} krijgt {aantalBitcoins} bitcoins."; 
        }

        throw new ArgumentException($"{medewerker.VoorkeursBetaalwijze} is niet mogelijk");
    }

    private double GetBitcoinKoers()
    {
        var random = new Random();
        return random.Next(10000, 100000);
    }
}
