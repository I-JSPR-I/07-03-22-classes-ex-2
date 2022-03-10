using System;
using System.Collections.Generic;
using System.Text;

namespace _07_03_22_classes_ex_2
{
    class PuntenBoek
    {
        public int Punt;
        public int totaal;
        public int i = 0;
        public PuntenBoek()
        {
            Punt = 0;
            totaal = 0;
            i = 0;
        }

        public PuntenBoek(int IntPunten)
        {
            Punt = IntPunten;
            totaal = totaal + Punt;
            i++;

        }
    }
}
