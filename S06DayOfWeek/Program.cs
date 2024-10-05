namespace S06DayOfWeek
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Calc:
			Console.Write("Geçerli bir gün giriniz (1-7 arasında rakam ile): ");
			if (int.TryParse(Console.ReadLine(), out int num))
			{
				switch (num)
				{
					case 1:
						Console.WriteLine("Pazartesi");
						break;
					case 2:
						Console.WriteLine("Salı");
						break;
					case 3:
						Console.WriteLine("Çarşamba");
						break;
					case 4:
						Console.WriteLine("Perşembe");
						break;
					case 5:
						Console.WriteLine("Cuma");
						break;
					case 6:
						Console.WriteLine("Cumartesi");
						break;
					case 7:
						Console.WriteLine("Pazar");
						break;
					default:
						Console.WriteLine("Geçersiz bir gün girdiniz.");
						break;
				}
			}
			else
				goto Calc;
		}
	}
}
