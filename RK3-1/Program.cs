using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            sayi = 5;
            //overflow olayı gerçekleşir, sonuç negatif değer alır
            sayi= int.MaxValue;
            sayi += 1;
            Console.WriteLine(sayi);

            //float vs double
            float sayi1 = 1.23456789f;
            double sayi2 = 1.23456789;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            //implicit( dolaylı dönüşüm ) küçük bir veri türünün, daha büyük bir veri türüne otomatik olarak dönüştürülmesi
            int sayi3 = 10;
            float yeniSayi = sayi3; //dolaylı dönüşüm

            //explicit (açık) dönüşüm veri kaybı yaşanabileceği durumlarda bunun açıkça belirtilmesi gerekir
            float pi = 3.14f;
            int yeniPi = (int)pi; //double dan int e açık dönüşüm

            //manuel tür dönüştürme
            double sayi4 = 9.8;
            int tamSayi = (int)sayi4; //double dan int e açık dönüşüm

            //convert sınıfı 
            string metin = "123";
            int sayi5 = Convert.ToInt32(metin); //string den int e dönüşüm

            //parse sınıfı
            string metin1 = "456";
            int sayi6 = int.Parse(metin1); //string den int e dönüşüm

            //örnek
            string rakamlar = "12345";
            char[] rakamListesi = rakamlar.ToCharArray();
            foreach (char rakam in rakamListesi)
            {
                Console.WriteLine(rakam); //her bir rakam ayrı ayrı yazdırılır
            }

            //örnek
            string paraDegeri = "123.45";
            decimal tutar = Convert.ToDecimal(paraDegeri);
            Console.WriteLine(tutar); //123.45 ??

            //örnek
            int a = 10;
            int b = 20;
            int toplam = a + b;
            string sonuc = Convert.ToString(toplam);
            Console.WriteLine("Toplam sonucu: {0}",sonuc);

            //örnek
            string tarihMetni = "2024-09-28";
            DateTime tarih = DateTime.Parse(tarihMetni);
            Console.WriteLine(tarih);

            //aritmetik operatörler 
            //kalanı bulurken
            int kalan = 9 % 2 ;
            a %= 3; // a nın 3 e bölümünden kalanı verir (mevcut değerin diğer değer ile modunu alır

            //örn
            int x = 5;
            x += 3;
            x -= 2;
            x *= 4;
            x /= 2;
            x %= 2;
            Console.WriteLine(x %= 2);

            int islemOnceligi = (5 + 3) * 2;
            Console.WriteLine(islemOnceligi);

            //karşılaştırma operatörleri
            int z = 5;
            int y = 10;
            Console.WriteLine("z:{0} y:{1}", z , y);
            if (z<y)
            {
                Console.WriteLine("z y den küçüktür");
            }
            if (z != y)
            {
                Console.WriteLine("z ve y eşit değildir");
            }

            if (z < y)
            {
                Console.WriteLine("z y den küçüktür");
            }
            else
            {
                Console.WriteLine("z y den küçük değildir");
            }

            // Mantıksal operatörler 
            bool t = true;
            bool f = false;

            if (t && f) { Console.WriteLine("bu satır yazılmaz çünkü f false"); }
            if (t || f) { Console.WriteLine("bu satır yazılır çünkü t true"); }
            if (!f) { Console.WriteLine("f false olduğu için bu satır yazılır"); }

            //bit düzeyinde operatörler 

            //uygulama1
            Console.WriteLine("uygulama 1");

            double saatlikUcret = 20.5;
            int calismaSaatleri = 40;
            int mesaiSaatleri = 5;
            double mesaiUcreti = saatlikUcret * 1.5;
            double toplamMaas = ( calismaSaatleri * saatlikUcret ) + (mesaiSaatleri * mesaiUcreti);
            Console.WriteLine("Toplam maaş: " + toplamMaas);

            //uygulama2
            Console.Write("Kilonuzu giriniz(kg):");
            double kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boyunuzu giriniz(m):");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bmi = kilo / (boy * boy);
            Console.WriteLine("Vücut kitle indeksiniz: " + bmi); 

            //uygulama 3
            Random rastgele = new Random();
            int tutulanSayi = rastgele.Next(0,101);

            int tahmin;
            do
            {
                Console.Write("Bir sayı tahmin edin (0-100)");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                }
                else if (tahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                }
            } while (tahmin != tutulanSayi);
            Console.WriteLine("Tebrikler!Doğru tahmin ettiniz.");

            Console.ReadLine(); 
        }
    }
}
