
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final_Project.Menu;
using Final_Project.Makanan;
using System.IO;



namespace FinalProject
{
    class Program
    {
        //membuat list dgn objek baru yg mana nntinya akan menampung data menu yg dipilih untuk di pesan
        static List<MenuMakanan> listpesan = new List<MenuMakanan>();
        public static void Main(string[] args)
        {
            //perulangan untuk menampilkan menu
            bool loop = true;
            while (loop)
            {
                TampilMenu(); 
                Console.Write("\nPilih Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                //percabangan saat memilih program
                switch (nomorMenu)
                {
                    case 1:
                        //memanggil void makanan yg berisi daftar menu
                        Makanan();
                        break;
                    
                    case 2:
                        //memanggil void pesan untuk menyetak struk
                        Pesan();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf Menu Tidak Tersedia ");
                        break;
                }
            }
        }

        //menampilkan menu
        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("SELAMAT DATANG DI WARUNG MAKAN ENJOI");
            Console.WriteLine("====================================");
            Console.WriteLine("\tPILIHAN MENU");
            Console.WriteLine("[1] Daftar Menu \n[2] Daftar Pesanan(Struk) \n[3] Exit");
            Console.WriteLine("------------------------------------");
        }

        //menampung nama" makanan dan minuman serta untuk menampilkanny di daftar menu
        public static void Makanan()
        {
            //menambahkan data makanan serta minuman

            NasiGoreng nasigoreng = new NasiGoreng();
            nasigoreng.Nama = "Nasi Goreng";
            nasigoreng.HargaNG = 15000;

            MieGoreng miegoreng = new MieGoreng();
            miegoreng.Nama = "Mie Goreng ";
            miegoreng.HargaMG = 12000;

            Soto soto = new Soto();
            soto.Nama = "Soto Lamongan";
            soto.HargaS = 10000;

            MieAyam mieayam = new MieAyam();
            mieayam.Nama = "Mie Ayam ";
            mieayam.HargaMA = 12000;

            EsJeruk esjeruk = new EsJeruk();
            esjeruk.Nama = "Es jeruk";
            esjeruk.HargaEJ = 3000;

            EsTeh esteh = new EsTeh();
            esteh.Nama = "Es Teh";
            esteh.HargaET = 3000;

            TehTarik tehtarik = new TehTarik();
            tehtarik.Nama = "Teh Tarik ";
            tehtarik.HargaTT = 5000;

            //membuat list dgn 1 objek untuk menampung data menu
            List<MenuMakanan> listmakanan = new List<MenuMakanan>();

            //menambahkan semua data ke dalam objek dari list
            listmakanan.Add(nasigoreng);
            listmakanan.Add(miegoreng);
            listmakanan.Add(soto);
            listmakanan.Add(mieayam);
            listmakanan.Add(esteh);
            listmakanan.Add(esjeruk);
            listmakanan.Add(tehtarik);

        UpOrder:
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("\t\tDaftar Makanan ");
            Console.WriteLine("=====================================================");
            int no = 0;
            //perunglangan untuk menampilkan data menu yg disimpan
            foreach (MenuMakanan makanan in listmakanan)
            {
                no++;
                Console.WriteLine("{0} \t{1} \t\t\t\t{2}", no, makanan.Nama, makanan.Harga());
            }

            Console.Write("\nPilih Menu yang ingin dipesan [1..7]: ");
            int nomorMenu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");
            
            //percabangan saat memilih menu yg diinginkan
            switch (nomorMenu)
            {
                case 1:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    nasigoreng.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", nasigoreng.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(nasigoreng);

                    goto ReOrder;

                    break;

                case 2:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    miegoreng.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", miegoreng.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(miegoreng);

                    goto ReOrder;

                    break;

                case 3:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    soto.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", soto.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(soto);

                    goto ReOrder;

                    break;

                case 4:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    mieayam.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", mieayam.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(mieayam);

                    goto ReOrder;

                    break;

                case 5:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    esteh.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", esteh.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(esteh);

                    goto ReOrder;

                    break;

                case 6:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    esjeruk.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", esjeruk.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(esjeruk);

                    goto ReOrder;

                    break;

                case 7:
                    Console.Write("Masukkan Jumlah Pesanan\t: ");
                    tehtarik.Jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Harga\t\t\t: {0}", tehtarik.TotalHarga());

                    //menambahkan data ke list penampung data pesanan
                    listpesan.Add(tehtarik);

                    goto ReOrder;

                    break;

                default:
                    
                    Console.WriteLine("Maaf Menu Tidak Tersedia ");
                    break;
            }

            //proses untuk penambahan pesanan
        ReOrder:
            Console.WriteLine("Apakah ingin menambah Pesanan? (y/t):");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "Y":
                    goto UpOrder;
                    break;

                case "y":
                    goto UpOrder;
                    break;

                case "T":
                    TampilMenu();
                    break;

                case "t":
                    TampilMenu();
                    break;

                default:
                    break;
            }
        }

        //proses memesan sekaligus menyetak struk
        public static void Pesan()
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("\t\tMenu Yang Dipesan");
            Console.WriteLine("=====================================================");
            int no = 0;

            //perulangan untuk menampilkan data yg telah di pesan
            foreach (MenuMakanan pesan in listpesan)
            {
                no++;
                Console.WriteLine("{0}  {1} \t{2} \t\t{3} " ,no, pesan.Nama,pesan.Jumlah, pesan.TotalHarga());
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}