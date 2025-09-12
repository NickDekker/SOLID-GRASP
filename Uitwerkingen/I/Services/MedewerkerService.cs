using I.Models.Interfaces;

namespace I.Services;

public class MedewerkerService
{
    public void StuurKaartje(IOrganisatielid organisatielid)
    {
        var tekstOpKaartje = $"Beste {organisatielid.Naam},\n\n" +
                           "Wij waarderen uw inzet voor ons bedrijf enorm. " +
                           "Bedankt voor alles wat u doet!\n\n" +
                           "Met vriendelijke groet,\n" +
                           "Het Team";

        var adres = organisatielid.Woonplaats;

        Console.WriteLine($"Stuur kaartje naar {adres} met tekst: {tekstOpKaartje} \n\n\n\n");        
    }
}
