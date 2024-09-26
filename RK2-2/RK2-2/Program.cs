using System.ComponentModel.Design.Serialization;
using System.Data;

namespace RK2_2
{
	internal class Program
	{
		// Sınıfları öğrenmek ve uygulamak için kullanılabilir.
		// Burada 3 ayrı uygulama yapılmıştır. Animal, Car, Die
		// Animal uygulamasında hayvan sınıfı tanımlanmış, isim ve ses olmak üzere 2 özellik kullanılmıştır.
		// Car uygulamasında, araba sınıfı tanımlanmış ve araba nesnesi oluşturulmuştur. Marka, model, hız özellikleri vardır. Hızı arttırıp azaltma işlevlerine sahiptir.
		// Die uygulamasında, 6 yüzlü 3 zarın simülasyonu yapılmıştır. 3 zar rastgele atılır ve sonuçları ekrana yazdırılır. Her atışta zarların yeni değerleri belirlenir ve bu işlem 9 kez tekrarlanır.

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


		public class Die  //Zarı temsil eden bir sınıf tanımlanıyor
		{
			private int numberOfEyes;  //zarın göz sayısını tutan özel bir değişken
			private Random randomNumberSupplier; // Rastgele sayı üreticisi
			private const int maxNumberOfEyes = 6; // Zarın maksimum göz sayısını tanımlayan sabit

			public Die ()  // Yapıcı metod; zar nesnesi oluşturulduğunda çalışır
			{
				randomNumberSupplier = new Random(unchecked((int)DateTime.Now.Ticks));  // Rastgele sayı üreticisi oluşturuluyor
				numberOfEyes = NewTossHowManyEyes(); // İlk zar atışı yapılıyor ve sonuç atanıyor
			}

			public void Toss() // Zar atışını simüle eden bir metod
			{
				numberOfEyes = NewTossHowManyEyes(); // Yeni zar atışı yapılıyor ve sonuc güncelleniyor
			}

			private int NewTossHowManyEyes ()  // Yeni göz sayısını belirleyen özel bir metod
			{
				return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);  // 1 ile 6 arasında rastgele bir sayı döndürüyor
			}

			private int NumberOfEyes() // Zarın göz sayısını döndüren metod
			{
				return numberOfEyes; // Mevcut göz sayısını geri döndürüyor
			}
			public override string ToString() // Sınıfın dize temsili için metod
			{
				return String.Format("{0}", numberOfEyes); // Göz sayısını köşeli parantez içinde döndürüyor
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
			//Zar nesnesini oluştur
			Die d1 = new Die();
			Die d2 = new Die();
			Die d3 = new Die();

			for (int i = 1; i<10; i++) // 1 den 9 a kadar döngü; toplam 9 iterasyon yapacak
			{
				Console.WriteLine("Die 1: {0} ", d1);  //d1 zarının mevcut değerini ekrana yazdırır
				Console.WriteLine("Die 2: {0} ", d2);
				Console.WriteLine("Die 3: {0} ", d3);

				d1.Toss(); // d1 zarını atar ve yeni değeri günceller
				d2.Toss(); // d2 zarını atar ve yeni değeri günceller
				d3.Toss(); // d3 zarını atar ve yeni değeri günceller
			}

		}
	}
}
