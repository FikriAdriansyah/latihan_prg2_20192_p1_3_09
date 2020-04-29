using System;

namespace PRG2_20192_P1_3_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di program Cetak Syair");
            Console.Write("Silahkan masukkan jumlah anak ayam : ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nANAK AYAM TURUN {0}\n", N);
            for(int i = N; i >= 1; i--)
            {
                Console.Write("Anak ayam turun {0}", i);
                if (i > 1)
                {
                    Console.WriteLine(", mati satu tinggal {0}", i - 1);
                }
                else
                {
                    Console.WriteLine(", mati satu tinggal induknya");
                }
            }
        }
    }
}
