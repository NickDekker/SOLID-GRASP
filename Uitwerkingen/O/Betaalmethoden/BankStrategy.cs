using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Betaalmethoden;

public class BankStrategy : IBetaalmethodeStrategy
{
    public string BetaalLoon(string naam, double brutoSalaris)
    {
        return $"{naam} krijgt {brutoSalaris} loon via de bank.";     
    }
}
