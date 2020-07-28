using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class EsTeh : MenuMakanan
    {
        public override int Jumlah { get; set; }
        public double HargaET { get; set; }
        public override double Harga()
        {
            return this.HargaET;
        }
        public override int TotalHarga() => 3000 * this.Jumlah;
    }
}
