using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Models;

public class FiatPanda : IAuto
{
    public string Merk { get; set; }

    public int VermogenInPk { get; set; }
   
    public int HuidigeVersnelling { get; set; }
    
    public int AantalVersnellingen { get; set; }

    public IEnumerable<string> Bougies { get; set; }

    public int VullingTank { get; set; }

    public void Schakel(int nieuweVersnelling)
    {
       if(HuidigeVersnelling == nieuweVersnelling) { throw new InvalidOperationException(); }
       if(nieuweVersnelling > AantalVersnellingen || nieuweVersnelling < 0) { throw new InvalidOperationException(); }

        HuidigeVersnelling = nieuweVersnelling;
    }

    public void Tank(int liter, string brandstof)
    {
        VullingTank += liter; 
    }

    public void VervangBougies()
    {
        foreach(var item in Bougies)
        {
            string nieuweBougie = $"Bougie-{DateTime.Now}";         
        }
    }
}
