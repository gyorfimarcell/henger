using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerek
{
    internal class Henger
    {
        static int szuletesSzamlalo = 0;

        double sugar;
        double magassag;

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo++;
        }

        public double GetSugar => sugar;
        public double GetMagassag => magassag;

        public static int SzuletesSzamlalo => szuletesSzamlalo;

        public virtual double Terfogat()
        {
            return Math.PI * Math.Pow(sugar, 2) * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(), 2)}; sugár:{sugar}; magasság:{magassag};";
        }
    }
}
