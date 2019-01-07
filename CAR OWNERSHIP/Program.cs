using System;

namespace CAR_OWNERSHIP
{
	class Program
	{
		static void Main(string[] args)
		{
			int YEAROFBIRTH = 0;

			Console.WriteLine(" ENTER YEAR OF BIRTH");

			YEAROFBIRTH = Int32.Parse(Console.ReadLine());

			if (YEAROFBIRTH < 2000)

			{
				int DATEOFBIRTH = 0;

				int DRIVERSLICENSEID = 0;

				Console.WriteLine("FULL NAME: ");

				string FULLNAME = Console.ReadLine();

				Console.WriteLine("DATE OF BIRTH: ");

				DATEOFBIRTH = Int32.Parse(Console.ReadLine());

				Console.WriteLine("VEHICLE REG. CODE : ");

				string VEHICLEREGCODE = Console.ReadLine();

				Console.WriteLine("VEHICLE PLATE NUMBER: ");

				string VEHICLEPLATENUMBER = Console.ReadLine();

				Console.WriteLine("DRIVERS LICENSE ID: ");

				DRIVERSLICENSEID = Int32.Parse(Console.ReadLine());


				Console.WriteLine("FULL NAME: " + FULLNAME);
				Console.WriteLine("DATE OF BIRTH: " + DATEOFBIRTH);
				Console.WriteLine("VEHICLE REG. CODE: " + VEHICLEREGCODE);
				Console.WriteLine("VEHICLE PLATE NUMBER: " + VEHICLEPLATENUMBER);
				Console.WriteLine("DRIVERS LICENSE ID: " + DRIVERSLICENSEID);

				Console.ReadLine();
			}
			
			else
			{
				Console.WriteLine("NOT ALLOWED TO OWNER A CAR");
			}

			Console.ReadLine();
		}

		
	}	
		
	
}
		