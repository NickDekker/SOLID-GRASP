namespace L.Models;

public class OudePrinter : IDrieInEenPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Print: {document}");
    }

    public void Scan(string document)
    {
        throw new NotImplementedException("Kan niet scannen!");
    }

    public void Kopieer(string document)
    {
        throw new NotImplementedException("Kan niet kopiëren!");
    }
}
