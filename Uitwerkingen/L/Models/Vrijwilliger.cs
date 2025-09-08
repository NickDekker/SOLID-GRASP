using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Models;

public class Vrijwilliger : IOrganisatieLid
{
    public Vrijwilliger(string naam, string woonplaats)
    {
        Naam = naam;
        Woonplaats = woonplaats;
    }

    public string Naam { get; set; }

    public string Woonplaats { get; set; }
}
