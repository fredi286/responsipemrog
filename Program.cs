using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk2631
{
    class Program
    {
        static List<Produk> DaftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int noMenu = Convert.ToInt32(Console.ReadLine());

                switch (noMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Produk");
            Console.Write("\nKode Produk : ");
            produk.KodeProduk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            produk.NamaProduk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.HargaBeli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.HargaJual = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int nomer = -1, hapus = -1;
            Console.WriteLine("Hapus Produk");
            Console.Write("Kode Produk : ");
            string code = Console.ReadLine();
            foreach (Produk produk in DaftarProduk)
            {
                nomer++;
                if(produk.KodeProduk == code)
                {
                    hapus = nomer;
                }
            }
            if (hapus != -1)
            {
                DaftarProduk.RemoveAt(hapus);
                Console.WriteLine("Produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int NomerUrut = 0;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in DaftarProduk)
            {
                NomerUrut++;
                Console.WriteLine("{0}. Kode Produk: {1}, Nama Produk: {2}, Harga Beli: {3}, Harga Jual: {4}", NomerUrut, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
            }
            if (NomerUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
