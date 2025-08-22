using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Vücut Kitle İndeksi Hesaplama ===");
            Console.Write("Lütfen kilonuzu (kg) giriniz : ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen boyunuzu (m) giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bmi = kilo / (boy * boy);
            string durum;
            //<>
            if (bmi <= 18.5)
            {
                durum = "Zayıf";
                Console.WriteLine($"BMI değeriniz :{bmi}");
                Console.WriteLine($"Durumunuz :{durum}");
                Console.WriteLine("Kilo Almalısınız.");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                durum = "Normal";
                Console.WriteLine($"BMI değeriniz :{bmi}");
                Console.WriteLine($"Durumunuz :{durum}");
                Console.WriteLine("Kilonuzu sabit tutmalısınız.");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                durum = "Fazla Kilolu";
                Console.WriteLine($"BMI değeriniz :{bmi}");
                Console.WriteLine($"Durumunuz :{durum}");
                Console.WriteLine("Kilo vermelisiniz.");
            }
            else if (bmi >= 30)
            {
                durum = "Obez";
                Console.WriteLine($"BMI değeriniz :{bmi}");
                Console.WriteLine($"Durumunuz :{durum}");
                Console.WriteLine("Acilen kilo vermelisiniz.");
            }

        }
    }
}
