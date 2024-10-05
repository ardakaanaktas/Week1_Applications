namespace S09LoginControl
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Kullanıcı şifrenizi giriniz : ");
			
			string? pass = Console.ReadLine();//Kullanıcıdan şifresini alıyoruz.

			if(pass == "12345")//Eğer şifre 1234 ise
			{
				Console.WriteLine("Giriş başarılı");//Giriş başarılı yazdırıyoruz.
			}
			else
			{
				Console.WriteLine("Giriş başarısız");//Değilse giriş başarısız yazdırıyoruz.
			}
		}
	}
}
