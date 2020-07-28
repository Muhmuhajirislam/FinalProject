using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class MieAyam : MenuMakanan
    {
        public override int Jumlah { get; set; }
        public double HargaMA { get; set; }
        public override double Harga()
        {
            return this.HargaMA;
        }
        public override int TotalHarga() => 12000 * this.Jumlah;
    }
}
