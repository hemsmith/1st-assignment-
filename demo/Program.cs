using System;

namespace demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter  your name: ");

			string personName = Console.ReadLine();

			Console.WriteLine("Enter  your Age: ");

			string age = Console.ReadLine();

			Console.WriteLine("Hello " + personName);

			Console.WriteLine("Your age is: " + age);

			Console.ReadLine();
		}
	}
}
