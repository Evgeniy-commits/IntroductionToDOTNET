using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    string simbol = "--*--";
			int x = 0, y = 0;
			
			Console.CursorVisible = false;
			Write (simbol, x, y);
			while (Console.ReadKey().Key != ConsoleKey.Escape)
			{
				//switch (Console.ReadKey().Key)
				//{
				//	case ConsoleKey.LeftArrow:
				//		if (x > 0) x--; break;
				//	case ConsoleKey.RightArrow:
				//		x++; break;
				//	case ConsoleKey.UpArrow:
				//		if (y > 0) y--; break;
				//	case ConsoleKey.DownArrow:
				//		y++; break;
				//}

				if (Console.ReadKey().Key == ConsoleKey.LeftArrow || Console.ReadKey().Key == ConsoleKey.A)
				{ if (x > 0) x--; }
				else if (Console.ReadKey().Key == ConsoleKey.RightArrow || Console.ReadKey().Key == ConsoleKey.D)
				{ x++; }
				else if (Console.ReadKey().Key == ConsoleKey.UpArrow || Console.ReadKey().Key == ConsoleKey.W)
				{ if (y > 0) y--; }
				else if (Console.ReadKey().Key == ConsoleKey.DownArrow || Console.ReadKey().Key == ConsoleKey.S)
				{ y++; }

				Write(simbol, x, y);
			}
		}
		static void Write(string simbol, int x, int y)
		{
			if (x >= 0 && y >= 0)
				{
					Console.Clear();
					Console.SetCursorPosition(x, y);
					Console.WriteLine(simbol);
				}
		}
			
	}
}