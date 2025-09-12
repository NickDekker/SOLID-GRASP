namespace L.Models;

public interface IDrieInEenPrinter
{
    void Print(string document);
    void Scan(string document);
    void Kopieer(string document);
}
