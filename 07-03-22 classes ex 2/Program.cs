using System;
using System.Collections;
using System.Collections.Generic;

namespace _07_03_22_classes_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                PuntenBoek Punt;
                List<PuntenBoek> Punten = new List<PuntenBoek>();
                do
                {
                    Punt = new PuntenBoek();



                    Console.WriteLine("Wilt u nog punten toevoegen?(J/N)");
                } while (Console.ReadLine().ToUpper().Substring(0, 1) == "J");

            }
        }
    }
}
