using O;
using O.Models;
using O.Services;

/// In dit project gaat het om het open/closed-principle (OCP).
/// 
/// OPDRACHT: voeg een betaalmethode PayPal toe aan de loonservice. 
/// Zorg ervoor dat je de bestaande code niet hoeft aan te raken OF je loonservice zo herschrijft
/// dat de bestaande functionaliteit in de toekomst niet meer hoeft te worden aangeraakt (bijv. als
/// er na PayPal nog een betaalmethode bij komt.


var klaas = new Medewerker("Klaas", "Kampen", 5000);

var loonService = new LoonService();

loonService.BetaalLoon(klaas, "bitcoin");

Console.ReadLine(); 