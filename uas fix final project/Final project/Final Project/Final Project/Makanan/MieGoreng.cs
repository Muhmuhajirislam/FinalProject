using Final_Project.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Makanan
{
    public class MieGoreng : MenuMakanan
    {
        public override int Jumlah { get; set; }
        public double HargaMG { get; set; }
        public override double Harga()
        {
            return this.HargaMG;
        }
        public override int TotalHarga() => 12000 * this.Jumlah;
    }
}
