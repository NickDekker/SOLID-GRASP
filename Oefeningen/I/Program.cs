using I.Models;

/// In dit project gaat het om het interface segregation principle
/// 
/// OPDRACHT: 
/// 
/// Herschrijf de code zo dat je voldoet aan dit principe. 

IMachine nieuwePrinter = new NieuwePrinter();

nieuwePrinter.Scan("Foto.jpg");
nieuwePrinter.Print("Foto.jpg");
nieuwePrinter.Kopieer("Foto.jpg");

IMachine oudePrinter = new OudePrinter();

oudePrinter.Print("Foto.jpg");
oudePrinter.Scan("Foto.jpg");
oudePrinter.Kopieer("Foto.jpg");