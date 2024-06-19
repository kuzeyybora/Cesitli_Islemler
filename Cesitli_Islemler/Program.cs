using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesitli_Islemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Operations.Checker(out number1, out number2);
            
            Console.Clear();
            Console.WriteLine("Her iki sayı da geçerli. Yapmak istediğiniz işlemi tuşlayın.");
            Console.WriteLine("1 - Topla | 2 - Çıkar | 3 - Carp | 4 - Bol | 5 - Üs Alma");
            Console.WriteLine("6 - Karekök | 7 - Mod Alma | 8 - Mutlak Değer | 9 - Faktöriyel");

            string operationChoice = Console.ReadLine();
            Console.Clear();
            switch (operationChoice)
            {
                case "1":
                    Operations.Topla(number1, number2);
                    break;
                case "2":
                    Operations.Cikar(number1, number2);
                    break;
                case "3":
                    Operations.Carp(number1, number2);
                    break;
                case "4":
                    Operations.Bol(number1, number2);
                    break;
                case "5":
                    Operations.UsAlma(number1, number2);
                    break;
                case "6":
                    Operations.Karekok(number1, number2);
                    break;
                case "7":
                    Operations.Mod(number1, number2);
                    break;
                case "8":
                    Operations.Mutlak(number1, number2);
                    break;
                case "9":
                    Operations.Faktoriyel(number1, number2);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
