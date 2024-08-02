using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
	class Program
	{
		static void Main(string[] args)
		{
			string expression = "5+3*6/7-3"; //Console.ReadLine();
			string s_operators = "+-*/";
			string[] s_operands = expression.Split('+', '-', '*', '/');
			double[] d_operands = new double[s_operands.Length];
			for (int i = 0; i < s_operands.Length; i++) d_operands[i] = Convert.ToDouble(s_operands[i]);
			char[] c_operators = expression.Where(p => s_operators.Contains(p)).ToArray();
			//foreach (char op in c_operators) Console.WriteLine(op);
			for(int i =0; i<c_operators.Length; i++)
			{
				if (c_operators[i] == '*') d_operands[i] *= d_operands[i + 1];
				if (c_operators[i] == '/') d_operands[i] /= d_operands[i + 1];
				for(int j = )
			}
			
		}
	}
}
