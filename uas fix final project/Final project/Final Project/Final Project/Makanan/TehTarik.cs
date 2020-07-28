using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class TehTarik : MenuMakanan
    {
        public override int Jumlah { get; set; }
        public double HargaTT { get; set; }
        public override double Harga()
        {
            return this.HargaTT;
        }
        public override int TotalHarga() => 5000 * this.Jumlah;
    }
}
