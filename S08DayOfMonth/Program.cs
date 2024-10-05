namespace S08DayOfMonth
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Geçerli ay numarası giriniz : ");

			if(int.TryParse(Console.ReadLine(), out int month))
			{
				if (Enum.IsDefined(typeof(Months), month))//Burada enum içerisindeki değerlerin kontrolünü yapıyoruz.
				{
					if (month == 2)//Şubat ayı için özel bir durum oluşturduk.
					{
						Console.WriteLine($"{(Months)month} ayı 28 veya 29 gün içerir.");
					}
					else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)//31 gün içeren aylar
					{
						Console.WriteLine($"{(Months)month} ayı 31 gün içerir.");
					}
					else//Bunun dışında kalanların hepsi 30 gün içerir.
					{
						Console.WriteLine($"{(Months)month} ayı 30 gün içerir.");
					}
				}
				else//Eğer enum içerisinde olmayan bir değer girilirse buraya düşer.
				{
					Console.WriteLine("Geçerli bir ay numarası giriniz.");
				}
			}
			else //Eğer int tipinde bir değer girilmezse buraya düşer.
			{
				Console.WriteLine("Geçerli bir ay numarası giriniz.");
			}
		}

        enum Months
        {
            Ocak = 1,
			Subat = 2,
			Mart = 3,
			Nisan = 4,
			Mayis = 5,
			Haziran = 6,
			Temmuz = 7,
			Agustos = 8,
			Eylul = 9,
			Ekim = 10,
			Kasim = 11,
			Aralik = 12
		}
    }
}
