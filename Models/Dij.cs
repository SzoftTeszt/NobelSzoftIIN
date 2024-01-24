using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDij.Models
{
    internal class Dij
    {
        public int Id { get; set; }
        public int Ev { get; set; }
        public Fajta Tipus { get; set; }
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }

        public Dij(int ev, Fajta tipus, string keresztNev, string vezetekNev)
        {
            Ev = ev;
            Tipus = tipus;
            KeresztNev = keresztNev;
            VezetekNev = vezetekNev;
        }

        public Dij()
        {
        }

        public override string? ToString()
        {
            return Ev + "; " + Tipus + "; " + KeresztNev + " " + VezetekNev;
        }
    }
}
