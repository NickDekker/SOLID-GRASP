using S;
using S.Models;
using S.Services;

/// In dit project gaat het om het Single responsibility principle (SRP).
/// 
/// OPDRACHT: Herschrijf de Medewerker-class zodanig dat deze aan dit principe voldoet.

var loonService = new Loonservice(); 

var jan = new Medewerker("Jan", "Kampen", 5000);

loonService.BetaalLoon(jan.Naam, jan.Salaris); 

Console.ReadLine(); 