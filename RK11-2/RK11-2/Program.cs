using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Calisan
{
	public string Ad { get; set; }
	public int Maas { get; set; }

	public abstract void MaasHesapla();

}

public class Muhendis : Calisan
{

	public override void MaasHesapla()
	{
		double sonMaas = Maas * 1.2 ;

        Console.WriteLine($"{Ad} isimli mühendisin maaşı: {sonMaas} ");
    }


}

public class Uzman : Calisan
{

	public override void MaasHesapla()
	{
		double sonMaas = Maas * 1.1;
		Console.WriteLine($"{Ad} isimli uzmanın maaşı: {sonMaas} ");
	}
}


namespace RK11_2
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			Calisan[] calisan =
			{
				new Muhendis {Ad = "Ahmet" , Maas = 1000  },

				new Uzman {Ad = "Sefa" , Maas = 1000  }
			};


			foreach (var item in calisan) 
			{
				item.MaasHesapla();
			}


			Console.ReadLine();
		}
	}
}
