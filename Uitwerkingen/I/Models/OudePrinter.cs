namespace I.Models;

public class OudePrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Print: {document}");
    }
}
