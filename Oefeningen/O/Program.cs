using O;
using O.Models;
using O.Services;

/// In dit project gaat het om het open/closed-principle (OCP).
/// 
/// OPDRACHT: 
/// 
/// 1. Herschrijf de loonservice eerst volgens de OCP-principes. Verifieer dat alles nog werkt als voorheen.
/// 2. Voeg daarna de betaalmethode paypal toe. Als het goed is hoef je de loonservice zelf nu niet meer aan te passen.
/// 3. Voeg een nieuwe medewerker toe met voorkeursbetalingswijze "paypal". 

var loonService = new LoonService();


var medewerkers = new Medewerker[]
{
   new Medewerker("Klaas", "Kampen", 5000, "bank"),
   //new Medewerker("Klaas", "Almere", 2000, "paypal)
};

foreach (var medewerker in medewerkers)
{
    var result = loonService.BetaalLoon(medewerker);

    Console.WriteLine(result);
}

Console.ReadLine();