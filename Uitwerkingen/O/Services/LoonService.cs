using O.Models;

namespace O.Services;

public class LoonService
{
    public string BetaalLoon(Medewerker medewerker)
    {
        var betaalwijzeFactory = new BetaalwijzeFactory(); 
        var gebruikteBetaalwijze = betaalwijzeFactory.GetBetaalwijze(medewerker.VoorkeursBetaalwijze);

        return gebruikteBetaalwijze.BetaalLoon(medewerker.Naam, medewerker.Salaris); 
    }
}
