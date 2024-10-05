namespace IfElseSwitchApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ruya Manavina Hos Geldiniz!\n" +
				"Elma = 2 TL\n" +
				"Armut = 3 TL\n" +
				"Cilek = 2 TL\n" +
				"Muz = 3 TL\n" +
				"Diger butun meyveler = 4 TL");

			Console.Write("Hangi meyveyi satin almak istersiniz ? (Elma/Armut/Cilek/Muz/Diger) : ");

			string? meyve = Console.ReadLine().ToUpper();//Kullanicidan meyve ismini aliyoruz.

			switch (meyve)
			{
				case "ELMA":
					Console.WriteLine("Sectiginiz meyvenin fiyati : 2 TL");
					break;
				case "ARMUT":
					Console.WriteLine("Sectiginiz meyvenin fiyati : 3 TL");
					break;
				case "CILEK":
					Console.WriteLine("Sectiginiz meyvenin fiyati : 2 TL");
					break;
				case "CİLEK"://Upper case yapıldığında küçük cilek girildiğinde hata verir. Bu yüzden küçük cilek girildiğinde de çalışması için ekledik.
					Console.WriteLine("Sectiginiz meyvenin fiyati : 2 TL");
					break;
				case "MUZ":
					Console.WriteLine("Sectiginiz meyvenin fiyati : 3 TL");
					break;
				default:
					Console.WriteLine("Sectiginiz meyvenin fiyati : 4 TL");
					break;
			}

			//Alternatif olarak if else kullanarakta yapabiliriz.
			//Kodun çalışması için aşşağıda ki kodu açıp yukarıdaki kodu kapatabilirsiniz.

			//if (meyve == "ELMA")
			//{
			//	Console.WriteLine("Sectiginiz meyvenin fiyati : 2 TL");
			//}
			//else if (meyve == "ARMUT")
			//{
			//	Console.WriteLine("Sectiginiz meyvenin fiyati : 3 TL");
			//}
			//else if (meyve == "CILEK" || meyve == "CİLEK")
			//{
			//	Console.WriteLine("Sectiginiz meyvenin fiyati : 2 TL");
			//}
			//else if (meyve == "MUZ")
			//{
			//	Console.WriteLine("Sectiginiz meyvenin fiyati : 3 TL");
			//}
			//else
			//{
			//	Console.WriteLine("Sectiginiz meyvenin fiyati : 4 TL");
			//}

			//if-else yapısını kullanarakta aynı işlemi yapabiliriz.Ancak if else yapısında bir kaç durumu tek state e sığdırabildiğimiz için daha fazla esmeklik sağlamaktadır. Örneğin çilek değişkeni için iki case açmamız gerekirken if-else yapısında tek statement'da tanımlayabildik. 
		}
	}
}
