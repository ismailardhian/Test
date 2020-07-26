using System;
namespace FinalProject.Interface
{
    public class Persegi : IBangunDatar
    {
        public int x;

        public void Luas()
        {
            Console.Write("Masukkan nilai sisi       = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi              = " + (x * x));
        }

        public void Keliling()
        {
            Console.WriteLine("Keliling Persegi          = " + (4 * x));
        }
    }
}
