#define TASK_0
#define TASK_1
#define TASK_2
#define TASK_3
#define TASK_4
#define TASK_5
#define TASK_6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Program
	{
		const string delimiter = "\n-------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.Write("Введите размеp: ");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < num; i++) //TASK_0
			{
				for (int j = 0; j < num; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < num; i++) //TASK_1
			{
				for (int j = 0; j <= i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for(int i =0; i<num; i++) //TASK_2
			{
				for (int j = i; j < num; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for(int i = 0; i<num; i++) //TASK_3
			{
				for (int k = 0; k < i; k++) Console.Write(" ");
				for (int j = i; j < num; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for(int i = 0; i<num; i++) //TASK_4
			{
				for (int k = 0; k < num - 1 - i; k++) Console.Write(" ");
				for (int j = 0; j <= i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for(int i =0; i<num*2; i++)
			{

			}
			
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{

					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
				}
				Console.WriteLine();
			}
		}
	}
}
