using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string expression = Console.ReadLine();
			Console.Clear();
			string[] operand = expression.Split('+', '-', '/', '*');
			char operators = expression[expression.IndexOfAny(new char[]{ '+', '-', '/', '*'})];
			switch (operators)
			{
				case '+': Console.WriteLine($" {operand[0]} + {operand[1]} = {Convert.ToDouble(operand[0]) + Convert.ToDouble(operand[1])}"); break;
				case '-': Console.WriteLine($" {operand[0]} - {operand[1]} = {Convert.ToDouble(operand[0]) - Convert.ToDouble(operand[1])}"); break;
				case '*': Console.WriteLine($" {operand[0]} * {operand[1]} = {Convert.ToDouble(operand[0]) * Convert.ToDouble(operand[1])}");break;
				case '/': 
					if(operand[0]!="0") Console.WriteLine($" {operand[0]} / {operand[1]} = {Convert.ToDouble(operand[0]) / Convert.ToDouble(operand[1])}"); 
					else Console.WriteLine("Деление на ноль"); break;
			}
		}
	}
}
