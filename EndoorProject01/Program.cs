using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndoorProject01 //mini bio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Project Mini Bio");
			Console.WriteLine("Please enter your firstname");
			string FirstName = Console.ReadLine();
			Console.WriteLine("Please enter your lastname");
			string LastName = Console.ReadLine();
			Console.WriteLine("Please enter your adres");
			string Adres = Console.ReadLine();
			Console.WriteLine("Please enter your huisnr");
			string Huisnr = Console.ReadLine();
			Console.WriteLine("Please enter your postcode");
			string v1 = Console.ReadLine();
			string Postcode = v1;
			Console.WriteLine("Please enter your woonplaats");
			string Woonplaats = Console.ReadLine();
			Console.WriteLine("Please enter your leeftijd");
			string Leeftijd = Console.ReadLine();


			Console.WriteLine();
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(FirstName + LastName);
			Console.ResetColor();
			Console.WriteLine(Adres + Huisnr);
			Console.WriteLine(Postcode + Woonplaats);
			Console.WriteLine(Leeftijd);
		}
    }
}
