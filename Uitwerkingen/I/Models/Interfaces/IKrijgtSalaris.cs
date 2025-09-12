namespace I.Models.Interfaces;

public interface IKrijgtSalaris
{
    double Salaris { get; }

    double GetVakantiegeld();

    void UpdateSalaris(int percentage);
}
