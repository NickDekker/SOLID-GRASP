using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Betaalmethoden;

public interface IBetaalmethodeStrategy
{
    string BetaalLoon(string naam, double brutoSalaris); 
}
