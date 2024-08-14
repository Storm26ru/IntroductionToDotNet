using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
	class Program
	{
		static string expression;
		static void Main(string[] args)
		{
			expression = "((2+3)*(5+1)-5)+1"; //Console.ReadLine();
			Console.Clear();
			top_priority(expression);
			Console.Write(expression);
			Console.WriteLine($" = {calculation(expression)}");
		}

		static double calculation(string expression)
		{
			expression = expression.Replace('.',',').Replace(" ","");
			string[] st_operands = expression.Split('+', '-', '*', '/');
			//foreach (string item in s_operands) Console.WriteLine(item);
			char[] operators = expression.Where(p => "+-*/".Contains(p)).ToArray();
			double[] db_operands = new double[st_operands.Length];
			for (int i = 0; i < st_operands.Length; i++) db_operands[i] = Convert.ToDouble(st_operands[i]);
			for (int i = 0; i < operators.Length; i++)
			{
				if (operators[i] == '*' || operators[i] == '/')
				{
					if (operators[i] == '*') db_operands[i] *= db_operands[i + 1];
					if (operators[i] == '/') db_operands[i] /= db_operands[i + 1];
					for (int j = i + 1; j < db_operands.Length - 1; j++) db_operands[j] = db_operands[j + 1];
					for (int j = i; j < operators.Length - 1; j++) operators[j] = operators[j + 1];
					db_operands[db_operands.Length - 1] = 0;
					operators[operators.Length - 1] = '\0';
				}
			}
			for (int i = 0; i < operators.Length; i++)
			{
				while (operators[i] == '+' || operators[i] == '-')
				{
					if (operators[i] == '+') db_operands[i] += db_operands[i + 1];
					if (operators[i] == '-') db_operands[i] -= db_operands[i + 1];
					for (int j = i + 1; j < db_operands.Length - 1; j++) db_operands[j] = db_operands[j + 1];
					for (int j = i; j < operators.Length - 1; j++) operators[j] = operators[j + 1];
					db_operands[db_operands.Length - 1] = 0;
					operators[operators.Length - 1] = '\0';
				}
			}
			return db_operands[0];
		}
		static void top_priority(string expression)
		{
			expression = expression.Replace('.', ',');
			for (int i = 0; i < expression.Length; i++)
			{
				if (expression[i] == '(')
				{
					for (int j = i + 1; j < expression.Length; j++)
					{
						if (expression[j] == '(')top_priority (expression.Substring(j + 1, expression.Length - j - 1)); 
						if (expression[j] == ')')
						{
							string buffer = expression.Substring(i + 1, j - i - 1); Console.WriteLine(buffer);
							if (!buffer.Contains('(') && !buffer.Contains(')'))
							{
								double result = calculation(buffer);
								Program.expression = expression.Replace($"({buffer})", result.ToString());
							}
							top_priority(Program.expression);
						}
					}
				}
				if (expression[i] == ')')
				{
					string buffer = expression.Substring(0, i);
					if (!buffer.Contains('(') && !buffer.Contains(')'))
					{
						double result = calculation(buffer);
						Program.expression = expression.Replace($"{buffer})", result.ToString());
					}
					top_priority(Program.expression);
				}
			}
			//return expression;
		}
	}
}
