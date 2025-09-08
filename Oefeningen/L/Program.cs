using L.Models;
using L.Services;

/// In dit project gaat het om het Liskov substitution principle.
/// 
/// OPDRACHT: Draai deze code en zie hoe en waarom het misgaat. 
/// Hoe kan deze code herschreven worden zodat het wel werkt?

var medewerkers = new List<IMedewerker>
{
    new Directeur("Klaas", "Almere", 8000),
    new Vertegenwoordiger("Peter", "Dronten", 9000),
    new Schoonmaker("Freek", "Kampen", 2500),
    new Vrijwilliger("Janneke", "Zwolle")
};

foreach (var medewerker in medewerkers)
{
    LoonService.Betaal(medewerker); 
}

Console.ReadLine();