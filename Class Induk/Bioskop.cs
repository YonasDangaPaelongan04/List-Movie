using System;
using System.Collections.Generic;
using System.Text;

namespace UAS.Class_Induk
{
    public abstract class Bioskop
    {
        public string NoTiket;
        public string NoKursi;

        public abstract double Harga();
    }
}
