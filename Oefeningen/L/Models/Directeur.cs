namespace L.Models
{
    public class Directeur : IMedewerker
    {
        public Directeur(string naam, string woonplaats, double salaris)
        {
            Naam = naam;
            Woonplaats = woonplaats;
            Salaris = salaris;
        }

        public string Naam { get; set; }

        public string Woonplaats { get; set; }

        public double Salaris { get; set; }


        public double BerekenSalaris()
        {
            Console.WriteLine($"Directeur krijgt {Salaris} en {Salaris / 2} bonus");
            return Salaris + Salaris / 2;
        }
    }
}
