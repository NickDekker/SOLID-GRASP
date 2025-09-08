namespace I.Models;

public interface IMachine
{
    void Print(string document);
    void Scan(string document);
    void Kopieer(string document);
}
