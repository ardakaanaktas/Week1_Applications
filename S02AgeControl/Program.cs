namespace S02AgeControl
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Yaşınızı giriniz: ");
			string? age = Console.ReadLine();
			int ageInt = Convert.ToInt32(age);

			#region Method1
			if (ageInt >= 18)
			{
				Console.WriteLine("Yetişkinsiniz.");
			}
			else
			{
				Console.WriteLine("Çocuksunuz.");
			}
			#endregion
			#region Method2
			string result = ageInt >= 18 ? "Yetişkinsiniz." : "Çocuksunuz.";
			Console.WriteLine(result);
			#endregion
		}
	}
}
