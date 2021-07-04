using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metody
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Co jest większe 5 czy 3? {0}", FindMax(5,3));
            //Zamiana wartosći zmienneych
            int x = 100, y = -100;
            int[] tab = new int[3];

            Console.WriteLine("x,y:{0},{1}", x, y);

            Console.WriteLine("SwapVar(ref x, ref y, tab);");
            
            SwapVar(ref x, ref y, tab);
            Console.WriteLine("x,y,tab[0]:{0},{1},{2}",x,y,tab[0]);
            Console.ReadKey();
        }

        private static void SwapVar(ref int a, ref int b, int[] c)
        {
            int tmp = a;
            a = b;
            b = tmp;
            c[0] = 999;
        }

        static void DummyMethod()
        {

        }

        static int FindMax(int a, int b)
        {
            /*if (a < b)
                return a;
            else
                retu
            rn b;*/
            return (a > b) ? a : b;

        }
    }
}
