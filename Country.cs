using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanUppg3
{
    class Country
    {
            string Namn { get; set; }
            int AntalInvanare { get; set; }
            int BnpPerCapita { get; set; }
            List<City> Cities { get; set; }

            public Country(string namn, int antalinvanare, int bnppercapita)
            {
                this.Namn = namn;
                this.AntalInvanare = antalinvanare;
                this.BnpPerCapita = bnppercapita;
                listCreated();
            }
            private void listCreated()
            {
            Cities = new List<City>();
            }
    }
}

