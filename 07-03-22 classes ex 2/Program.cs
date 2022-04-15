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
                PuntenBoek Punten;
                do
                {
                    Console.WriteLine("Geef het punt in (OP 100)");
                    Punten = new PuntenBoek(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Wilt u nog punten toevoegen?(J/N)");
                } while (Console.ReadLine().ToUpper().Substring(0, 1) == "J");
                Console.WriteLine($"Het totaal procent is {Punten.TotaalProcent}");
            }
        }
    }
}
