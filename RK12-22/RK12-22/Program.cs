using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK12_22
{
	internal class Program
	{
		static void Main(string[] args)
		{
            /*
			while (true)
			{
				Console.WriteLine("Adınızı ve soyadınızı giriniz.");
				string dizin = Console.ReadLine();

				string[] part = dizin.Split(' ');


				for (int i = 0; i < part.Length; i++)
				{

					Console.WriteLine(duzenle(part[i]) + " ");
				}

			}
			*/



			/*
			while (true)
			{
                Console.WriteLine("");

                DateTime now = DateTime.Now;
				Console.WriteLine("Şu anki tarih ve saat: " + now);

				// yıl ay gün
				Console.WriteLine("Doğum tarihinizin yılını giriniz");
				int yıl = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Doğum tarihinizin ayını giriniz");
				int ay = Convert.ToInt32(Console.ReadLine());


				Console.WriteLine("Doğum tarihinizin gününü giriniz");
				int gun = Convert.ToInt32(Console.ReadLine());

				DateTime dogumTarihi = new DateTime(yıl, ay, gun);


				int a = (ay*30) + gun;
				int b = (now.Month * 30 ) + now.Day;

				int kalanGun = a - b ;





				if ( ay == now.Month && gun == now.Day)
				{
					Console.WriteLine("Doğum gününüz kutlu olsun");
				}
				else
				{
					if (kalanGun  > 0)
					{

					}
					else
					{
						int pozitif = Math.Abs(kalanGun);
						Console.WriteLine("Doğum gününüz geçeli çok oldu: " + pozitif);

					}
				}
			}
           
			*/





			Console.ReadLine();
        }

		static string duzenle(string x)
		{
			x = x.ToLower();
			return char.ToUpper(x[0]) + x.Substring(1);
 		}
	}
}
