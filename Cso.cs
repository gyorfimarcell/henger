using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerek
{
    internal class Cso : Henger
    {
        double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag) : this(sugar, magassag, 1) {}

        public Cso(double sugar, double magassag, double falVastagsag, double valami) : this(sugar, magassag, falVastagsag * valami) {}

        public double FalVastagsag => falVastagsag;

        public override double Terfogat()
        {
            return base.Terfogat() - (Math.PI * Math.Pow(GetSugar - falVastagsag, 2) * GetMagassag);
        }

        public override string ToString()
        {
            return base.ToString() + $"; falvastagsága:{falVastagsag}";
        }
    }
}
