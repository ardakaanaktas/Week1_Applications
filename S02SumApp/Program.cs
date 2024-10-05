namespace S02SumApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Number 1: ");
			string? number_1 = Console.ReadLine();
			int number1 = Convert.ToInt32(number_1);

			Console.Write("Number 2: ");
			string? number_2 = Console.ReadLine();
			int number2 = Convert.ToInt32(number_2);

			int result = number1 + number2;
			Console.WriteLine("Result: " + result);
		}
	}
}
