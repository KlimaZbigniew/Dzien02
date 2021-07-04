﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArreyOper();
            ListOper();

            Console.ReadKey();
        }

        //Operacje na lisatch
        private static void ListOper()
        {
            Console.WriteLine("Operacje na listach:");
            ArrayList listaImion = new ArrayList();
            listaImion.Add("Adam");
            listaImion.Add(10);
            listaImion.Add(false);
            listaImion.Add(-123.45);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);                        
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Add(new int[5]);
            listaImion.Insert(1,true);
            listaImion.RemoveAt(0);
            listaImion.Remove(10);
            Console.WriteLine("Lista elementów (listaImion.Count): " + listaImion.Count + ", pojemność (listaImion.Capacity): " + listaImion.Capacity );
        }

        //Operacje na tablicach
        private static void ArreyOper()
        {
            //inicjalizacja tablicy
            int[] stawkiVAT = new int[10]; //deklaracja 10 elementowej tablicy typu int
            stawkiVAT[0] = 8;
            stawkiVAT[9] = 23;
            //stawkiVAT[999] = 0; //Index out of range

            int[] oceny1 = new int[6] { 1, 2, 3, 4, 5, 6 };// Przypisanie wartosci do tablicy
            int[] oceny2 = new int[] { 1, 2, 3, 4, 5, 6 };// Przypisanie wartosci do tablicy

            Console.WriteLine("Liczba elementów oceny2: " + oceny2.Length);

            for (int i = 0; i < oceny2.Length; i++)
            {
                Console.Write(oceny2[i] + ",");
            }
            Console.WriteLine();


            foreach (var item in oceny2)
            {
                Console.Write(  item + ",");
            }

            Console.WriteLine();

            //Kloniawnia tablic
            int[] oceny3 = (int[])oceny1.Clone();

            oceny3[0] = 99;
            Console.WriteLine("Oceny1: ");
            foreach (var item in oceny1)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("Oceny3: ");
            foreach (var item in oceny3)
            {
                Console.Write(item + ",");
            }

            //Modyfikacja wielkości tablicy po jej modyfikacji.
            //Kopiowanie tablic

            int[] oceny2a = new int[30];

            Array.Copy(oceny2, 0, oceny2a, 9, oceny2.Length);
            Console.WriteLine();            
            Console.WriteLine("Array.Copy(oceny2, 0, oceny2a, 9, oceny2.Length);");
            Console.WriteLine("Oceny2a: ");
            foreach (var item in oceny2a)
            {
                Console.Write(item + ",");
            }

            //Tablica wierowymiarowa
            Console.WriteLine();
            Console.WriteLine("Tablice wierowymiarowe:");

            int[,] macierz1 = new int[3,4];
            int[,] macierz2 = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}

            };

            Console.WriteLine();
            Console.WriteLine("Iteracja po macierzy:");
            string prefix = "";
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {

                    macierz2[i, k] *= 2;
                    if (macierz2[i, k] < 10)
                        prefix = " ";
                    else
                        prefix = "";
                    Console.Write(prefix + macierz2[i, k] + "| ");
                }
                Console.WriteLine();
                Console.WriteLine("--+---+---+---+");
            }


/*            foreach (var wiersz in macierz2)
            {
                foreach (var kolumna in collection)
                {

                }

            };*/


        }
    }
}
