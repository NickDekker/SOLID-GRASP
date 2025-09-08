using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Betaalmethoden;

public class PayPalStrategy : IBetaalmethodeStrategy
{
    public string BetaalLoon(string naam, double brutoSalaris)
    {
        return $"{naam} krijgt {brutoSalaris - GetTransactieKostenVoorPaypal()} loon via de paypal.";
    }

    private double GetTransactieKostenVoorPaypal()
    {
        return 0.55; 
    }
}
