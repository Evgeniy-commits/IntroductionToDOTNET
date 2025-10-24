using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double a, b;
			char sign;
			Console.Write("Введите первый операнд: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите действие: ");
			sign = Convert.ToChar(Console.ReadLine());
			Console.Write("Введите второй операнд: ");
			b = Convert.ToDouble(Console.ReadLine());

			switch (sign)
			{
				case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
				case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
				case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
				case '/': Console.WriteLine(b == 0 ? "На 0 делить нельзя!" : $"{a} / {b} = {a / b}"); break;
				default: Console.WriteLine("неверно введен знак операции"); break;
			}
		}
	}
}
