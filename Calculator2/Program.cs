﻿using System;
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
			//expression =  Console.ReadLine();
			expression = "22+(33-8)*(4+7)/8"; //Console.ReadLine();
			Console.WriteLine(top_priority(expression));
			Console.WriteLine($"Ответ: {calculation(expression)}");
		}

		static string top_priority(string expression)
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
							string buffer = expression.Substring(i + 1, j - i - 1);
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
			return expression;
		}

		static double calculation(string expression)
		{
			expression = expression.Replace('.',',').Replace(" ","");
			string[] s_operands = expression.Split('+', '-', '*', '/');
			//foreach (string item in s_operands) Console.WriteLine(item);
			char[] operators = expression.Where(p => "+-*/".Contains(p)).ToArray();
			double[] d_operands = new double[s_operands.Length];
			for (int i = 0; i < s_operands.Length; i++) d_operands[i] = Convert.ToDouble(s_operands[i]);
			for (int i = 0; i < operators.Length; i++)
			{
				while (operators[i] == '*' || operators[i] == '/')
				{
					if (operators[i] == '*') d_operands[i] *= d_operands[i + 1];
					if (operators[i] == '/') d_operands[i] /= d_operands[i + 1];
					for (int j = i + 1; j < d_operands.Length - 1; j++) d_operands[j] = d_operands[j + 1];
					for (int j = i; j < operators.Length - 1; j++) operators[j] = operators[j + 1];
					d_operands[d_operands.Length - 1] = 0;
					operators[operators.Length - 1] = '\0';
				}
			}

			for (int i = 0; i < operators.Length; i++)
			{
				while (operators[i] == '+' || operators[i] == '-')
				{
					if (operators[i] == '+') d_operands[i] += d_operands[i + 1];
					if (operators[i] == '-') d_operands[i] -= d_operands[i + 1];
					for (int j = i + 1; j < d_operands.Length - 1; j++) d_operands[j] = d_operands[j + 1];
					for (int j = i; j < operators.Length - 1; j++) operators[j] = operators[j + 1];
					d_operands[d_operands.Length - 1] = 0;
					operators[operators.Length - 1] = '\0';
				}
			}
			return d_operands[0];
		}
	}
}