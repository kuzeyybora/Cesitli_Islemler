using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Cesitli_Islemler
{
    class Operations
    {
        public static void Checker(out int number1, out int number2)
        {
            number1 = 0;
            number2 = 0;
            while (true)
            {
                Console.WriteLine("Lütfen birinci sayıyı girin veya çıkmak için 'exit' yazın:");
                string userInput1 = Console.ReadLine();

                if (userInput1.ToLower() == "exit")
                {
                    Console.WriteLine("Uygulamadan çıkılıyor...");
                    return;
                }

                if (!int.TryParse(userInput1, out number1))
                {
                    Console.WriteLine("Geçerli bir sayı girmediniz. Tekrar deneyin.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Lütfen ikinci sayıyı girin:");
                string userInput2 = Console.ReadLine();

                if (!int.TryParse(userInput2, out number2))
                {
                    Console.WriteLine("Geçerli bir sayı girmediniz. Tekrar deneyin.");
                    Console.WriteLine();
                    continue;
                }

                return;
            }
        }


        public static void Topla(int num1, int num2)
        {
            int toplam = num1 + num2;
            Console.WriteLine($"Toplam: {toplam}");
        }
        public static void Cikar(int num1, int num2)
        {
            int fark = num1 - num2;
            Console.WriteLine($"Fark: {fark}");
        }
        public static void Carp(int num1, int num2)
        {
            int carpim = num1 * num2;
            Console.WriteLine($"Çarpım: {carpim}");
        }
        public static void Bol(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Sıfıra bölme hatası. Bu nedenle sayı otomatik olarak 1 yapılmıştır.");
                num2 = 1;
            }
            int bolum = num1 / num2;
            Console.WriteLine($"Bölüm: {bolum}");
        }
        public static void UsAlma(int num1, int num2)
        {
            double usAlma = Math.Pow(num1, num2);
            Console.WriteLine($"Sonuç: {usAlma}");
        }
        public static void Karekok(int num1, int num2)
        {
            double karekok = num1 * Math.Sqrt(num2);
            string karekokIsareti = "\u221A";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"{num1}{karekokIsareti}{num2} Sonucu: {karekok}");
        }
        public static void Mod(int num1, int num2)
        {
            int mod = num1 % num2;
            Console.WriteLine($"Sonuç: {mod}");
        }
        public static void Mutlak(int num1, int num2)
        {
            int mutlak1 = Math.Abs(num1);
            int mutlak2 = Math.Abs(num2);
            Console.WriteLine($"Mutlak Değerler 1. {mutlak1} | 2. {mutlak2}");
        }
        public static void Faktoriyel(int num1, int num2)
        {
            long faktoriyel1 = 1;
            long faktoriyel2 = 1;
            for (int i = 1; i <= num1; i++)
            {
                faktoriyel1 *= i;
            }
            for (int i = 1; i <= num2; i++)
            {
                faktoriyel2 *= i;
            }
            Console.WriteLine($"Faktöriyel Sayılar 1. {faktoriyel1} | 2. {faktoriyel2}");
        }
    }
}
