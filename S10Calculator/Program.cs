namespace S10Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1,number2;
		number1:
            Console.Write("Lütfen sayı 1'i giriniz: ");
			if(int.TryParse(Console.ReadLine(), out  number1))
			{
				number2:
                Console.Write("Lütfen sayı2'yi giriniz: ");
                if (int.TryParse(Console.ReadLine(),out  number2))
                {
                    
                }else
				{
					Console.WriteLine("Lütfen sayı 2 için geçerli bir değer giriniz.");
					goto number2;
				}
			}
			else
			{
				Console.WriteLine("Lütfen sayı 1 için geçerli bir değer giriniz.");
				goto number1;
			}

			Calculator:
            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+,-,*,/): ");
			string operation = Console.ReadLine();
			switch (operation)
			{
				case "+":
					Console.WriteLine($"Sonuç: {number1 + number2}");
					break;
				case "-":
					Console.WriteLine($"Sonuç: {number1 - number2}");
					break;
				case "*":
					Console.WriteLine($"Sonuç: {number1 * number2}");
					break;
				case "/":
					Console.WriteLine($"Sonuç: {number1 / number2}");
					break;
				default:
					Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
					goto Calculator;
					
			}
		}
	}
}
