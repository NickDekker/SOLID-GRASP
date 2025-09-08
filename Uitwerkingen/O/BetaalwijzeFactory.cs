using O.Betaalmethoden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O;

public class BetaalwijzeFactory
{
    public IBetaalmethodeStrategy GetBetaalwijze(string voorkeursBetaalwijze)
    {
        if (voorkeursBetaalwijze == "bank")
        {
            return new BankStrategy();
        }
        else if (voorkeursBetaalwijze == "zwart")
        {
            return new ZwartStrategy();
        }
        else if (voorkeursBetaalwijze == "bitcoin")
        {
            return new BitcoinStrategy(); 
        }
        else if(voorkeursBetaalwijze == "paypal")
        {
            return new PayPalStrategy();
        }

        throw new ArgumentException($"{voorkeursBetaalwijze} is niet mogelijk");
    }
}
