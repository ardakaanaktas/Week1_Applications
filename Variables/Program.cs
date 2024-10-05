namespace Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lütfen asagidaki bilgileri giriniz:");
			Console.Write("T.C. Kimlik Numarası:");
			string? tcNo = Console.ReadLine();
			Console.Write("Adi:");
			string? name = Console.ReadLine();
			Console.Write("Soyadi:");
			string? lastName = Console.ReadLine();
			Console.Write("Telefon Numarasi:");
			string? telNo = Console.ReadLine(); // Telefon numarası üzerinde herhangi bir işlem yapmayacağımız için string olarak alınabilir.
			Console.Write("Yas:");
			string? age = Console.ReadLine();
			Console.Write("Ilk Aldigi urunun fiyati:");
			string? product_1 = Console.ReadLine();
			Console.Write("Ikıncı Aldigi urunun fiyati:");
			string? product_2 = Console.ReadLine();

			int total = Convert.ToInt32(product_1) + Convert.ToInt32(product_2); // toplam fiyat hesaplanır, bu sebeple string olarak alınan değişkenler int dönümüne çevirilir.

			Console.WriteLine($"{tcNo} Tc numarali {name} {lastName} isimli kisi icin kayit olusturulmustur.");
			Console.WriteLine($"{telNo} telefon numarasina bildirim mesaji gonderilmistir.");
			Console.WriteLine($"{total} toplam harcama karsiliginda kazanilan %10 patika puan miktari -> {total * 0.1} TL'dir.");

		}
	}
}
