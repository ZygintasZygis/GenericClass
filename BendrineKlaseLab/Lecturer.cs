using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendrineKlaseLab
{
    class Lecturer:IComparable<Module>,IComparable<Lecturer>,IEquatable<Lecturer>
    {
        public string SurnameName { get; set; }
        public int HowMany { get; set; }

        public Lecturer(string sr = "", int hm = 0)
        {
            SurnameName = sr;
            HowMany = hm;
        }

        public int CompareTo(Module other)
        {
            return SurnameName.CompareTo(other.SurnameName);
        }

        public int CompareTo(Lecturer other)
        {
            return SurnameName.CompareTo(other.SurnameName);
        }

        public bool Equals(Lecturer other)
        {
            return SurnameName == other.SurnameName;
        }
    }
}
