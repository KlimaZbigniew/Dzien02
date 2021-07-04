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

            string linia = "";

            linia = MakeLine(80);
            //linia.
            Console.WriteLine("FindMax(5,3);\n     Co jest większe 5 czy 3? {0}", FindMax(5, 3));
            int result;
            FindMaxOut(5, 3, out result);
            Console.WriteLine("FindMaxOut(5, 3, out result):");
            Console.WriteLine("     Co jest większe 5 czy 3? {0}\n\n", result);



            //Zamiana wartosći zmienneych
            int x = 100, y = -100;
            int[] tab = new int[3];

            Console.WriteLine("x,y:{0},{1}", x, y);

            Console.WriteLine("SwapVar(ref x, ref y, tab);");

            SwapVar(ref x, ref y, tab);

            

            Console.WriteLine("x,y,tab[0]:{0},{1},{2}", x, y, tab[0]);
            
            Console.WriteLine("{0}\n*\n* Wywołanie metody:\n*           private static void PrintData(string name, string lname, int age = 0, double salary = 0.0)\n*\n{0}", linia);
            PrintData("Jan", "Kowalski", 44, 5678);
            PrintData("Jan", "Kowalski");
            PrintData("Jan", "Kowalski",33);
            PrintData("Jan", "Kowalski", salary:5678, age:22);


            Console.ReadKey();
        }

        private static void TestMethod(int a)
        {

        }

        private static void TestMethod(int a, int b)
        {

        }

        private static void PrintData(string name, string lname, int age = 0, double salary = 0.0)
        {
            Console.WriteLine("{0} {1}, wiek={2}, zarobki={3}", name, lname, age, salary);
            
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
        static void FindMaxOut(int a, int b, out int c)
        {
            c = (a > b) ? a : b;
        }
        static string MakeLine(int ile)
        {
        string linia = "";
        for (int i = 0; i<ile; i++)			
            linia += "*";
            return linia;
        }

    }
}
