using S;
using S.Models;

/// In dit project gaat het om het Single responsibility principle (SRP).
/// 
/// OPDRACHT: Herschrijf de Medewerker-class zodanig dat deze aan dit principe voldoet.
/// De code moet wel hetzelfde resultaat geven.

var jan = new Medewerker("Jan", "Kampen", 5000);
jan.BetaalLoon();

Console.ReadLine();