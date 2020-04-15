using System;

namespace ResponsiPemrograman2906
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(190302107, "Ronaldo", 40000000);
            Karyawan karyawan2 = new Karyawan(190302109, "Benzema", 35000000);


            Console.WriteLine("NIK \t\t Nama \t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n 10% KENAIKAN GAJI!!!\n");

            Console.WriteLine("NIK \t\t Nama \t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan.kenaikan();
            karyawan2.kenaikan();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int Nik, string Nama, int gaji)
        {
            this.Nik = Nik;
            this.Nama = Nama;

            if(gaji < 0)
            {
                this.GajiBulanan = 0;
            } else
            {
                this.GajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }

        public void kenaikan()
        {
            double tmp = 0;
            tmp =  0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }
    }
}