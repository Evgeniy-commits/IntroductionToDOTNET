//#define UPPER_LEFT_ANGLE         "\xDA"                        
//#define LOWER_LEFT_ANGLE         "\xC0"                            
//#define VERTICAL_LINE            "\xB3"                       
//#define WHITE_BOX                "\xDB\xDB"             
//#define BLACK_BOX                "\x20\x20"
//#define SPACE                    "\x20"
//#define SP                       ' '
//#define SP_STAR                  '*'
//#define STAR                     "\x2A"
//#define HOR_UPPER_RIGHT_ANGLE    "\xC4\xBF\n"
//#define HOR_LOWER_RIGHT_ANGLE    "\xC4\xD9"
//#define HOR_HORIZONTAL_LINE      "\xC4\xC4"
//#define SP_VERTICAL_LINE         "\x20\xB3"

//#define SQUARD
//#define TRIANGLE_A
//#define TRIANGLE_B
//#define TRIANGLE_C
//#define TRIANGLE_D
//#define ROMB
#define BIG_CHESS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{

	internal class Program
	{
		enum Simbol
		{
			UPPER_LEFT_ANGLE = 0x250C,
			LOWER_LEFT_ANGLE = 0x2514,
			VERTICAL_LINE = 0x2502,
			WHITE_BOX = 0x2591,
			BLACK_BOX = 0x2588,
			SPACE = ' ',
			STAR = '*',
			UPPER_RIGHT_ANGLE = 0x2510,
			LOWER_RIGHT_ANGLE = 0x2518,
			HORIZONTAL_LINE = 0x2500,
		}
		static void Main(string[] args)
		{
#if SQUARD
			Console.Write ("Введите длину стороны квадрата: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{

				for (int j = 0; j < n; j++)
				{
					Console.Write(" *");
				}
				Console.WriteLine();
			}
#endif // SQUARD

#if TRIANGLE_A
			Console.Write("Введите высоту треугольника: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{

				for (int j = n; i <= j; j--)
				{
					Console.Write (" *");
				}
				Console.WriteLine();
			}
#endif // TRIANGLE_A

#if TRIANGLE_B
			//Console.Write("Введите высоту треугольника: ");
			//int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{

				for (int j = 1; j <= i; j++)
				{
					Console.Write (" *");
				}
				Console.WriteLine();
			}
#endif // TRIANGLE_B

#if TRIANGLE_C
			//Console.Write("Введите высоту треугольника: ");
			//int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				for (int k = 0; k < i; k++)
				{
					Console.Write("  ");
				}

				for (int j = n; j >= i; j--)
				{
					Console.Write(" *");
				}
				Console.WriteLine();
			}
#endif // TRIANGLE_C

#if TRIANGLE_D
			//Console.Write("Введите высоту треугольника: ");
			//int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				for (int k = n; k >= i; k--)
				{
					Console.Write("  ");
				}

				for (int j = 0; j < i; j++)
				{
					Console.Write(" *");
				}
				Console.WriteLine();
			}
#endif // TRIANGLE_D

#if ROMB
			Console.Write("Введите сторону ромба: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				for (int j = n - 1; j > i; j--) Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i; j++)	Console.Write("  ");
				Console.WriteLine("\\");
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++)	Console.Write(" ");
				Console.Write("\\");
				for (int j = n - 1; j > i; j--) Console.Write("  ");
				Console.WriteLine("/");
			}
#endif // ROMB



#if BIG_CHESS
			Console.Write("Введите размер доски: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i <= n * n + 1; i++)
			{
				for (int j = 0; j <= n * n + 1; j++)
				{
					//Console.Write
					if (i == 0 && j == 0) Console.Write(Convert.ToChar(Simbol.UPPER_LEFT_ANGLE));
					else if (j > 0 && j <= n * n && i == 0 || j > 0 && j <= n * n && i == n * n + 1)
						Console.Write(String.Format("{0}{1}", Convert.ToChar(Simbol.HORIZONTAL_LINE), Convert.ToChar(Simbol.HORIZONTAL_LINE)));
					else if (i == 0 && j == n * n + 1)
						Console.Write(String.Format("{0}{1} {2}", Convert.ToChar(Simbol.HORIZONTAL_LINE), Convert.ToChar(Simbol.UPPER_RIGHT_ANGLE), "\n"));
					else if (i == n * n + 1 && j == 0) Console.Write(Convert.ToChar(Simbol.LOWER_LEFT_ANGLE));
					else if (i == n * n + 1 && j == n * n + 1)
						Console.Write(String.Format("{0}{1}", Convert.ToChar(Simbol.HORIZONTAL_LINE), Convert.ToChar(Simbol.LOWER_RIGHT_ANGLE)));
					if (i >= 1 && j >= 1 && i <= n && j <= n)
					{
						for (int k = 0; k < n; k++)
						{
							if (i > 0 && i <= n && k == 0) 
								Console.Write(Convert.ToChar(Simbol.VERTICAL_LINE));
							if (i % 2 != k % 2)
							{
								for (int b = 0; b < n; b++) 
									Console.Write(String.Format("{0}{1}", Convert.ToChar(Simbol.WHITE_BOX), Convert.ToChar(Simbol.WHITE_BOX)));
							}
							else
							{
								for (int c = 0; c < n; c++) 
									Console.Write(String.Format("{0}{1}", Convert.ToChar(Simbol.SPACE), Convert.ToChar(Simbol.SPACE)));
							}
							if (i >= 0 && i <= n && k == n - 1) 
								Console.Write(String.Format("{0}{1}", Convert.ToChar(Simbol.SPACE), Convert.ToChar(Simbol.VERTICAL_LINE)));
						}
						Console.WriteLine();
					}
				}
			}
			//Console.Write(String.Format("{0} {1}", Convert.ToChar(Simbol.STAR), Convert.ToChar(Simbol.STAR)));
			//Console.WriteLine(Convert.ToChar(Simbol.STAR));
#endif // BIG_CHESS
		}
	}
}




