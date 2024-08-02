//#define CONSOLE_PARAMETERS
//#define INPUT_DATA
//#define DATA_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntroductionToDotNet
{
	class Program
	{
		static readonly string delimiter = "\n-------------------------------------------------------------\n";
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
			/*Console.WriteLine("CHAR");
			Console.WriteLine(sizeof(char));
			Console.WriteLine(char.MinValue);
			Console.WriteLine((int)char.MaxValue);*/
#if DATA_TYPES
			Console.WriteLine("SHORT");
			Console.WriteLine($"Переменная типа short занимает {sizeof(short)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {ushort.MinValue}......{ushort.MaxValue}");
			Console.WriteLine($"ushort: {short.MinValue}......{short.MaxValue}");
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа int занимает {sizeof(int)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {uint.MinValue}......{uint.MaxValue}");
			Console.WriteLine($"ushort: {int.MinValue}......{int.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Int32 ");
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа long занимает {sizeof(long)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {ulong.MinValue}......{ulong.MaxValue}");
			Console.WriteLine($"ushort: {long.MinValue}......{long.MaxValue}");
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа float занимает {sizeof(float)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {float.MinValue}......{float.MaxValue}");
			Console.WriteLine("Класс-обвертка singl");
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа double занимает {sizeof(double)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {double.MinValue}......{double.MaxValue}");
			Console.WriteLine(delimiter);
			Console.WriteLine($"Переменная типа decimal занимает {sizeof(decimal)} байт памяти и принимает значения в диапазоне");
			Console.WriteLine($"ushort: {decimal.MinValue}......{decimal.MaxValue}");
			Console.WriteLine(delimiter); 
#endif
#if LITERALS
			Console.WriteLine(((object)5.0m).GetType());
			Console.WriteLine('+'.GetType()); 
#endif
			/*int a = 2000000000;
			int b = 5;
			//a = b; //CS0266 ошибка (неявное преобразование)
			//uint c = (uint)b; // явное преобразование типов 
			Console.WriteLine((a * b).GetType());*/

			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			/*long f = 1;
			int i = 1;
			try
			{
				for (; i < n; i++)
				{
					f *= i;
					Console.WriteLine($"{i}!={f}");
				}
			Console.WriteLine($"Конечный результат; {--i}! = {f};");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				i--;
			}
			Console.WriteLine($"последний правильный результат; {i}! = {f};");*/
			BigInteger f = 1;
			int i = 1;

			{
				for (; i < n; i++)
				{
					f *= i;
					Console.WriteLine($"{i}!={f}");
				}
				Console.WriteLine($"Конечный результат; {--i}! = {f};");
			}
		}
	}
}
