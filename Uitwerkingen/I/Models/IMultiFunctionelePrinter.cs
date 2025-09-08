namespace I.Models;

public interface IDrieInEenPrinter : IPrinter
{
    void Kopieer(string document);
    void Scan(string document);
}
