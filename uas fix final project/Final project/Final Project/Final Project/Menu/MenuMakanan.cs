using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Menu
{
    public abstract class MenuMakanan
    {
        public string Nama { get; set; }
        public abstract int Jumlah { get; set; }
        public abstract double Harga();
        public abstract int TotalHarga();
    }
}
