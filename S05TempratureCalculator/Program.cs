namespace S05TempratureCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Calc:
			Console.Write("Geçerli hava sıcaklığını giriniz: ");

			if (int.TryParse(Console.ReadLine(), out int temprature))
			{
				if (temprature < 0)
				{
					Console.WriteLine("Donuyor...");
				}
				else if (temprature <= 30 && temprature > 0)
				{
					Console.WriteLine("Normal");
				}
				else
					Console.WriteLine("Yanıyor");
			}
			else
				goto Calc;
		}
	}
}
