using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Models;

public interface IMedewerker
{
    string Naam { get; }

    string Woonplaats { get; }

    double Salaris { get; }

    double BerekenSalaris();
}
