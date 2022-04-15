using System;
using System.Collections.Generic;
using System.Text;

namespace _07_03_22_classes_ex_2
{
    class PuntenBoek
    {
        private int punt;
        private int totaal;
        private int totaalprocent;
        private int i = 0;

        public int Punt
        {
            get { return punt; }  
            set { punt = value; } 
        }
        public int Totaal
        {
            get { return totaal; }
            set { totaal = value; }
        }
        public int TotaalProcent
        {
            get { return totaalprocent; }
            set { totaalprocent = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public PuntenBoek()
        {
            punt = 0;
            totaal = 0;
            totaalprocent = 0;
            i = 0;
        }

        public PuntenBoek(int IntPunten)
        {
            punt = IntPunten;
            totaal = totaal + punt;
            i++;
            totaalprocent = totaal / i;
        }
    }
}
