using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat1 = new Prostokat(3, 4);
            prostokat1.ObliczPole();
            prostokat1.ObliczObwod();
            prostokat1.CzyKwadrat();

            Console.WriteLine("Pole: {0}", prostokat1.ObliczPole());

            Prostokat prostokat2 = new Prostokat(3);

            List<Prostokat> prostokaty = new List<Prostokat>();
            for (int i = 0; i < 10; i++)
            {
                prostokaty.Add(new Prostokat(i + 1, i + 2));
            }

            foreach (var p in prostokaty)
            {
                if (p.ObliczObwod() > 30)
                {
                    Console.WriteLine(p);
                }
            }


            Console.ReadKey();
        }
    }
}
