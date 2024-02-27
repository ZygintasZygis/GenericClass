using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendrineKlaseLab
{
    public sealed class Mazgas<Tipas> where Tipas:IComparable<Tipas>
    {
        public Tipas Info { get; set; }
        public Mazgas<Tipas> Adress { get; set; }

        public Mazgas() { }

        public Mazgas(Tipas info, Mazgas<Tipas> adress)
        {
            this.Info = info;
            this.Adress = adress;
        }
    }
}
