using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerek
{
    internal class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double sugar, double magassag) : this(sugar, magassag, 7.87) {}

        public double GetFajsuly => fajsuly;
        public double Suly => fajsuly * Terfogat();

        public override string ToString()
        {
            return base.ToString() + $" fajsúly {fajsuly}";
        }
    }
}
