using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Models;

public interface IAuto
{
    public string Merk { get; set; }
    public int VermogenInPk { get; set; }
    public int HuidigeVersnelling { get; set; }
    public int AantalVersnellingen { get; set; }
    public int VullingTank { get; set; }

    void VervangBougies();
    void Tank(int liter, string brandstof);
    void Schakel(int nieuweVersnelling); 
}
