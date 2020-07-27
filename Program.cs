using System;
using System.Collections.Generic;
using System.Threading;
using UAS.Class_Anak;
using UAS.Class_Induk;

namespace UAS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bioskop> bioskop = new List<Bioskop>();

            Film_Batman3 film_Batman3 = new Film_Batman3();
            film_Batman3.NoTiket = "01";
            film_Batman3.NoKursi = "01";
            film_Batman3.HargaTiket = 45000;

            Film_Boruta500 film_Boruta500 = new Film_Boruta500();
            film_Boruta500.NoTiket = "02";
            film_Boruta500.NoKursi = "02";
            film_Boruta500.HargaTiket = 55000;

            Film_SpiderMan4 film_SpiderMan4 = new Film_SpiderMan4();
            film_SpiderMan4.NoTiket = "03";
            film_SpiderMan4.NoKursi = "03";
            film_SpiderMan4.HargaTiket = 50000;

            bioskop.Add(film_Batman3);
            bioskop.Add(film_Boruta500);
            bioskop.Add(film_SpiderMan4);

            Menu(bioskop);
        }

        static void Menu (List<Bioskop> bioskop)
        {
            bool status = true;

            do
            {
                Console.Clear();
                Console.WriteLine("");

                Console.WriteLine("Pilih Menu  : ");
                Console.WriteLine("1. Jadwal Film ");
                Console.WriteLine("2. Hapus Film ");
                Console.WriteLine("3. Tampilkan Data Film ");
                Console.WriteLine("4. Keluar ");

                Console.WriteLine("");

            Invalidpilion:
                string pill;
                Console.Write("Masukkan Pilihan  [1...4] : ");
                pill = Console.ReadLine();

                if (pill == "1")
                {
                    JadwalFilm(bioskop);
                    BalikMenu();
                }
                else if (pill == "2")
                {
                    HapusFilm(bioskop);
                    BalikMenu();
                }
                else if (pill == "3")
                {
                    TampilkanDataFilm(bioskop);
                    BalikMenu();
                }
                else if (pill == "4")
                {
                    Console.WriteLine("Terima Kasih");
                    Thread.Sleep(2000);
                    status = false;
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak Ada ");
                    goto Invalidpilion;
                }

            } while (status);
        }

        static void JadwalFilm(List<Bioskop> bioskop)
        {
            Console.Clear();
            Console.WriteLine(" Silahkan Pilih Jenis Film  :");
            Console.WriteLine("1. Film Batman 3 ");
            Console.WriteLine("2. Film Boruto 500 ");
            Console.WriteLine("3. Film SpiderMan 4 ");

        Invalidpilion:
            string pill;
            Console.Write("Masukkan Pilihan [1...3]  :");
            pill = Console.ReadLine();

            Console.WriteLine();

            if (pill == "1")
            {
                Film_Batman3 film_Batman3 = new Film_Batman3();

                Console.WriteLine("Masukkan Data");

                Console.Write("Masukkan Nomor Kursi \t\t: ");
                film_Batman3.NoKursi = Console.ReadLine();

                Console.Write("Masukkan Nomor Tiket \t\t: ");
                film_Batman3.NoTiket = Console.ReadLine();

                Console.Write("Masukkan Harga \t\t\t: Rp.");
                film_Batman3.HargaTiket = Convert.ToDouble(Console.ReadLine());

                bioskop.Add(film_Batman3);

            }
            else if (pill == "2")
            {
                Film_Boruta500 film_Boruta500 = new Film_Boruta500();

                Console.WriteLine("Masukkan Data");

                Console.Write("Masukkan Nomor Kursi \t\t: ");
                film_Boruta500.NoKursi = Console.ReadLine();

                Console.Write("Masukkan Nomor Tiket \t\t: ");
               film_Boruta500 .NoTiket = Console.ReadLine();

                Console.Write("Masukkan Harga \t\t\t: Rp.");
               film_Boruta500.HargaTiket = Convert.ToDouble(Console.ReadLine());

                bioskop.Add(film_Boruta500);
            }
            else if (pill == "3")
            {
                Film_SpiderMan4 film_SpiderMan4 = new Film_SpiderMan4();

                Console.WriteLine("Masukkan Data");

                Console.Write("Masukkan Nomor Kursi \t\t: ");
                film_SpiderMan4.NoKursi = Console.ReadLine();

                Console.Write("Masukkan Nomor Tiket \t\t: ");
                film_SpiderMan4.NoTiket = Console.ReadLine();

                Console.Write("Masukkan Harga \t\t\t: Rp.");
                film_SpiderMan4.HargaTiket = Convert.ToDouble(Console.ReadLine());

                bioskop.Add(film_SpiderMan4);
            }
            else
            {
                Console.WriteLine ("Pilihan Tidak Ada - Silahkan Masuk Lagi");
                goto Invalidpilion;
            }

        }

        static void HapusFilm (List<Bioskop > bioskop)
        {
            Console.Clear();

            Console.WriteLine("HAPUS DATA KARYAWAN");


            bool found = true;

            string nomortiket;
            Console.Write("\nMasukkan Nomor Tiket : ");
            nomortiket = Console.ReadLine();

            for (int i = 0; i < bioskop.Count; i++)
            {
                if (bioskop[i].NoTiket == nomortiket)
                {
                    bioskop.Remove(bioskop[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data dengan Nomor Tiket = {0} tidak ditemukan", nomortiket);
            }
            else
            {
                Console.WriteLine("Data dengan Nomor Tiket = {0} berhasil dihapus", nomortiket);
            }
        }

        static void TampilkanDataFilm(List<Bioskop > bioskop)
        {
            Console.Clear();

            Console.WriteLine(" NO | NOMOR TIKET  | NOMOR KURSI | HARGA \t |");
            for (int i = 0; i < bioskop.Count; i++)
            {
                Console.WriteLine(" {0}. | {1} \t   | {2} \t        | {3} \t |", i + 1, bioskop[i].NoTiket, bioskop[i].NoKursi, bioskop[i].Harga());
            }
        }

        static void BalikMenu()
        {
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu awal");
            Console.ReadKey();
        }
    }

}

