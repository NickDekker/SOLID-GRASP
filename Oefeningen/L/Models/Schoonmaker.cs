namespace L.Models
{
    public class Schoonmaker : IMedewerker
    {
        public Schoonmaker(string naam, string woonplaats, double salaris)
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
            Console.WriteLine($"Schoonmaker krijgt {Salaris}");
            return Salaris;
        }
    }
}
