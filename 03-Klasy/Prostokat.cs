using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Klasy
{
    class Prostokat
    {
        //Pola w klasie
        double bokA, bokB;
        public int test;

        public Prostokat(double bokA, double _bokB)
        {
            this.bokA = bokA;
            this.bokB = _bokB;
        }

        public Prostokat(double bokA)
        {
            this.bokA = bokA;
            this.bokB = bokA;
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public double ObliczObwod()
        {
            return 2 * bokA + 2 * bokB;
        }

        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }

        public string Print()
        {
            return string.Format("Bok a= {0}, Bok b= {1}", bokA, bokB);
        }
        public override string ToString()
        {
            return Print();
        }
    }
}
