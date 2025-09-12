using I.Models;
using I.Models.Interfaces;
using I.Services;

/// In dit project gaat het om het interface segregation principle
/// 
/// OPDRACHT: 
/// 
/// Herschrijf de code zo dat je voldoet aan dit principe. 


var betalingsService = new BetalingsService();
var medewerkerService = new MedewerkerService();

IMedewerker directeur = new Directeur("Klaas", "Kampen", 5000);
IMedewerker schoonmaker = new Schoonmaker("Piet", "Almere", 2000);
IMedewerker vrijwilliger = new Vrijwilliger("Jan", "Amsterdam", 0);

Console.WriteLine("************  Verwerk directeur ************");
medewerkerService.StuurKaartje(directeur);
betalingsService.BetaalSalaris(directeur);
betalingsService.BetaalBonus(directeur);
betalingsService.BetaalDertiendeMaand(directeur);

Console.WriteLine("\n************  Verwerk schoonmaker ************");
medewerkerService.StuurKaartje(schoonmaker);
betalingsService.BetaalSalaris(schoonmaker);


Console.WriteLine("\n************ Verwerk vrijwilliger ************");
medewerkerService.StuurKaartje(vrijwilliger);

Console.WriteLine();