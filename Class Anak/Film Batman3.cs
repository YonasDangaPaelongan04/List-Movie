using System;
using System.Collections.Generic;
using System.Text;
using UAS.Class_Induk;

namespace UAS.Class_Anak
{
    public class Film_Batman3 : Bioskop
    {
        public double HargaTiket;

        public override double Harga()
        {
            return this.HargaTiket;
        }
    }
}
