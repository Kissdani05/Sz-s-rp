using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp7;

namespace ConsoleApp7
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag)
            : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag)
            : this(sugar, magassag, 1)
        {
        }

        public override double Terfogat()
        {
            double belsőSugar = sugar - falVastagsag;
            return Math.PI * belsőSugar * belsőSugar * magassag;
        }

        public override string ToString()
        {
            return $"Cso: Sugar = {sugar:N2}, Magasság = {magassag:N2}, Falvastagság = {falVastagsag:N2}, Térfogat = {Terfogat():N2}";
        }
    }
}