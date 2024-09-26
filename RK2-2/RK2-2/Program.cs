using System.ComponentModel.Design.Serialization;
using System.Data;

namespace RK2_2
{
	internal class Program
	{

		public class Animal  //hayvan sınıfını tanımla
		{
			//özellikler
			public string Name { get; set; }  //hayvanın adı
			public string Sound { get; set; } //hayvanın çıkardığı ses

			//yapıcı metod
			public Animal(string name, string sound) //adı ve sesi alarak yeni bir Animal nesnesi oluşturur
			{
				Name = name;
				Sound = sound;
			}

			public void MakeSound () //Hayvanın ses çıkarma metodu
			{
				Console.WriteLine($"{Name} diyor: {Sound}"); // hayvanın adını ve sesini ekrana yazdır
			}
		}

		public class Car  //Araba sınıfının tanımı
		{
			//Özellikler
			public string Make { get; set; } //Arabanın Markası
			public string Model { get; set; } //Arabanın modeli

			public int Speed { get; private set; } //Arabanın hızı, private set özel erişim sağladı, string değil int kullandım

			//Yapıcı metod
			public Car (string make, string model) //Markayı ve modeli alarak yeni bir Car nesnesi oluşturur
			{
				Make = make;
				Model = model;
				Speed = 0; //başlangıç hızı sıfır
			}

			//Metodlar
			public void Accelerate (int incrase) //hızı arttıran metod
			{
				Speed += incrase; //verilen değeri hıza ekler
				Console.WriteLine($"Hız arttırıldı:{Speed} km/s");
			}

			public void Brake (int decrase) //hızı azaltan metod
			{
				Speed -= decrase;  //verilen değerde hız azalır
				if (Speed < 0) Speed = 0; // hız negatif olamaz
				Console.WriteLine($"Hız azaltıldı: {Speed} km/s"); 
			}

			public void Displayinfo () //Araba bilgilerini ekranda gösteren metod
			{
				Console.WriteLine($"Arabanın markası {Make} modeli {Model} hızı {Speed} km/s");
			}
		}


		public class Die
		{
			private int numberOfEyes;
			private Random randomNumberSupplier;
			private const int maxNumberOfEyes = 6;

			public Die ()
			{
				randomNumberSupplier = new Random(unchecked((int)DateTime.Now.Ticks));
				numberOfEyes = NewTossHowManyEyes();
			}

			public void Toss()
			{
				numberOfEyes = NewTossHowManyEyes();
			}

			private int NewTossHowManyEyes ()
			{
				return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
			}

			private int NumberOfEyes()
			{
				return numberOfEyes;
			}
			public override string ToString()
			{
				return String.Format("{0}", numberOfEyes);
			}
		}

		static void Main(string[] args)
		{
			//Animal uygulaması
			//Yeni bir animal nesnesi oluştur
			Animal myAnimal = new Animal("Kedi","Miyav");

			//Hayvanın ses çıkarma metodunu çağırma
			myAnimal.MakeSound(); //Ekrana yazdırır

			//Car uygulaması
			//Yeni bir Car nesnesi oluşturma
			Car myCar = new Car("Toyota", "Corolla");

			//Arabanın bilgilerini gösterme
			myCar.Displayinfo();

			//Arabanın hızını arttrma
			myCar.Accelerate(50);

			//Arabanın hızını azaltma
			myCar.Brake(20);

			//Güncellenmiş bilgileri gösterme
			myCar.Displayinfo();


			//Zar oyunu uygulaması
			Die d1 = new Die();
			Die d2 = new Die();
			Die d3 = new Die();

			for (int i = 1; i<10; i++)
			{
				Console.WriteLine("Die 1: {0} ", d1);
				Console.WriteLine("Die 2: {0} ", d2);
				Console.WriteLine("Die 3: {0} ", d3);

				d1.Toss();
				d2.Toss();
				d3.Toss();
			}

		}
	}
}
