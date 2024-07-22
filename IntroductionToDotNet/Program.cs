//#define CONSOLE_PARAMETERS
//#define INPUT_DATA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDotNet
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Introduction to .NET";

#if CONSOLE_PARAMETERS
			Console.Beep(37, 2000);
			Console.BackgroundColor = ConsoleColor.Blue;
			//Console.CursorLeft = 22;
			//Console.CursorTop = 11;
			Console.SetCursorPosition(22, 7);
			Console.Write("Hellow .NET"); // Выводите строку на экран
			Console.WriteLine("Introduction");// Выводит строку на экран и переводит курсор в начало следующей строки
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ResetColor(); 
#endif

#if INPUT_DATA
			Console.Write("Введите ваше имя: ");
			string name = Console.ReadLine();
			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();
			Console.Write("Введите ваш возраст:");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ваше имя: " + name + " Ваша фамилия: " + last_name + "Ваш возраст: " + age); //Конкатенация строк
			Console.WriteLine(String.Format("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2}", name, last_name, age)); //Форматирование строк
			Console.WriteLine($"Ваше имя: {name}, Ваша фамилия: {last_name},Ваш возраст: {age}");//Интерполяция строк  
#endif
			int num = 5;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{

					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
				}
				Console.WriteLine();

				//Console.Clear();
			}
		}
	}
}
