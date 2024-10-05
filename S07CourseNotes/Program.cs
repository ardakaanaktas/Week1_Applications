namespace S07CourseGrade
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Calc:
			Console.Write("Geçerli bir not giriniz: ");

			if (int.TryParse(Console.ReadLine(), out int grd))
			{
				if (grd >= 0 && grd <= 60)
				{
					Console.WriteLine("Başarısız");
				}
				else if (grd > 60 && grd <= 80)
				{
					Console.WriteLine("Orta");

				}
				else if (grd > 80 && grd <= 100)
				{
					Console.WriteLine("Baarılı");

				}
				else
				{
					Console.WriteLine("Geçersiz Not Girildi.");
					goto Calc;
				}


			}
			else
				goto Calc;
		}
	}
}
