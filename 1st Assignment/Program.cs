using System;

namespace _1st_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = 0;
			int number2 = 0;
			int sum = 0;

			Console.WriteLine("Hello enter first number: ");

			number1 = Int32.Parse(Console.ReadLine());

			Console.WriteLine("enter second number: ");

			number2 = Int32.Parse(Console.ReadLine());

			sum = number1 + number2;

			Console.WriteLine("The sum of the values are: " + sum);

			Console.ReadLine();
		}
	}
}
