using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Models
{
    public class Vertegenwoordiger : IMedewerker
    {
        public Vertegenwoordiger(string naam, string woonplaats, double salaris)
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
            Console.WriteLine($"Vertegenwoordiger krijgt {Salaris} en {Salaris / 4} leasebudget");
            return Salaris + Salaris / 4;
        }
    }
}
