using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Betaalmethoden;

public class ZwartStrategy : IBetaalmethodeStrategy
{
    public string BetaalLoon(string naam, double brutoSalaris)
    {
        var belastingKorting = brutoSalaris *= 1.3; 
        return $"{naam} krijgt {brutoSalaris + belastingKorting} zwart loon.";
    }
}
