using O.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.Betaalmethoden;

public class BitcoinStrategy : IBetaalmethodeStrategy
{
    public string BetaalLoon(string naam, double brutoSalaris)
    {
        var aantalBitcoins = brutoSalaris / GetBitcoinKoers();
        return $"{naam} krijgt {aantalBitcoins} bitcoins.";
    }

    private double GetBitcoinKoers()
    {
        var random = new Random();
        return random.Next(10000, 100000);
    }
}
