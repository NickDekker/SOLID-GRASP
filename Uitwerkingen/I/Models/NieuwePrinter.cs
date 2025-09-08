namespace I.Models;

public class NieuwePrinter : IDrieInEenPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Print: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scan: {document}");
    }

    public void Kopieer(string document)
    {
        Console.WriteLine($"Kopieer: {document}");
    }
}
