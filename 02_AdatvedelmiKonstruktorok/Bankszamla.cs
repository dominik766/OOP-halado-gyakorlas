using System;
using System.Collections.Generic;
using System.Text;

namespace _02_AdatvedelmiKonstruktorok
{
    internal class Bankszamla
    {
        private string szamlaszam;
        private double egyenleg;
        private double hitelKeret;
        public string Szamlaszam
        {
            get { return szamlaszam; }
        }
        public double Egyenleg
        {
            get { return egyenleg; }
        }
        public double HiteKeret
        {
            get { return hitelKeret; }
            set
            {
                if (value < 0)
                {
                    hitelKeret = 0;
                }
                else
                {
                    hitelKeret = value;
                }
            }
        }
        public Bankszamla(string beszamlaszam)
        {
            szamlaszam = beszamlaszam;
            this.egyenleg = 0;
            this.hitelKeret = 50000;
        }
        public Bankszamla(string beszamlaszam, double induloEgyenleg, double behitelKeret)
        {
            szamlaszam = beszamlaszam;
            egyenleg = induloEgyenleg;
            hitelKeret = behitelKeret;
        }
        public void Befizetes(double osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg = +osszeg;
            }
        }
        public bool Kivetel(double osszeg)
        {
            if (osszeg > 0)
            {
                if (egyenleg >= osszeg)
                {
                    egyenleg -= osszeg;
                    return true;
                }
            }
            return false;
        }
    }
}
