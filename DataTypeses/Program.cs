#define DATATYPES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeses
{
	internal class Program
	{
		const string delimiter = "\n-------------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if DATATYPES
		
			Console.WriteLine($"bool занимает  {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(typeof(bool));

			Console.WriteLine(delimiter);

			Console.WriteLine($@"Тип данных char занимает {sizeof(char)} байт памяти и принимает значение в
			диапазоне {(int)char.MinValue} до {(int)char.MaxValue} Класс обвертка - {typeof(char)}");

			Console.WriteLine(delimiter);

			Console.WriteLine($@"byte занимает {sizeof(byte)} Байт памяти, и принимает 
			значения в диапазоне от {byte.MinValue} до {byte.MaxValue},
			Класс обвертка - {typeof(byte)}");

			Console.WriteLine(delimiter);

			Console.WriteLine($@"sbyte занимает {sizeof(sbyte)} Байт памяти, и принимает 
			значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue},
			Класс обвертка - {typeof(sbyte)}");

			Console.WriteLine(delimiter);
			Console.WriteLine($@"short занимает {sizeof(short)} Байт памяти, и принимает 
			значения в диапазоне от {short.MinValue} до {short.MaxValue},
			Класс обвертка - {typeof(short)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"ushort занимает {sizeof(ushort)} Байт памяти, и принимает 
			значения в диапазоне от {ushort.MinValue} до {ushort.MaxValue},
			Класс обвертка - {typeof(ushort)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"int занимает {sizeof(int)} Байт памяти, и принимает 
			значения в диапазоне от {int.MinValue} до {int.MaxValue},
			Класс обвертка - {typeof(int)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"uint занимает {sizeof(uint)} Байт памяти, и принимает 
			значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
			Класс обвертка - {typeof(uint)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"int занимает {sizeof(int)} Байт памяти, и принимает 
			значения в диапазоне от {int.MinValue} до {int.MaxValue},
			Класс обвертка - {typeof(int)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"uint занимает {sizeof(uint)} Байт памяти, и принимает 
			значения в диапазоне от {uint.MinValue} до {uint.MaxValue},
			Класс обвертка - {typeof(uint)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"long занимает {sizeof(long)} Байт памяти, и принимает 
			значения в диапазоне от {long.MinValue} до {long.MaxValue},
			Класс обвертка - {typeof(long)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"ulong занимает {sizeof(ulong)} Байт памяти, и принимает 
			значения в диапазоне от {ulong.MinValue} до {ulong.MaxValue},
			Класс обвертка - {typeof(ulong)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"float занимает {sizeof(float)} Байт памяти, и принимает 
			значения в диапазоне от {float.MinValue} до {float.MaxValue},
			Класс обвертка - {typeof(float)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"double занимает {sizeof(double)} Байт памяти, и принимает 
			значения в диапазоне от {double.MinValue} до {double.MaxValue},
			Класс обвертка - {typeof(double)}");
			
			Console.WriteLine(delimiter);
			Console.WriteLine($@"decimal занимает {sizeof(decimal)} Байт памяти, и принимает 
			значения в диапазоне от {decimal.MinValue} до {decimal.MaxValue},
			Класс обвертка - {typeof(decimal)}");
#endif



		}
	}
}
