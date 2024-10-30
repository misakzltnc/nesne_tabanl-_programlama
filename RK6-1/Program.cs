
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RK6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int,string> ogrenciler = new Dictionary<int,string>();

            ogrenciler.Add(101, "Ahmet");
            ogrenciler.Add(102, "Ayşe");

            ogrenciler[101] = "Mehmet";  // Ahmet'i Mehmet olarak güncelle

            string isim = ogrenciler[101]; // Mehmet değerini getirir

            //  ogrenciler.Remove(101); // 101 anahtarını ve değerini siler

           foreach (var student in ogrenciler) 
            {
                Console.WriteLine($" ID: {student.Key}, Name: {student.Value}");
            }


            Console.WriteLine("----------------Birinci uygulama--------------");

            if (ogrenciler.ContainsKey(1002))
            {
                Console.WriteLine("Anahtar mevcut.");
            }
            else { Console.WriteLine("Bu anahtar mevcut değildir"); }

            if (ogrenciler.ContainsValue("Ayşe"))
            {
                Console.WriteLine("Bu isim mevcut");
            }
            else { Console.WriteLine("Bu isim mevcut değildir"); }

            Console.WriteLine("----------------İkinci uygulama-----------------");

            foreach (int anahtar in ogrenciler.Keys)
            {
                if (anahtar == 102)
                {
                    Console.WriteLine("Anahtar: " + anahtar);
                }
            }

            foreach (string deger in ogrenciler.Values)
            {

                if (deger == "Ayşe")
                {
                    Console.WriteLine("Değer: " + deger);
                }
            }

            Console.WriteLine("------------------Üçüncü uygulama---------------------");



            Dictionary<int,string> ogrencilerim = new Dictionary<int,string>();

            ogrencilerim.Add(1, "RK");
            ogrencilerim.Add(2, "Esra");
            ogrencilerim.Add(3, "Buse");

           
            

            do
            {
                Console.WriteLine("1- Öğrenci Ekle");
                Console.WriteLine("2- Öğrenci Güncelle");
                Console.WriteLine("3- Öğrenci Sil");
                Console.WriteLine("4- Öğrenci Ara");
                Console.WriteLine("5- Tüm öğrencileri listele");
                Console.WriteLine("6- Çıkış");
                Console.WriteLine("1 ile 6 arasında bir seçim yapınız");

                int secim = Convert.ToInt32(Console.ReadLine());


                if (secim == 1)
                {
                    Console.WriteLine("Öğrenci numarası giriniz");
                    int numara = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Öğrenci adı giriniz");
                    string ad = Console.ReadLine();

                    ogrencilerim.Add(numara, ad);
                    Console.WriteLine("Öğrenci Ekleme tamamlandı.");
                }
                else if(secim == 2)
                {
                    Console.WriteLine("Güncellemek istediğiniz öğrenci numarasını giriniz");
                    int güncelle = Convert.ToInt32(Console.ReadLine());
                    foreach (int anahtar in ogrencilerim.Keys)
                    {
                        if (anahtar == güncelle)
                        {
                            Console.WriteLine("Yeni adı giriniz");
                            string güncel = Console.ReadLine();
                            ogrencilerim[anahtar] = güncel;

                        }
                        
                    }
                }
                else if (secim ==3)
                {
                    Console.WriteLine("Silmek istediğiniz öğrencinin numarasını giriniz");
                    int silinecek = Convert.ToInt32(Console.ReadLine());
                    foreach (int numara in ogrencilerim.Keys)
                    {
                        if (numara == silinecek)
                        {
                            ogrencilerim.Remove(numara);
                        }
                    }


                }
                else if (secim == 4)
                {
                    Console.WriteLine("Aradığınız öğrencinin adını giriniz");
                    string aranan = Console.ReadLine();
                    foreach (string adı in ogrencilerim.Values)
                    {
                        if (adı == aranan)
                        {
                            Console.WriteLine("Bu öğrenci mevcuttur.");
                        }

                    }
                }
                else if (secim == 5)
                {
                    foreach (var student in ogrencilerim)
                    {
                        Console.WriteLine($" ID: {student.Key}, Name: {student.Value}");
                    }
                }
                else if (secim == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız. ");
                }

                

            } while (true);  


            Console.WriteLine("--------------Dördüncü Uygulama---------------");


            HashSet<string> ogrenciIsimleri = new HashSet<string>();

            ogrenciIsimleri.Add("Ahmet");
            ogrenciIsimleri.Add("Ayşe");

            ogrenciIsimleri.Remove("Ahmet");


            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 3,4,5 };
            
            setA.UnionWith(setB);  // setA artık {3}

            setA.ExceptWith(setB); // setA artık {1,2}

            setA.SymmetricExceptWith(setB); // setA artık {1,2,3,4,5}

            ////////////////////////BEŞİNCİ UYGULAMA//////////////////////
            

            /*


            HashSet<string> dilKursuA = new HashSet<string>();
            HashSet<string> dilKursuB = new HashSet<string>();
            do
            {
                Console.WriteLine("A dil kursuna ekleme yapmak istiyorsanız 1'i seçiniz");
                Console.WriteLine("B dil kursuna ekleme yapmak istiyorsanız 2 seçiniz");
                Console.WriteLine("Çıkmak için 3 ü seçiniz");


                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("A dil kursuna eklemek istediğiniz dili seçiniz");
                    string dil = Console.ReadLine();
                    dilKursuA.Add(dil);
                }
                else if (Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    Console.WriteLine("B dil kursuna eklemek istediğiniz dili seçiniz");
                    string dil = Console.ReadLine ();
                    dilKursuB.Add(dil);
                }
                else if (Convert.ToInt32(Console.ReadLine()) == 3)
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Geçersiz seçim, tekrar deneyiniz.");
                }

            } while (true);
            

            Console.WriteLine("A ve B dil kurslarında bulunan diller");
            dilKursuA.SymmetricExceptWith(dilKursuB);
            foreach ( var dil in dilKursuA)
            {
                Console.WriteLine($"{dil}");
            }

            Console.WriteLine("A kursunda bulunup B kursunda bulunmayan kurslar");
            dilKursuA.ExceptWith(dilKursuB);
            foreach(var dil in dilKursuA)
            {
                Console.WriteLine($"{dil}");
            }


            Console.WriteLine("A ve B dil kursunda bulunan ortak dersler");
            dilKursuA.IntersectWith(dilKursuB);
            foreach (var dil in dilKursuA)
            {
                Console.WriteLine($"{dil}");
            }

            */
            Console.WriteLine("--------------Beşinci Uygulama-----------------------");




            Selamla();

            Console.WriteLine("----------------Altıncı Uygulama-------------------------");

            Console.ReadLine();
        }

        private static void Selamla()
        {
            Console.WriteLine("Merhaba bu özel bir metottur");
        }

        

    }

    class DigerSinif
    {
        private void PrivateMetodCagir()
        {
            // Program.Selamla(); // selamla private fonksiyon olduğu için hata verir. dışarıdan erişilemez. 
        }
    }
}
