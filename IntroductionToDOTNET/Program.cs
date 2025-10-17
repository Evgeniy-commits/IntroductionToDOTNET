//IntroductionToDOTNET

//#define CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("hello world!");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET");
            Console.Title = "Introduction";
            Console.Beep(50, 2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetCursorPosition");
            Console.SetCursorPosition(20, 25);
            Console.ResetColor();
            Console. 
#endif

			Console.WriteLine("Введите имя: ");
			string firstName = Console.ReadLine();

			Console.WriteLine("Введите фамилию: ");
			string lastName = Console.ReadLine();


			Console.Write("Ведите возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age);
			Console.WriteLine(String.Format("{0} {1} {2}", firstName, lastName, age));
			Console.WriteLine($"{lastName} {firstName} {age}");	

		}
	}
}
