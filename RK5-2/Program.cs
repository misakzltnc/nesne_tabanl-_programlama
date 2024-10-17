using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] ogrenciler = { "Ali", "Ayşe", "Mehmet" };
            string[] dersler = { "Matematik", "Fizik", "Kimya" };
            int[,] notlar =
            {
                  { 85,90,78}
                , {88,92,80}
                , {75,85,89}
            };


            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
                for (int j = 0; j < dersler.Length; j++)
                {
                    Console.WriteLine(notlar[j,i]  + "  notunu alan kişi  "+  ogrenciler[j]);
                    
                }
            }


            for (int i = 0;i < 3; i++)
            {
                int ortalama = 0;
                double son = 1;
                for (int j = 0;j < 3; j++)
                {
                    ortalama += notlar[i, j];
                    son = ortalama / 3;
                }
                Console.WriteLine(ogrenciler[i] + " adlı öğrencinin not ortalaması=  " + son );
            }


            */






            /////class la denedim
            ///

            /*
            int sifre = 310104;
            int hak = 3;
            Console.WriteLine("Bankamıza hoş geldiniz.");
            Console.WriteLine("Lütfen şifrenizi giriniz.");
            do
            {
                int deneme = Convert.ToInt32(Console.ReadLine());
                if (deneme == sifre)
                {
                    Console.WriteLine("Şifre doğru!");
                    Console.WriteLine("Bakiye sorgulamak için 1, çıkış yapmak için 0 seçiniz.");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {

                    }
                    else if (secim == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim yaptınız. 1 ya da 0 tercih ediniz.");
                    }
                }
                else
                {
                    Console.WriteLine($"Hatalı şifre girdiniz. {hak} hakkınız kaldı. Lütfen tekrar deneyiniz.");
                    hak--;
                }

            } while (hak == 0);



            */



            string sifre = "123";
            string kullanıcıGirdisi;
            int bakiye = 1000;
            bool girisYapildi = false;
            int denemeSayisi = 0;
            int maxDeneme = 2;



            do
            {
                Console.WriteLine("Lütfen şifrenizi girin:");
                kullanıcıGirdisi = Console.ReadLine();
                denemeSayisi++;

                if (kullanıcıGirdisi == sifre)
                {
                    girisYapildi = true;
                    Console.WriteLine("Giriş başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı şifre tekrar deneyiniz.");

                }

            } while (!girisYapildi && denemeSayisi < maxDeneme);


            if (!girisYapildi)
            {
                Console.WriteLine("Hesabınız kilitlendi. Maksimum deneme sayısına ulaştınız.");
                return;
            }

            string secim;
            while (girisYapildi)
            {
                Console.WriteLine("1 - Bakiye Sorgulama");
                Console.WriteLine("2 - Çıkış yap");
                secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.WriteLine("Bakiyeniz= " + bakiye + "TL");
                }
                else if ( secim == "2")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    girisYapildi=false;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
                }
            }


            Console.ReadLine();


        }

        class Banka
        {
            public string Name { get; set; }
            public int Bakıye { get; private set; }

            public Banka(string name, int bakiye) 
            {
                Name = name;
                Bakıye = bakiye;
            }

            public void hesapBilgileriGoster()
            {
                Console.WriteLine(Name + "isimli kişinin kasasında " + Bakıye + " TL vardır.");
            }
            
        }

    }
}
