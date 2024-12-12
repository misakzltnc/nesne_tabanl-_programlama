using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace RK13_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Thread gorev1 = new Thread(Fonk1);
			Thread gorev2 = new Thread(Fonk2);

			//gorev1.Start();
			//gorev2.Start();

			//gorev1.Join();
			//gorev2.Join();

			//Console.WriteLine("İşlem tamamlandı");

			Thread gorev3 = new Thread(CpuKullanimiKontrol);
			gorev3.Name = "CPU Kullanımı Kontrolü";

			Thread gorev4 = new Thread(RamKontrol);
			gorev4.Name = "Ram Kullanımı Kontrolü";

            Console.WriteLine("İşlem başlatılıyor.");

			gorev3.Start();
			gorev4.Start();

			gorev3.Join();
			gorev4.Join();

            Console.WriteLine("Tüm işlemler tamamlandı.");




            Console.ReadLine();
        }

		static void Fonk1()
		{
			for (int i = 0; i <=5; i++) 
			{
                Console.WriteLine($"Veri işlemenin {i}. adımı" );
				Thread.Sleep(1000);
            }
		}

		static void Fonk2()
		{
			for (int i = 0;i <=3; i++) 
			{
				Console.WriteLine($"E-posta gönderiminin {i}. adımı");
				Thread.Sleep(1500);
			}
		}

		static void CpuKullanimiKontrol()
		{
			Console.WriteLine($"{Thread.CurrentThread.Name} başlatıldı.");

			var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

			cpuCounter.NextValue();
			for (int i = 0; i < 3; i++)
			{
				float cpuUsage = cpuCounter.NextValue();
				Console.WriteLine($"{Thread.CurrentThread.Name} CPU Kullanımı: {cpuUsage}%");

				Thread.Sleep(2000);
			}

			Console.WriteLine($"{Thread.CurrentThread.Name} tamamlandı.");
		}

		static void RamKontrol()
		{
			Console.WriteLine($"{Thread.CurrentThread.Name} başlatıldı.");

			var ramCounter = new PerformanceCounter("Memory", "Available MBytes");

			// First read to initialize the counter properly
			ramCounter.NextValue();
			for (int i = 0; i < 3; i++)
			{
				float ramUsage = ramCounter.NextValue();
				Console.WriteLine($"{Thread.CurrentThread.Name} RAM Kullanımı: {ramUsage} MB");

				Thread.Sleep(3000);
			}

			Console.WriteLine($"{Thread.CurrentThread.Name} tamamlandı.");
		}
	}
}
