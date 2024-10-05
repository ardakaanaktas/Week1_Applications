namespace S04OddEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Soru:
			Console.Write("Bir sayı giriniz: ");
			if (int.TryParse(Console.ReadLine(), out int number))
			{
				Console.WriteLine(number % 2 == 0 ? "Çift sayıdır." : "Tek sayıdır");
			}
			else
				goto Soru;

		}
	}
}
