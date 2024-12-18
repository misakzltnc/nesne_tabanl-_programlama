using System;
using System.IO;
using System.Threading;


namespace RK14_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread gorev1 = new Thread(fonk1);
            //Console.WriteLine("yazdırma işlemi başlatılıyor");
            //gorev1.Start();


            while (4<3)
            {
                try
                {
                    int yas = 5; // negatif
                    if (yas < 0)
                    {
                        throw new CustomException("Yaş negatif olamaz");
                    }
                }
                catch (CustomException ex)
                {
                    Console.WriteLine("Özel Hata: " + ex.Message);
                }
            }
            



            while (4 < 3)
            {
                try
                {
                    Console.Write("Yaşınızı giriniz: ");
                    int age = int.Parse(Console.ReadLine());

                    CheckAge(age);
                }
                catch (CustomException ex)
                {
                    Console.WriteLine("Özel hata: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Genel Hata: " + ex.Message);
                }

            }

            while (4<3)
            {
                try
                {
                    Console.WriteLine("yaşınızı giriniz");
                    int yas = int.Parse(Console.ReadLine());
                    if (yas < 0)
                    {
                        throw new CustomException("Yaş negatif olamaz!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Genel Hata: " + ex.Message);
                }
            }

            while (4<3)
            {
                try
                {
                    Console.WriteLine("birinci sayıyı giriniz");
                    int sayi1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("ikinci sayıyı giriniz");
                    int sayi2 = int.Parse(Console.ReadLine());

                    double result = Divide(sayi1, sayi2);
                    Console.WriteLine("Sonuç: " + result);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

            while (4 < 3)
            {
                try
                {
                    Console.WriteLine("yaşınızı giriniz");
                    int yas = int.Parse(Console.ReadLine());

                    YasKontrol(yas);
                    break;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Hata: lütfen geçerli bir sayı giriniz.");
                }
                catch ( ArgumentException ex)
                {
                    Console.WriteLine("hata: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("hata: " + ex.Message);
                }
                
            }


            double bakiye = 1000;
            bool islemTamamlandi = false;
            while (!islemTamamlandi)
            {
                Console.WriteLine($"Mevcut bakiyeniz: {bakiye} TL");
                Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                double tutar = double.Parse(Console.ReadLine());

                if (tutar <0)
                {
                    throw new ArgumentException("Çekilecek tutar negatif olamaz.");
                }
                if (tutar > bakiye)
                {
                    throw new InsufficientBalanceException("Bakiyeniz yetersiz.");
                }
            }
            

            Console.ReadLine();
        }


        public class InsufficientBalanceException: Exception
        {
            public InsufficientBalanceException(string message) : base(message) { }
        }
        static double Divide(double numerator,  double denominator)
        {
            if ( denominator == 0)
            {
                throw new DivideByZeroException("Payda sıfır olamaz");
            }
            return numerator / denominator;
        }
        static void CheckAge(int age)
        {
            if (age < 0)
            {
                throw new CustomException("Yaş negatif olamaz");
            }
            else if (age < 18)
            {
                throw new CustomException("Yaş 18 den küçük olamaz");
            }
            else { Console.WriteLine("Yaş geçerli: " + age); }
        }

        static void YasKontrol(int yas)
        {
            if (yas < 0)
            {
                throw new ArgumentException("Yaş sıfırdan küçük olamaz, tekrar deneyiniz.");
            }
            else if (yas > 120)
            {
                throw new ArgumentException("Geçersiz bir yaş değeri girdiniz, tekrar deneyiniz.");
            }
            else
            {
                Console.WriteLine("Geçerli bir yaş değeri girdiniz: " + yas);
            }
        }
        public class CustomException : Exception 
        {
            public CustomException(string message) : base(message) { }
        }


        static void fonk1()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"yazma işleminin {i}. adımı");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Yazdırma işlemi tamamlandı.");
        }
    }
}
