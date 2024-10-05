namespace ControlStructures
{
	internal class Program
	{
		static void Main(string[] args)
		{
		GetNum:
			Console.Write("Geçerli bir sayı giriniz: ");
		
			if (int.TryParse(Console.ReadLine(), out int num))
			{
				if (num < 10)
				{
					Console.WriteLine("Sayı 10 dan küçüktür.");
				}
				else if (num == 10)
				{
					Console.WriteLine("Sayı 10'a eşittir.");
				}
				else
				{
					Console.WriteLine("Sayı 10 dan büyüktür.");
				}

                if (num % 2 == 0)
                {
                    Console.WriteLine("Girilen Sayı çifttir.");
                }
                else
                {
                    Console.WriteLine("Girilen Sayı tektir.");
                }
            }
			else
			{
				Console.WriteLine("Geçerli bir sayı girmediniz.");
				goto GetNum;
			}
		}
	}
}
