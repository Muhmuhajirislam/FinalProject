using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class NasiGoreng : MenuMakanan
    {
         public override int Jumlah { get; set; }
        public double HargaNG { get; set; }
        public override double Harga()
        {
            return this.HargaNG;
        }
        public override int TotalHarga() => 15000 * this.Jumlah;

    }
}
