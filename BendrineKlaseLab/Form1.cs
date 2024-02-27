using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BendrineKlaseLab
{
    public partial class Form1 : Form
    {
        const string file1 = "..\\..\\U1a.txt";
        const string file2 = "..\\..\\U1b.txt";
        const string file3 = "..\\..\\result.txt";
        List2<StudentChoise> StudentChoises = new List2<StudentChoise>();
        List2<Module> ModuleInfo = new List2<Module>();
        List<string> ChosenModules = new List<string>();
        List2<Lecturer> Lecturers = new List2<Lecturer>();
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(file3))
                File.Delete(file3);
            
        }

        private void ivestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChoises = ReadInfo(file1);
            ModuleInfo = ReadInfo2(file2);
            duomenys1.LoadFile(file1, RichTextBoxStreamType.PlainText);
            duomenys2.LoadFile(file2, RichTextBoxStreamType.PlainText);
        }
        static List2<StudentChoise> ReadInfo(string file)
        {
            var B = new List2<StudentChoise>();
            using (var reader = new StreamReader(file))
            {
                string Line;
                while((Line = reader.ReadLine()) != null)
                {
                    string[] Parts = Line.Split(';');
                    string ModuleName = Parts[0];
                    string StudentName = Parts[1];
                    string Group = Parts[2];
                    StudentChoise SC = new StudentChoise(ModuleName, StudentName, Group);
                    B.PutTheInfoDirectly(SC);
                }
            }
            return B;
        }
        static List2<Module> ReadInfo2(string file)
        {
            var B = new List2<Module>();
            using (var reader = new StreamReader(file))
            {
                string Line;
                while ((Line = reader.ReadLine()) != null)
                {
                    string[] Parts = Line.Split(';');
                    string ModuleName = Parts[0];
                    string LecturerName = Parts[1];
                    int Credits = int.Parse(Parts[2]);
                    Module SC = new Module(ModuleName, LecturerName, Credits);
                    B.PutTheInfoDirectly(SC);
                }
            }
            return B;
        }
        //static List<Lecturer> PickOut(List2<Module> A)
        //{
        //    List<Lecturer> list = new List<Lecturer>();
        //    for(A.Begining(); A.IsRemaing(); A.Next())
        //    {
        //        Module temp = A.TakeTheInfo();

        //        bool foundLect = false;
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i].SurnameName == temp.SurnameName)
        //            {
        //                list[i].Module.Add(temp.ModuleName);
        //                foundLect = true;
        //                break;
        //            }

        //        }

        //        if (!foundLect)
        //        {
        //            list.Add(new Lecturer(temp.SurnameName, new List<string>()));
        //            list[list.Count - 1].Module.Add(temp.ModuleName);
        //        }
        //    }
        //    return list;
        //}

        /// <summary>
        /// returns the list of modules that students have chosen
        /// </summary>
        /// <param name="choices">List of student choices</param>
        /// <returns></returns>
        static List<string> GetChosenModules(List2<StudentChoise> choices)
        {
            List<string> list = new List<string>();
            for(choices.Begining();choices.IsRemaing();choices.Next())
            {
                string temp = choices.TakeTheInfo().ModuleName;
                list.Add(temp);
            }
            return list;
        }
        //static List<Lecturer> Removing(List<Lecturer> A, List<string> B)
        //{
        //    for(int i = 0; i < A.Count; i++)
        //    {
        //        List<string> clModules = A[i].Module;

        //        bool found = false;

        //        for (int j = 0; j < clModules.Count; j++)
        //        {
        //            if (B.Contains(clModules[j]))
        //            {
        //                found = true;
        //                break;
        //            }
        //        }

        //        if (!found)
        //        {
        //            //A.RemoveAll(x => x.SurnameName == A[i].SurnameName);
        //            A.RemoveAt(i);
        //        }
        //    }
        //    return A;
        //}

        /// <summary>
        /// Method that deletes elements from the linked list
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        static void Removing2(List2<Module> A, List<string> B)
        {
            for(A.Begining();A.IsRemaing();A.Next())
            {
                Module temporary = A.TakeTheInfo();
                if (!B.Contains(temporary.ModuleName))
                {
                    A.Delete(temporary);
                }
                    
            }
        }
        //static string Lecturer(List2<Module> A)
        //{
        //    int maxcount = -1;
        //    string lect = "";
        //    //List<string> LecturersSurnameName = new List<string>();
        //    for (A.Begining();A.IsRemaing();A.Next())
        //    {
        //        Module temp = A.TakeTheInfo();
        //        if (A[i].Module.Count > maxcount)
        //        {
        //            maxcount = A[i].Module.Count;
        //            lect = A[i].SurnameName;
        //        }
        //        //if (A[i].Module.Count == maxcount)
        //        //    LecturersSurnameName[i] = A[i].SurnameName;
        //    }

        //    return lect;
        //}

        /// <summary>
        /// Method that picks out all the lecturers and modules they are responsible for
        /// </summary>
        /// <param name="A">list of modules and lecturers</param>
        /// <returns></returns>
        static List2<Lecturer> LecturersFromModules(List2<Module> A)
        {
            List2<Lecturer> List = new List2<Lecturer>();
            for(A.Begining();A.IsRemaing();A.Next())
            {
                Module module = A.TakeTheInfo();
                Lecturer l = new Lecturer(module.SurnameName,0);
                var p = List.Place(l);
                if (p == null)
                {
                    List.PutTheInfoDirectly(new Lecturer(module.SurnameName, 1));
                }
                else
                {
                    p.Info.HowMany += 1;
                }
            }
            return List;
 
        }
        /// <summary>
        /// finds the biggest amount of modules having lecturer
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static List2<Lecturer> MostModules(List2<Lecturer> A)
        {
            List2<Lecturer> B = new List2<Lecturer>();
            int count = 0;
            int maxcount = -1;
            for(A.Begining();A.IsRemaing();A.Next())
            {
                Lecturer lect = A.TakeTheInfo();
                if (maxcount == -1)
                {
                    B.PutTheInfoDirectly(lect);
                    maxcount = lect.HowMany;
                    count = 1;
                }
                else if(lect.HowMany == maxcount)
                {
                    B.PutTheInfoDirectly(lect);
                }
                else if(lect.HowMany > maxcount)
                {
                    B.Clear();
                    maxcount = lect.HowMany;
                    B.PutTheInfoDirectly(lect);
                }
            }
            return B;
        }

        private void spausdintiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChosenModules = GetChosenModules(StudentChoises);
            Lecturers = LecturersFromModules(ModuleInfo);
            Print3(file3, StudentChoises, "Studentu pasirinkti moduliai");
            Print2(file3, ModuleInfo, "Destytoju sarasas");
            Print(file3, Lecturers, "Suformuotas destytoju sarasas be pasikartojimu");
            rezultatai.LoadFile(file3, RichTextBoxStreamType.PlainText);
        }
        static void Print(string fv, List2<Lecturer> A, string coment)
        {
            using (StreamWriter writter = File.AppendText(fv))
            {
                writter.WriteLine(coment);
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|");
                writter.WriteLine("|           Modulio pavadinimas              | Atsakingo destytojo pavarde ir vardas   |");
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|");
                for (A.Begining();A.IsRemaing();A.Next())
                {
                    Lecturer let = A.TakeTheInfo();
                    writter.WriteLine("| {0, -42} | {1, -39} |", let.SurnameName, let.HowMany);
                }
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|");
                writter.WriteLine();
            }
        }
        static void Print2(string fv, List2<Module> A, string coment)
        {
            using (StreamWriter writter = File.AppendText(fv))
            {
                writter.WriteLine(coment);
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|--------------------|");
                writter.WriteLine("|           Modulio pavadinimas              | Atsakingo destytojo pavarde ir vardas   |   Kreditu kiekis   |");
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|--------------------|");
                for (A.Begining(); A.IsRemaing(); A.Next())
                {
                    Module module = A.TakeTheInfo();
                    writter.WriteLine("| {0, -42} | {1, -39} | {2,-18:d} |", module.ModuleName, module.SurnameName, module.Credits);
                }
                writter.WriteLine("|--------------------------------------------|-----------------------------------------|--------------------|");
                writter.WriteLine();
            }
        }
        static void Print3(string fv, List2<StudentChoise> A, string coment)
        {
            using (StreamWriter writter = File.AppendText(fv))
            {
                writter.WriteLine(coment);
                writter.WriteLine("|--------------------------------------------|------------------------------|--------------------|");
                writter.WriteLine("|           Modulio pavadinimas              | Studento pavarde ir vardas   |        Grupe       |");
                writter.WriteLine("|--------------------------------------------|------------------------------|--------------------|");
                for (A.Begining(); A.IsRemaing(); A.Next())
                {
                    StudentChoise module = A.TakeTheInfo();
                    writter.WriteLine("| {0, -42} | {1, -28} | {2, -18} |", module.ModuleName, module.StudentSurnameName, module.StudentGroup);
                }
                writter.WriteLine("|--------------------------------------------|------------------------------|--------------------|");
                writter.WriteLine();
            }
        }
        private void salinimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Removing2(ModuleInfo, ChosenModules);
            Print(file3, LecturersFromModules(ModuleInfo), "Po pasalinimo");
            Print2(file3, ModuleInfo, "Sarasas po pasalinimo.");
            rezultatai.LoadFile(file3, RichTextBoxStreamType.PlainText);
        }

        private void daugiausiaiTurintisModuliuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List2<Lecturer> A = LecturersFromModules(ModuleInfo);
            List2<Lecturer> B = MostModules(A);
            using (StreamWriter writter = File.AppendText(file3))
            {
                for (B.Begining(); B.IsRemaing(); B.Next())
                {
                    writter.WriteLine("Daugiausiai moduliu turintis destytojas: {0} - {1}", B.TakeTheInfo().SurnameName, B.TakeTheInfo().HowMany);
                }
            }
            rezultatai.LoadFile(file3, RichTextBoxStreamType.PlainText);

        }
    }
}
