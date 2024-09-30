using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RK2_2
{
    class BankaHesabi
    {
        //özellikler
        public string HesapSahibi { get; set; } // kod okunabilir ve değiştirilebilir
        public double Bakiye { get; private set; } // private olduğu için sadece sınıf içinde erişilebilir(bakiye güncellenir).
        public int HesapNumarasi { get; } // sadece get, çünkü hesap numarasına ekleme ya da çıkarma yapılmayacak


        //// Statik bir alan (field) oluşturarak hesap sayısını takip edelim. 
        private static int toplamHesapSayisi = 0;

        // Statik bir metotla hesap sayısını döndürelim. (tekrar çalış)
        public static int ToplamHesapSayisiniGetir()
        {
            return toplamHesapSayisi;
        }

        //Kurucu metot
        ////Kurucu metot içinde hesap sayısını artıralım.
        public BankaHesabi (string hesapSahibi, int hesapNumarasi)
        {
            HesapSahibi = hesapSahibi;
            HesapNumarasi = hesapNumarasi;
            Bakiye = 0; // başlarken bakiye sıfır
            toplamHesapSayisi++;
        }


        //para yatırma
        public void ParaYatir (double bakiye)
        {
            Bakiye += bakiye;
            Console.WriteLine ("{0} TL para yatırıldı. Yeni bakiye: {1} TL", bakiye, Bakiye);
        }

        //Para çekme
        public void ParaCek (double bakiye)
        {
            if (Bakiye >= bakiye)
            {
                Bakiye -= bakiye;
                Console.WriteLine("{0} TL para çekildi. Yeni bakiye: {1} TL", bakiye, Bakiye);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye. Para çekme işlemi yapılamadı.");
            }
        }

        //Hesap Bilgilerini göster
        public void HesapBilgileriniGöster()
        {
            Console.WriteLine("Hesap sahibi: {0}", HesapSahibi);
            Console.WriteLine("Hesap numarası: {0}", HesapNumarasi);
            Console.WriteLine("Bakiye: {0} TL", Bakiye);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hesap oluştur
            var musteriHesabi = new BankaHesabi("Rümeysa Kızıltunçden", 1001);

            //hesap bilgilerini göstermek için
            musteriHesabi.HesapBilgileriniGöster();

            //Para yatırma
            musteriHesabi.ParaYatir(500);

            musteriHesabi.ParaYatir(700);

            //Para çekme
            musteriHesabi.ParaCek(100);

            musteriHesabi.HesapBilgileriniGöster();




            var musteri = new BankaHesabi ("Mert Arslan", 1002);
            musteri.HesapBilgileriniGöster();
            musteri.ParaYatir(1000);
            musteri.ParaCek(1500); //yetersiz bakiye uyarısı almalı
            musteri.ParaCek(35.50);
            musteri.HesapBilgileriniGöster();


            Console.WriteLine("Toplam Hesap Sayısı: " +Convert.ToString(BankaHesabi.ToplamHesapSayisiniGetir()));

            Console.ReadLine();
        }
    }
}
