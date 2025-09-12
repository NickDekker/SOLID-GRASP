using I.Models.Interfaces;

namespace I.Services;

public class BetalingsService
{
    public void BetaalSalaris(IMedewerker medewerkerMetSalaris)
    {
        var maand = DateTime.Now.Month;

        if (maand == 5)
        {
            Console.WriteLine($"Betaal {medewerkerMetSalaris.Salaris + medewerkerMetSalaris.GetVakantiegeld()} salaris.");
        }
        else
        {
            Console.WriteLine($"Betaal {medewerkerMetSalaris.Salaris} salaris.");
        }
    }

    public void BetaalBonus(IMedewerker medewerkerMetBonus)
    {
        Console.WriteLine($"Betaal {medewerkerMetBonus.GetBonus()} bonus.");
    }

    public void BetaalDertiendeMaand(IMedewerker medewerkerMetDertiendeMaand)
    {
        Console.WriteLine($"Betaal {medewerkerMetDertiendeMaand.GetDertiendeMaand()} dertiende maand.");
    }
}
