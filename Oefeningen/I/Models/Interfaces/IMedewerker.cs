namespace I.Models.Interfaces;

public interface IMedewerker
{
    string Naam { get; }

    string Woonplaats { get; }

    double Salaris { get; }

    double GetBonus();

    double GetVakantiegeld();

    double GetDertiendeMaand();

    void UpdateSalaris(int percentage); 
}
