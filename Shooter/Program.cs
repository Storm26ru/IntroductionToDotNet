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
			Console.SetCursorPosition(50, 20);
			int left_cursor = Console.CursorLeft;
			int top_cursor = Console.CursorTop;
			Console.CursorVisible = false;
			Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
			Console.Write($"{(char)177}{(char)177}");
			int height =Console.WindowHeight;
			int width = Console.WindowWidth;
			/*for (int i = 0; i < 256; i++)
			{
				if (i % 16 == 0) Console.WriteLine();
				Console.Write((char)i + " "+i+" ");
			}*/
			ConsoleKey play;
			do
			{
				play = Console.ReadKey().Key;
				switch (play)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: move(left_cursor, --top_cursor); break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: move(left_cursor, ++top_cursor); break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: move(--left_cursor, top_cursor); break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: move(++left_cursor, top_cursor); break;
				}

			} while (play != ConsoleKey.Escape);
		}
	}
}
