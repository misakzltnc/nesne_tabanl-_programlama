using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RK4_1
{
    internal class Program
    {
        /// <summary>
        /// ////////////////////////////////////
        /// </summary>
        class Hasta
        {
            public string HastaAdi { get; set; }

            private bool randevuDurumu;

            public Hasta(string isim)
            {
                HastaAdi = isim;
                randevuDurumu = false;
            }

            public void RandevuAl()
            {
                if (randevuDurumu)
                {
                    Console.WriteLine("Mevcut randevunuz bulunmaktadır.");
                }
                else
                {
                    randevuDurumu = true;
                    Console.WriteLine($"{HastaAdi} için randevu alındı.");
                }
            }

            public void RandevuIptal()
            {
                if(randevuDurumu)
                {
                    randevuDurumu =false;
                    Console.WriteLine($"SN. {HastaAdi} randevunuz iptal edildi.");
                }
                else
                {
                    Console.WriteLine("Kayıtlı randevunuz bulunmamıştır.");
                }
            }

            public void HastaBilgileri()
            {
            }
        }

        class RandevuSaati
        {

        }


        /// <summary>
        /// /////////////////////////////////
        /// </summary>

        class Kullanici
        {
            public string Isim { get; set; }
            private int yas;
            public Kullanici(string isim, int yas)
            {
                Isim = isim;
                this.yas = yas;
            }

            public void YasKontrol()
            {
                if (yas >= 20)
                {
                    Console.WriteLine($"{Isim}, yetişkin");
                }
                else if (yas >= 13)
                {
                    Console.WriteLine($"{Isim}, ergen ");
                }
                else
                {
                    Console.WriteLine($"{Isim}, çocuk");
                }
            }
            public int YasGoster()
            {
                return yas;
            }
        }
        class BankaHesabi
        {
            public string HesapSahibi { get; set; } // kod okunabilir ve değiştirilebilir
            public double Bakiye { get; private set; } // private olduğu için sadece sınıf içinde erişilebilir(bakiye güncellenir).


            public BankaHesabi(string hesapSahibi)
            {
                HesapSahibi = hesapSahibi;
                Bakiye = 0; // başlarken bakiye sıfır
            }

            public void ParaYatir(double bakiye)
            {
                Bakiye += bakiye;
                Console.WriteLine("{0} TL para yatırıldı. Yeni bakiye: {1} TL", bakiye, Bakiye);
            }

            public void ParaCek(double bakiye)
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


            public void HesapBilgileriniGöster()
            {
                Console.WriteLine("Hesap sahibi: {0}", HesapSahibi);
                Console.WriteLine("Bakiye: {0} TL", Bakiye);
            }
        }








        /// <summary>
        /// /////////////////////////////////////////////////////
        /// </summary>
        /// <param name="args"></param>
        /// 






        class Urun
        {
            public string urunAdi {  get; set; }
            public int urunId { get; set; }
            public int StokMiktari { get; private set; }


            public Urun(string urunAdi, int urunId, int stokMiktari)
            {
                this.urunAdi = urunAdi;
                this.urunId = urunId;
                stokMiktari = 0;
            }   


            public void StokEkle(int stokMiktari)
            {
                StokMiktari += stokMiktari;
                Console.WriteLine($"eklenen miktar {stokMiktari}, son durum {StokMiktari}");

            }

            public void StokAzalt(int stokMiktari)
            {
                StokMiktari -= stokMiktari;
                Console.WriteLine($"azalan miktar {StokMiktari}, son durum {stokMiktari}");
            }

            public void StokDurumu()
            {
                Console.WriteLine("Ürün adı: {0} ve Ürün ID: {1}", urunAdi, urunId);
                Console.WriteLine("Son stok durumu: {0}", StokMiktari);
            }


            class Stok
            {
                // ürün sınıfını listele
            }
        }


        static void Main(string[] args)
        {
            /*
            int sayi = 10;
            if (sayi > 5 ) { Console.WriteLine("Sayı 5'ten büyüktür."); }

            int puan = 45;
            if (puan >=50) { Console.WriteLine("Sınavı geçtiniz"); }
            else { Console.WriteLine("Sınavda başarısız oldunuz"); }

            int sadakatPuanı = 120;
            double toplamTutar = 300.50;

            if (sadakatPuanı > 100)
            {
                if (toplamTutar > 500)
                {
                    Console.WriteLine("Müşteriye %10 indirim uygulanacak");
                }
                else
                {
                    Console.WriteLine("toplam tutarı arttırınız.");
                }
            }

            int sayi1 = 7;
            if (sayi1 > 10)
            {
                Console.WriteLine("10 dan büyüktür");
            }
            else if (sayi1 > 5)
            {
                Console.WriteLine("5 ten büyük ama 10 dan küçük veya eşit");
            }
            else
            {
                Console.WriteLine("5 veya daha küçük");
            }

            */


            /*

            int sadakatPuanı = 120;
            double toplamTutar = 600.50;

            if (sadakatPuanı >100)
            {
                if (toplamTutar > 500)
                {
                    Console.WriteLine("Yüzde 10 indirim");
                }
                else { Console.WriteLine("Yüzde 5 indirim"); }
            }
            else if (sadakatPuanı > 50)
            {
                if (toplamTutar > 500)
                {
                    Console.WriteLine("Yüzde 7 indirim");
                }
                else
                {
                    Console.WriteLine("yüzdde 3 indirim");
                }
            }
            else
            {
                Console.WriteLine("Müşteriye indirim uygulanmayacak");
            }


            */


            var musteriHesabi = new BankaHesabi ("Rümeysa Kızıltunçden");
            musteriHesabi.ParaYatir(1200);
            musteriHesabi.ParaCek(1500);
            musteriHesabi.HesapBilgileriniGöster();

            Kullanici kullanici = new Kullanici ("Ali", 25);
            kullanici.YasKontrol();
            Console.WriteLine($"Ali'nin yaşı: {kullanici.YasGoster()}");


            Console.WriteLine("1 ile 7 arasında bir sayı seçiniz ve hangi gün olduğunu söyleyelim!");
            string gun = Console.ReadLine();
            switch (gun)
            {
                case "1":
                    Console.WriteLine("Pazartesi");
                    break;
                case "2": Console.WriteLine("Salı");
                    break;
                case "3": Console.WriteLine("Çarşamba");
                    break;
                case "4": Console.WriteLine("Perşembe");
                    break;
                case "5": Console.WriteLine("Cuma");
                    break;
                case "6": Console.WriteLine(  "Cumartesi");
                    break;
                case "7": Console.WriteLine("Pazar");
                    break;
                default: Console.WriteLine("1 ile 7 arasında bir gün giriniz");
                    break;
            }


            Console.WriteLine("1 ile 12 arasında bir ay seçiniz ve hangi mevsim olduğunu söyleyelim!");
            int ay = Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Girdiğiniz ay kış mevsimindedir");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Girdiğiniz ay ilkbahar mevsimindedir");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Girdiğiniz ay yaz mevsimindedir");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Girdiğiniz ay sonbahar mevsimindedir");
                    break;
                default:
                    Console.WriteLine("1 ile 12 arasında bir değer giriniz");
                    break;
            }


            int yas = 18;
            string uygunluk;
            int yas2 = 15;
            string uygunluk2;
            if (yas >= 18)
            {
                uygunluk = "Oy vermeye uygun";
            }
            else { uygunluk = "Oy vermeye uygun değil"; }
            Console.WriteLine(uygunluk);


            uygunluk2 = (yas2 >= 18) ? "Oy vermeye uygun" : "Oy vermeye uygun değil";
            Console.WriteLine(uygunluk);

            Console.ReadLine();
        }
    }
}
