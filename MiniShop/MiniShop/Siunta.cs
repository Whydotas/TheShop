using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Siunta
    {
        public double SiuntosSvoris { get; set; }
        public char SiuntosDydis { get; set; }
        public double SiuntosKaina { get; protected set; }
        public string SiuntimoBudas { get; protected set; }
        public double SiuntimoKaina { get; protected set; }
        public double KrepselioKaina { get; set; }
        public Siunta(double siuntosSvoris, double krepselioKaina)
        {
            SiuntosSvoris = siuntosSvoris;
            KrepselioKaina = krepselioKaina;
         }
  
        public void SetSiuntosDydis()
        {
            var dydis = 'S';
            if (SiuntosSvoris <= 10)
            {
                dydis = 'S';
            }
            else if (SiuntosSvoris <= 50)
            {
                dydis = 'M';
            }
            else if (SiuntosSvoris > 50)
            {
                dydis = 'L';
            }

            SiuntosDydis = dydis;
        }

        public void SetSiuntimoBudas(string siuntimoBudas)
        {
            SiuntimoBudas = siuntimoBudas;
        }
        public void GetSiuntimoKaina()
        { var kaina = 0;

            if (SiuntimoBudas == "Siuntimas Lietuvoje:Paštu")
            {
                kaina = 10;
            }
            else if (SiuntimoBudas == "Siuntimas Lietuvoje:Kurjeris")
            {
                kaina = 20;
            }
            else if (SiuntimoBudas == "Siuntimas Lietuvoje:Paštomatas")
            {
                kaina = 30;
            }
            else if (SiuntimoBudas == "Tarptautinis Siuntimas")
            {
                kaina = 40;
            }
            else
            {
                kaina = 1337;
            }

            if (SiuntosDydis == 'S')
            {
                kaina *= 1;
            }
            else if (SiuntosDydis == 'M')
                {
                    kaina *= 2;
                }
            
            else if (SiuntosDydis == 'L')
                {
                    kaina *= 5;
                }
            SiuntimoKaina = kaina;
            }
        public void GetSiuntosKaina()
        {
            SiuntosKaina = SiuntimoKaina + KrepselioKaina;
        }
    }
}   

