using System;

namespace Work
{
	class Program
	{
		static void Main()
		{
			double x = 0, y = 0;
			Console.Write("Enter your first number : ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter your second number : ");
			y = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter your string : ");
			string str = Console.ReadLine();
			Console.Write("Enter count review : ");
			int N = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(MAX(x, y));
			Console.WriteLine(MIN(x, y));
			Console.WriteLine(Repeat(str, N));
			Console.WriteLine(TrySumIfOdd(x, y));
		}

		static double MAX(double a, double b)
		{
			if (a > b)
			{
				Console.Write("MAX : ");
				return a;
			}
			else
			{
				Console.Write("MAX : ");
				return b;
			}
		}
		static double MIN(double a, double b)
		{
			if (a < b)
			{
				Console.Write("MIN : ");
				return a;
			}
			else
			{
				Console.Write("MIN : ");
				return b;
			}
		}
		static double TrySumIfOdd(double a, double b)
		{
			double sum = a + b;
			if ((a+b) % 2 != 0)
			{
				return sum;
			}
			else
			{
				return sum;
			}
		}

		static string Repeat(string str, int N)
		{
			string new_STR = "";
			for (int i = 0; i < N; i++)
			{
				new_STR += str;
			}
			return new_STR;
		}
	}
}
