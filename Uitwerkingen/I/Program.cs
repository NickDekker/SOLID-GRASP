using I.Models;
using I.Services;

var betalingsService = new BetalingsService();
var medewerkerService = new MedewerkerService();

var directeur = new Directeur("Klaas", "Kampen", 5000);
var schoonmaker = new Schoonmaker("Piet", "Almere", 2000);
var vrijwilliger = new Vrijwilliger("Jan", "Amsterdam");

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