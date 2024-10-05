namespace KimMilyonerOlmakIster
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Sorularımız:
			/*
			1.Soru:
			Türkiye'nin başkenti neresidir?
			A) Ankara
			B) İstanbul
			2.Soru:
			Atatürk hangi yıl doğmuştur?
			A) 1881
			B) 1882
			3.Soru:
			Atatürk'ün annesinin adı nedir?
			A) Zübeyde Hanım
			B) Fatma Hanım
			 */

			int correctAnswerCount = 0;
			Console.WriteLine("Kim Milyoner Olmak İster Oyununa Hoş Geldiniz!");

			#region 2 Soruluk Part
			Console.WriteLine("1.Soru: Türkiye'nin başkenti neresidir?\nA) Ankara\nB) İstanbul");
			Console.Write("Cevabınızı giriniz: ");
			string? answer1 = Console.ReadLine().ToUpper();//Kullanicidan cevabi aliyoruz.Duyarlılığı ortadan kaldırmak için uppercase yapıyoruz.
			if (answer1 == "A")
			{
				Console.WriteLine("Tebrikler! Doğru Cevap");
				correctAnswerCount++;
			}
			else
			{
				Console.WriteLine("Üzgünüm! Yanlış Cevap");
			}
			Console.WriteLine("2.Soru: Atatürk hangi yıl doğmuştur?\nA) 1881\nB) 1882");
			Console.Write("Cevabınızı giriniz: ");
			string? answer2 = Console.ReadLine().ToUpper();//Kullanicidan cevabi aliyoruz.Duyarlılığı ortadan kaldırmak için uppercase yapıyoruz.
			if (answer2 == "A")
			{
				Console.WriteLine("Tebrikler! Doğru Cevap");
				correctAnswerCount++;
			}
			else
			{
				Console.WriteLine("Üzgünüm! Yanlış Cevap");
			}
			#endregion

			if (correctAnswerCount == 2)
			{
				Console.WriteLine("Tebrikler 1 Milyon Lira kazandınız...");

			}
			else if (correctAnswerCount == 1)//İlk iki sorudan birisini bilebilmişse 3. soruyu soruyoruz.
			{
				Console.WriteLine("3.Soru: Atatürk'ün annesinin adı nedir?\nA) Zübeyde Hanım\nB) Fatma Hanım");
				Console.Write("Cevabınızı giriniz: ");
				string? answer3 = Console.ReadLine().ToUpper();//Kullanicidan cevabi aliyoruz.Duyarlılığı ortadan kaldırmak için uppercase yapıyoruz.
				if (answer3 == "A")
				{
					Console.WriteLine("Tebrikler! Doğru Cevap");
					Console.WriteLine("Tebrikler 1 Milyon Lira kazandınız... ");
				}
				else
				{
					Console.WriteLine("Üzgünüm! Yanlış Cevap");
				}
			}
			else
			{
				Console.WriteLine("Üzgünüm! Hiçbir ödül kazanamadınız...");
			}
            
        }
	}
}
