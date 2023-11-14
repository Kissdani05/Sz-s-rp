using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp7;

namespace ConsoleApp7
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private int szuletesSzamlalo;

        

        public int getMagassag
        {
            get => default;
            set
            {
            }
        }

        public int GetSugar
        {
            get => default;
            set
            {
            }
        }

        public int SzuletesSzamlalo
        {
            get => default;
            set
            {
            }
        }
        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            SzuletesSzamlalo++;
        }
        public Henger(double sugar)
        : this(sugar, 1)
        {
        }
        public virtual double Terfogat()
        {
            return Math.PI * sugar * sugar * magassag;
        }

        public override string ToString()
        {
            return $"Henger: Sugar = {sugar:N2}, Magasság = {magassag:N2}, Térfogat = {Terfogat():N2}";
        }

    }
}