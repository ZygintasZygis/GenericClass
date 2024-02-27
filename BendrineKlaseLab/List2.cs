using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BendrineKlaseLab
{
    public sealed class List2<Tipas> where Tipas:IComparable<Tipas>
    {
        Mazgas<Tipas> Head;
        Mazgas<Tipas> Tail;
        Mazgas<Tipas> Current;

        public List2()
        {
            this.Head = null;
            this.Tail = null;
        }
        /// <summary>
        /// Puting elements directly to the Linked list(puting into the end)
        /// </summary>
        /// <param name="Info">object</param>
        public void PutTheInfoDirectly(Tipas Info)
        {
            if (Head == null)
            {
                Head = new Mazgas<Tipas>(Info, null);
                Tail = Head;
            }
            else
            {
                var A = new Mazgas<Tipas>(Info, null);
                Tail.Adress = A;
                Tail = A;
                
            }
            
        }
        public void Begining() { Current = Head; }
        public void Next() { Current = Current.Adress; }
        public bool IsRemaing() { return Current != null; }

        public Tipas TakeTheInfo() { return Current.Info; }

        /// <summary>
        /// finds the element in linked list that we need to delete
        /// </summary>
        /// <param name="info">object</param>
        /// <returns></returns>
        public Mazgas<Tipas> Place(Tipas info)
        {
            Mazgas<Tipas> d = null;
            for (Mazgas<Tipas> AAA = Head; AAA != null; AAA = AAA.Adress)
            {
                if (AAA.Info.CompareTo(info) == 0)
                {
                    d = AAA;
                    break;
                }
            }
            return d;
        }
        /// <summary>
        /// finds the place before the element we need to delete
        /// </summary>
        /// <param name="A">object</param>
        /// <returns></returns>
        public Mazgas<Tipas> PlaceBefore(Mazgas<Tipas> A)
        {
            if (A != Head)
            {
                Mazgas<Tipas> D;
                for (D = Head; D.Adress != A; D = D.Adress)
                    ;
                return D;
            }
            else
                return null;
        }
        /// <summary>
        /// deleting method
        /// </summary>
        /// <param name="info">object</param>
        public void Delete(Tipas info)
        {
            Mazgas<Tipas> A = Place(info);
            if (A == Head)
                A = A.Adress;
            else
            {
                Mazgas<Tipas> B = PlaceBefore(A);
                B.Adress = A.Adress;
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

    }
}
