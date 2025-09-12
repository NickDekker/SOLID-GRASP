using L.Models;
using L.Services;

/// In dit project gaat het om het Liskov substitution principle.
/// 
/// OPDRACHT: Draai deze code en zie hoe en waarom het misgaat. 
/// Hoe kan deze code herschreven worden zodat het wel werkt?

IDrieInEenPrinter nieuwePrinter = new NieuwePrinter();
var documentServiceMetNieuwePrinter = new DocumentService(nieuwePrinter);

documentServiceMetNieuwePrinter.VerwerkDocumentInAdministratie("Factuur.jpg");

IDrieInEenPrinter oudePrinter = new OudePrinter();
var documentServiceMetOudePrinter = new DocumentService(oudePrinter);

documentServiceMetOudePrinter.VerwerkDocumentInAdministratie("Factuur.jpg");

Console.ReadLine(); 