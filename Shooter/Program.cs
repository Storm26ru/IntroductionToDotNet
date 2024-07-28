using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
	
	class Program
	{
		public static void move(int left_cursor, int top_cursor)
		{
			Console.Clear();
			Console.SetCursorPosition(left_cursor, top_cursor); 
			Console.Write($"{(char)177}{(char)177}");
		}
		static void Main(string[] args)
		{
			Console.SetWindowSize(100,40);
			Console.SetBufferSize(100, 40);
			Console.SetCursorPosition(50, 20);
			int left_cursor = Console.CursorLeft;
			int top_cursor = Console.CursorTop;
			Console.CursorVisible = false;
			Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
			Console.Write($"{(char)177}{(char)177}");
		
			ConsoleKey play;
			do
			{
				play = Console.ReadKey(true).Key;
				switch (play)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						if (top_cursor >0) --top_cursor; move(left_cursor, top_cursor); break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: 
						if (top_cursor < Console.BufferHeight-1) ++top_cursor; move(left_cursor, top_cursor); break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: if (left_cursor > 0) --left_cursor; move(left_cursor, top_cursor); break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: if (left_cursor < Console.BufferWidth - 2) ++left_cursor; move(left_cursor, top_cursor); break;
					default: Console.Write("Error"); break;
				}

			} while (play != ConsoleKey.Escape);
		}
	}
}
