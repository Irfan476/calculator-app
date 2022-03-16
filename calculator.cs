using System;

namespace CalculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char nomor;
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih menu kalkulator :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("Input nomor menu [1..4] : ");
            nomor = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            if ( nomor == '1')
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if ( nomor == '2')
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));

            }
            else if (nomor == '3')
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));

            }
            else if (nomor == '4')
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            }
            else
            {
                Console.WriteLine("Maaf menu yang Anda pilih tidak tersedia");
            }


            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
