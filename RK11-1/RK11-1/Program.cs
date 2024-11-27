using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RK11_1
{
	public abstract class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }

		//Soyut metod
		public abstract void ShowInfo();
	}

	public class Student : Person
	{
		public string Major { get; set; }

		public override void ShowInfo()
		{
            Console.WriteLine($"Student: {Name}, ID: {ID}, Major: {Major} ");
        }
	}

	public class Teacher : Person
	{
		public string Subject { get; set; }

		public override void ShowInfo()
		{
            Console.WriteLine($"Teacher: {Name}, ID: {ID}, Subject: {Subject} ");
        }
	}

	public class Staff : Person
	{
		public string Department { get; set; }

		public override void ShowInfo()
		{
            Console.WriteLine($"Staff: {Name}, ID: {ID}, Department: {Department} ");
        }
	}

	public abstract class Urun
	{
		public string Name { get; set; }
		public string price { get; set; }

		public abstract void DisplayInfo();

	}


	public abstract class Electronics : Urun
	{
		public string GarantiSuresi { get; set; }
		public override void DisplayInfo()
		{
            Console.WriteLine($"Electronics: {Name} , Price: {price:C}, Garanti Süresi: {GarantiSuresi}");
        }
	}

	public abstract class Clothing : Urun
	{
		public string Beden { get; set; }
		public override void DisplayInfo() 
		{
            Console.WriteLine($"Clothing: {Name}, Price {price:C}, Size: {Beden} "); 
		}
	}

	public abstract class Book : Urun
	{
		public string Writer { get; set; }
		public override void DisplayInfo() 
		{
			Console.WriteLine($"Book: {Name} , Price: {price:C}, Author: {Writer}");
		}
	}

	internal class Program
	{
		static List<Person> people = new List<Person>();
		static void Main(string[] args)
		{
			Person[] people =
			{
				new Student {Name = "Alice", ID = "S001" , Major = "Bilinmeyen"},

				new Teacher { Name ="Bob" , ID = "T001" , Subject = "Bilinmeyen" },

				new Staff {Name = "Charlie", ID = "ST001" , Department = "Bilinmeyen" }
			};

			foreach (var person in people) 
			{
				//person.ShowInfo();
			}

            Console.WriteLine("1- Yeni Kişi Ekle");
			Console.WriteLine("2- Mevcut Kişiyi Güncelle");
			Console.WriteLine("3- Seçilen Kişiyi Sil");
			Console.WriteLine("4- Tüm kişilerin bilgilerini listele");


            Console.ReadLine();
		}

		static void AddPerson()
		{
            Console.WriteLine("Choose the type of person to add");
            Console.WriteLine("1. Student");
			Console.WriteLine("2. Teacher");
			Console.WriteLine("3. Staff");
			Console.Write("Enter your choice: ");
			string choice = Console.ReadLine();

			Console.Write("Enter Name: ");
			string name = Console.ReadLine();

			Console.Write("Enter ID: ");
			string id = Console.ReadLine();

			switch (choice)
			{

			}
        }
	}
}
