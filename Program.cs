using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            PekerjaTetap pekerjaTetap = new PekerjaTetap();
            pekerjaTetap.Nik = "123-987-456";
            pekerjaTetap.Nama = "Heni Dauliah";
            pekerjaTetap.GajiBulanan = 5000000;

            PekerjaHarian pekerjaHarian = new PekerjaHarian();
            pekerjaHarian.Nik = "123-789-654";
            pekerjaHarian.Nama = "Devi Rahmawati";
            pekerjaHarian.JumlahJamKerja = 8;
            pekerjaHarian.UpahPerJam = 18000;

            Sales sales = new Sales();
            sales.Nik = "123-546-879";
            sales.Nama = "Fitri Mustika";
            sales.JumlahPenjualan = 20;
            sales.Komisi = 50000;

            List<Pekerja> listPekerja = new List<Pekerja>();

            listPekerja.Add(pekerjaTetap);
            listPekerja.Add(pekerjaHarian);
            listPekerja.Add(sales);

            int noUrut = 1;
            foreach (Pekerja pekerja in listPekerja)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, pekerja.Nik, pekerja.Nama, pekerja.Gaji());

                noUrut++;
            }
            Console.ReadKey();
        }
    }
}