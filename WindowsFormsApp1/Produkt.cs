using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Produkt : Zbozi
    {
        string jmeno;
        double cena;

        public Produkt(string jmeno, int cena, DateTime Datum_vyroby) : base(jmeno, cena, Datum_vyroby)
        {
            this.jmeno = jmeno;
            this.cena = cena;
        }

        public override string Cena_DPH()
        {
            if(Splnuje_Trvanlivost() == true)
            {
                cena = double.Parse(base.Cena_DPH());
                return "Neni prosle a cena tak zustava" + cena.ToString();
            }
            else
            {
                double promena = double.Parse(base.Cena_DPH());
                cena = (promena - ((promena / 100) * 40));
                return "Zbozi je prosle a aena se proto snizuje na " + cena.ToString();
            }
        }

        public override string ToString()
        {
            return base.ToString() + Cena_DPH();
        }

    }
}
