using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.AbstractClass;    // Menggunakan Abstract Class
//using FinalProject.Interface;      // Menggunakan Interface

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "APP PENGHITUNG BANGUN DATAR";
            BangunDatar bangundatar;    // Digunakan apabila menggunakan Abstract Class
          //IBangunDatar bangundatar; // Digunakan apabila menggunakan Interface

        menu:
            while (true)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("|| \t APP PENGHITUNG BANGUN DATAR \t ||");
                Console.WriteLine("===========================================");
                Console.WriteLine("Pilih Menu :");
                Console.WriteLine();
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Segitiga");
                Console.WriteLine("4. Kembali");

                Console.Write("\nPilihan: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilihan)
                {
                    case 1:
                        bangundatar = new Persegi();
                        bangundatar.Luas();
                        bangundatar.Keliling();
                        break;
                    case 2:
                        bangundatar = new PersegiPanjang();
                        bangundatar.Luas();
                        bangundatar.Keliling();
                        break;
                    case 3:
                        bangundatar = new Segitiga();
                        bangundatar.Luas();
                        bangundatar.Keliling();
                        break;
                }
                Console.WriteLine();
                if (pilihan == 4)
                {
                    Console.Clear();
                    goto menu;
                }
            }
        }
    }
}