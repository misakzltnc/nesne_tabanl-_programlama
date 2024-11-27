using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RK11_1._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "John Doe";
            Console.WriteLine(name.ToUpper()); // JOHN DOE
            Console.WriteLine(name.ToLower()); // john doe


			string input = "    Hello World    ";
            Console.WriteLine($"Orijinal: '{input}' ");
			Console.WriteLine($"Trim sonrası: '{input.Trim()}' ");


			string message = "Merhaba Dünya!";
			string part = message.Substring(8, 5);
            Console.WriteLine(part);


			string text = "Merhaba Dünya";
			string replacedText = text.Replace("Dünya", "C#");
            Console.WriteLine(replacedText);


			string data = "Ad, Soyad, Yaş";
			string[] parts = data.Split(',');
			foreach (string partm in parts)
			{
				Console.WriteLine(partm.Trim());
			}


			string[] names = { "Ali", "Ayşe", "Mehmet" };
			string result = string.Join(",", names);
			Console.WriteLine(result);

			string fileName = "report.pdf";
            Console.WriteLine(fileName.EndsWith(".pdf"));
			Console.WriteLine(fileName.StartsWith("rep"));
			Console.WriteLine(fileName.StartsWith("reps"));


			string sentence = "C# programlama oldukça güçlü bir dildir.";
            Console.WriteLine(sentence.Contains("programlama"));


			string text2 = "Merhaba, bu bir C# programıdır ve programdır C#";
			int firstIndex = text2.IndexOf("C#");
			int lastIndex = text2.LastIndexOf("program");
            Console.WriteLine(firstIndex);
            Console.WriteLine(lastIndex);


			string original = "Merhaba Dünya";
			string modified = original.Insert(8, "güzel ");
            Console.WriteLine(modified);

			string data2 = "123-45-6789";
			string modified2 = data2.Remove(3, 1);
            Console.WriteLine(modified2);




			string value = "42";
			string paddedLeft = value.PadLeft(5, '0');
			string paddedRight = value.PadRight(5, '-');
            Console.WriteLine(paddedLeft);
            Console.WriteLine(paddedRight);
            Console.WriteLine();
			Console.WriteLine();

			/*
			
			while (true)
			{
				Console.Write("Lütfen mail adresinizi giriniz.");
                Console.WriteLine("Çıkmak için exit yazınız");
                string mail = Console.ReadLine();

				string[] part2 = mail.Split('@');

				if (mail.Contains("@") && part2[1].Contains("."))
				{
					Console.WriteLine("Geçerli bir mail adresi girdiniz");
				}
				else if (mail == "exit")
				{
					break;
				}
				else
				{
					Console.WriteLine("Geçersiz bir mail adresi, lütfen tekrar deneyiniz.");
				}
			}
            */


			string[] listem = { "a.docx", "b.txt", "c.pdf" , "d.txt" , "e.txt" , "f.docx" ,"g.txt" , "h.pdf" , "i.pdf" , "j.docx" , "k.pdf" , "l.pdf" , "m.docx" ,"n.txt" , "o.pdf" };

			foreach(string item in listem)
			{
				if (item.EndsWith(".pdf"))
				{
					Console.WriteLine(item);
				}
			}


            Console.WriteLine();

			DateTime now = DateTime.Now;
            Console.WriteLine("Şu anki tarih ve saat: " + now);


			DateTime customDate = new DateTime(2000, 5, 15);
            Console.WriteLine("Özel Tarih: " + customDate.ToShortDateString());


			DateTime startDate = new DateTime(2024, 1, 1);
			DateTime endDate = DateTime.Now;
			TimeSpan difference = endDate - startDate;

            Console.WriteLine($"Fark: {difference.Days} gün");
			Console.WriteLine($"Toplam Saat: {difference.TotalHours}");


			DateTime RK = new DateTime(2004, 01, 31);
			TimeSpan yas =  now - RK;

			int hesaplama = Convert.ToInt32(yas.TotalDays);
			int sonuc = (hesaplama / 365) + 1;
			Console.WriteLine("RK kişisiniz yaşı: " + sonuc);

            Console.ReadLine();

        }
	}
}
