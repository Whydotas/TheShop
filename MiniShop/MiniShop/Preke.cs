using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
   public class Preke
    {
        public string Pav { get; }
        public double Kaina { get; }
        public double Svoris { get; }

        public Preke(string pav, double kaina, double svoris)
        {
            Pav = pav;
            Kaina = kaina;
            Svoris = svoris;
        }

    }
}
