using O.Models;

namespace O.Services;

public class LoonService
{
    public void BetaalLoon(Medewerker medewerker, string betaalWijze)
    {
        var vakantiegeld = BerekenVakantieGeld(medewerker.Salaris);
        var totaalSalaris = medewerker.Salaris + vakantiegeld;

        if (betaalWijze == "bank")
        {
            Console.WriteLine($"{medewerker.Naam} krijgt {totaalSalaris} loon via de bank.");
        }
        else if (betaalWijze == "zwart")
        {
            var ontdokenBelasting = totaalSalaris * 0.38;
            Console.WriteLine($"{medewerker.Naam} krijgt {totaalSalaris + ontdokenBelasting} zwart loon.");
        }
        else if (betaalWijze == "bitcoin")
        {
            var aantalBitcoins = totaalSalaris / GetBitcoinKoers();
            Console.WriteLine($"{medewerker.Naam} krijgt {aantalBitcoins} bitcoins.");
        }
    }

    private double GetBitcoinKoers()
    {
        var random = new Random();
        return random.Next(10000, 100000);
    }

    private double BerekenVakantieGeld(double salaris)
    {
        if (DateTime.Now.Month == 5)
        {
            return salaris * 0.8;
        }
        return 0;
    }
}
