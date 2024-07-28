using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	class Program
	{
		const string delimiter = "\n-------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.Write("Введите размеp: ");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < num * num; i++)// Hard chess
			{
				for (int j = 0; j < num * num; j++) Console.Write((i / num % 2 == j / num % 2 ? "* " : "  "));
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);// Chess board ASCII
			Console.Write((char)218);
			for (int i = 0; i < num; i++) Console.Write($"{(char)196}{(char)196}");
			Console.WriteLine((char)191);
			for (int i = 0; i < num; i++)
			{
				Console.Write((char)179);
				for (int j = 0; j < num; j++)
				{
					if (i % 2 == j % 2) Console.Write($"{(char)219}{(char)219}");
					else Console.Write("  ");
				}
				Console.WriteLine((char)179);
			}
			Console.Write((char)192);
			for (int i = 0; i < num; i++) Console.Write($"{(char)196}{(char)196}");
			Console.WriteLine((char)217);
			Console.WriteLine(delimiter);
		}

	}
}
