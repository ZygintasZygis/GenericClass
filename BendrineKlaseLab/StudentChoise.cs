using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendrineKlaseLab
{
    class StudentChoise:IComparable<StudentChoise>
    {
        public string ModuleName { get; set; }
        public string StudentSurnameName { get; set; }
        public string StudentGroup { get; set; }

        public StudentChoise() { }

        public StudentChoise(string mn, string ssn, string sg)
        {
            ModuleName = mn;
            StudentSurnameName = ssn;
            StudentGroup = sg;
        }

        public int CompareTo(StudentChoise other)
        {
            throw new NotImplementedException();
        }
    }
}
