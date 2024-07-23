using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(100,40);
			

			int height =Console.WindowHeight;
			int width = Console.WindowWidth;
			Console.WriteLine($"Параметры окна {height},{width}");
		}
	}
}
