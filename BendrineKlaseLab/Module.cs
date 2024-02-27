using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendrineKlaseLab
{
    class Module:IComparable<Module>
    {
        public string ModuleName { get; set; }
        public string SurnameName { get; set; }
        public int Credits { get; set; }
        public Module() { }
        public Module(string mn, string sn, int c)
        {
            ModuleName = mn;
            SurnameName = sn;
            Credits = c;
        }

        public int CompareTo(Module other)
        {
            return SurnameName.CompareTo(other.SurnameName);
        }
        public override bool Equals(object obj)
        {
            Module temp = obj as Module;
            return temp.SurnameName == SurnameName;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
