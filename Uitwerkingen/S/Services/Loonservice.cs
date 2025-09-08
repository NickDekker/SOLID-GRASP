using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Services;

public class Loonservice
{
    public void BetaalLoon(string naam, double salaris)
    {
        var maand = DateTime.Now.Month;

        var uitTebetalen = salaris;

        if (maand == 5) // in mei Krijg je vakantiegeld
        {
            var vakantiegeld = uitTebetalen * 0.8;
            uitTebetalen += vakantiegeld;
        }

        Console.WriteLine($"Medewerker {naam} krijgt {uitTebetalen} euro salaris.");
    }
}
