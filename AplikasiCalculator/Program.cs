using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Zulfikar Hakim Kurniawan
// 22.11.4927
// IF06


namespace CalculatorConsoleApp
{
    class program
    {

        static void Main(string[] args)
        {
            Console.Title = "AplikasiKalkulator";

            Console.WriteLine("Aplikasi Kalkulator");
            Console.WriteLine ("1.Penambahan");
            Console.WriteLine ("2.Pengurangan");
            Console.WriteLine ("3.Perkalian");
            Console.WriteLine ("4.Pembagian");

            Console.Write("Pilih Operasi yang ingin anda lakukan");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Penambahan");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Pengurangan");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Perkalian");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                        break;
                    }

                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Pembagian");
                        Console.Write("input a:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("input b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                        break;
                    }
            }

        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }



    }
}