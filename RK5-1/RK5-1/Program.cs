using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }*/


            /*int sayi;
            while (true)
            {
                Console.WriteLine("Pozitif bir sayı giriniz (negatif çıkış):");
                sayi =Convert.ToInt32(Console.ReadLine());
                if (sayi < 0) 
                {
                    Console.WriteLine("Negatif sayı girildi. Döngü sonlandırılıyor.");
                    break;
                }
            }  */


            /*int x = 0;
            while (x < 10)
            {
                if (x == 5)
                {
                    break;
                }
                Console.WriteLine(x);
                x++;
            }*/


            /*-int y = 0;
            while (y<10)
            {
                y++;
                if (y % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(y);
            }*/
            /*
            int satirSayisi = 5;
            int i = 1;

            while (i <= satirSayisi) 
            {
                int j = 1;
                while (j <= i) 
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            int x = 1;

            while (x >= satirSayisi)
            {
                int y = 5;
                while (y >= x)
                {
                    Console.Write("*");
                    y--;
                }
                Console.WriteLine();
                x++;
            }
            */

            /*
            int secim;
            do
            {
                Console.WriteLine("1- Yeni Oyun");
                Console.WriteLine("2 - Ayarlar");
                Console.WriteLine("3 - Çıkış");
                Console.WriteLine("Seçiminizi Yapınız (1-3)");
                secim = Convert.ToInt32(Console.ReadLine());
            } while (secim < 1 || secim > 3);
            Console.WriteLine("Seçiminiz: " + secim);

            */

            /*
            string cardNumber;
            do
            {
                Console.Write("Kredi kartı numarasını giriniz (16 haneli)");
                cardNumber = Console.ReadLine();

                if (cardNumber.Length != 16)
                {
                    Console.WriteLine("Hatalı kart numarası, lütfen 16 haneli sayı giriniz.");
                }
            } while (cardNumber.Length == 16);
            Console.WriteLine("başaroyla tamamlandı");   */


            /*
            int x = 0;
            do
            {
                Console.WriteLine("x değeri:" + x);
                x++;
                if (x == 3) { break; }
            } while (x < 10);   */

            /*
            int y = 0;
            do
            {
                y++;
                if (y % 2 == 0) { continue; }
                Console.WriteLine(y);
                Console.ReadLine();
            } while (y < 10);  */


            /*
            int secim;
            do
            {
                Console.WriteLine("Dört işlemden birini veya çıkış yapmayı seçiniz");
                Console.WriteLine("Toplama için - 1");
                Console.WriteLine("Çıkarma için - 2");
                Console.WriteLine("Çarpma için - 3");
                Console.WriteLine("Bölme için -4");
                Console.WriteLine("Çıkmak için -5");
                secim = Convert.ToInt32(Console.ReadLine());


                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Birinci sayıyı giriniz");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İkinci sayiyi giriniz");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sonuç");
                        Console.WriteLine(Convert.ToString(x+y));
                        break;
                        case 2:
                        Console.WriteLine("Birinci sayıyı giriniz");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İkinci sayiyi giriniz");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToString( "Sonuç:" +  (a - b)));
                        break;
                    case 3:
                        Console.WriteLine("Birinci sayıyı giriniz");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İkinci sayiyi giriniz");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToString("Sonuç:" +c * d));
                        break;
                    case 4:
                        Console.WriteLine("Birinci sayıyı giriniz");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İkinci sayiyi giriniz");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToString("Sonuç:"+ e / f));
                        break;

                }

            } while (secim != 5); */


            //Kullanıcıdan 1-7 arasında bir sayı girmesini isteyin, girdiği sayıya göre haftanın günlerini ekranda göstersin, 
            //1-7 arasında bir sayı girilmezse geçersiz giriş yaptınız uyarısı versin.
            // Ek olarak eğer girilen rakamlar haftasonuna geliyorsa bir etkinlik havuzundan rasgele bir etkinlik seçerek kullanıcıya o etkinliği önersin.
            /*
            do
            {
                Console.WriteLine("Lütfen 1 ile 7 araında bir sayı giriniz. Çıkmak için 8 i seçiniz");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Pazartesi");
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Salı");
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Çarşamba");
                }
                else if (secim == 4)
                {
                    Console.WriteLine("PErşembe");
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Cuma");
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Cumartesi! Katılabileceğin bir sinema etkinliği var.");
                }
                else if (secim == 7)
                {
                    Console.WriteLine("Pazar! Bugün Devlet Tiyatrosuna gidebilirsin.");
                }
                else if (secim == 8)
                {
                    Console.WriteLine("Çıkış yapılıyor.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçim giriniz.");
                }
            } while (true);
            


            //Bir insan sınıfı oluşturunuz, bu sınıf kişinin adını, yaşını ve mesleğini içersin
            //Tanıt fonksiyonu bu bilgileri ekrana yazdırsın, karşılaştır fonksiyonu kişinin yaşı 35'ten büyükse,
            //yaşı 35 büyüktür diye ekranda yazdırsın. */

            /*int toplam = 0;
            do
            {
                Console.WriteLine("Bir sayı giriniz.");
                int x = Convert.ToInt32(Console.ReadLine());
                toplam += x;
                Console.WriteLine("Yeni sayı: " + toplam);
            } while (toplam < 100);
            Console.WriteLine("100 sayısını geçtiniz. Sayılar toplamı: " + toplam);*/


            /*
            int sifre = 17;
            int hak = 1;
            do
            {
                Console.WriteLine("Şifreyi giriniz");
                if (sifre == Convert.ToInt32(Console.ReadLine()))
                {
                    Console.WriteLine("Başarıyla giriş yaptınız.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                    hak++;
                }
            } while (hak < 4);   */


            /*
            int sayi = 5;
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel*= i;
            }
            Console.WriteLine($"{sayi}!= " + faktoriyel);
            */

            /*
            for (int i = 0;i<=3;i++)
            {
                for (int j = 0;j<=3;j++)
                {
                    Console.WriteLine($" {i}=i {j}=j ");
                }
            }
            */

            /*
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }
            */



            /*
            int[] dizi = { 8, 45, 69, 52, 14, 3 };

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j--)
                {
                    if (dizi[i] < dizi[j])
                    {
                        Console.WriteLine(dizi[i]);
                    }
                }
            }
            */

            
            /*
            do
            {
                Random rnd = new Random();
                int sayi = rnd.Next(0, 101);
                Console.WriteLine("Sayı tahmin oyununa hoş geldiniz");
                do
                {
                    Console.WriteLine("0 ile 100 arasında bir sayı seçiniz");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == sayi)
                    {
                        Console.WriteLine("Tebrikler! Doğru bildiniz.");
                        break;
                    }
                    if (secim > sayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı deneyiniz.");
                    }
                    if (secim < sayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı deneyiniz.");
                    }

                    if (secim == 000)
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                    }
                    
                } while (true);
                if (Console.ReadLine() == "000")
                {
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }

            } while (true);
            */





            Console.ReadLine();
        }

        class Insan
        {
            public string Name { get; set; }
            public int Yas { get; set; }
            public string Meslek { get; set; }

            
        }
    }
}
