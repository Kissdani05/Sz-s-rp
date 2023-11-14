using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp7;

namespace ConsoleApp7
{
    public class TomorHenger : Henger
    {
        private double vasFajsuly;

        public TomorHenger(double sugar, double magassag, double vasFajsuly)
            : base(sugar, magassag)
        {
            this.vasFajsuly = vasFajsuly;
        }

        public TomorHenger(double sugar, double magassag)
            : this(sugar, magassag, 7.87)
        {
        }

        public override double Terfogat()
        {
            return base.Terfogat() - vasFajsuly;
        }

        public override string ToString()
        {
            return $"Tömör Henger: Sugar = {sugar:N2}, Magasság = {magassag:N2}, Vas Fajsúly = {vasFajsuly:N2}, Térfogat = {Terfogat():N2}";
        }
    }
}