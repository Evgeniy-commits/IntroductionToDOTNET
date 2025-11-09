using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
	internal class Program
	{
		static readonly int x = 80;
		static readonly int y = 26;
		static void Main(string[] args)
		{
			Console.SetWindowSize(x + 1, y + 1);
			Console.SetBufferSize(x + 1, y + 1);
			Console.CursorVisible = false;
		}

		struct Point
		{
			public int x { get; set; }
			public int y { get; set; }
			public char ch { get; set; }

			public static implicit operator Point((int, int, char) value) =>
				new Point { x = value.Item1, y = value.Item2, ch = value.Item3 };
			public void Draw()
			{
				DrawPoint(ch);
			}
			public void Clear()
			{
				DrawPoint(' ');
			}
			private void DrawPoint(char ch)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(ch);
			}
		}
		class Walls
		{
			private char ch;
			private List<Point> wall = new List<Point>();
			public Walls(int x, int y, char ch)
			{
				this.ch = ch;
				DrawHorizontal(x, 0);
				DrawHorizontal(x, y);
				DrawVertical(0, y);
				DrawVertical(x, y);
			}
			private void drawHorizontal(int x, int y)
			{
				for (int i = 0; i < x; i++)
				{
					Point p = (x, i,  ch);
					p.Draw();
					wall.Add(p);
				}
			}
		}
		
	}
}
