using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class Soto : MenuMakanan
    {
        public override int Jumlah { get; set; }
        public double HargaS { get; set; }
        public override double Harga()
        {
            return this.HargaS;
        }
        public override int TotalHarga() => 10000 * this.Jumlah;
    }
}
