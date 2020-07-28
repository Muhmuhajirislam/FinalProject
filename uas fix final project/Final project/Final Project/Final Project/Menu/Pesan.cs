using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Menu
{
    public abstract class Pesan
    {
        public string Nama { get; set; }
        public abstract int Jumlah { get; set; }
        public abstract int TotalHarga();

    }
}
