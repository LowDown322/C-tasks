using System;
using System.Net;

class Program
{
	public static int gasLevel = 10;
	public static int distanceTraveled;
	public static bool userWantsToDriveCar;
	public static bool userWantsToDriveBike;
	static void Main()
	{

		Car car = new Car();
		
		Motorcycle bike = new Motorcycle();
		Ecar ecar = new Ecar();
		car.model = "BMW";
		car.color = "red";
		car.year = 4;
		bike.model = "Harley Davidson";
		bike.color = "Black";
		bike.year = 5;
		if (!car.UserWantsToDrive == true)
		{
			userWantsToDriveCar = true;
			Console.WriteLine("function not called");
		}
		else
		{
			userWantsToDriveCar= false;
			car.Drive();
			car.OpenWindow();
			car.OpenRadio();
			// car.RefillTank();
			bike.Drive();
			bike.PutHelmetOn();
			ecar.Drive();
			

		}
	}

	class Vehicle
	{
		public int GasLevel { get; set; } = 10;
		public int DistanceTraveled { get; set; } = 0;
		public bool UserWantsToDrive { get; set; } = true;

		public virtual void Drive()
		{
			GasLevel = 10;
			DistanceTraveled = 0;
			Console.WriteLine("Wanna drive? (Y/N)");
			string input = Console.ReadLine().Trim().ToUpper();

			if (input == "Y" && gasLevel != 0)
			{
				while (gasLevel >= 0 && DistanceTraveled < 10 && input == "Y")
				{
					Console.WriteLine("Car goes wroooom");
					Console.WriteLine($"You just spent {DistanceTraveled} km on the road");
					Console.WriteLine($"You have {gasLevel} liters left in the tank");

					DistanceTraveled++;
					gasLevel--;
					Console.WriteLine("Continue driving? (Y/N)");
					input = Console.ReadLine().Trim().ToUpper();
					if(gasLevel == 0)
					{
						Console.WriteLine("insufficient gaslevel");
						RefillTank();
						break;
					}
				}

			}
			else if (input == "N" && gasLevel == 0)
			{
				Console.WriteLine("Enter 'Y' to drive");
				UserWantsToDrive = false;
			}
			else 
			{
				Console.WriteLine("tank is empty");
			}
		}

		public virtual void OpenWindow()
		{
			Console.WriteLine("Do you want to open the window? (Y/N)");
			string input = Console.ReadLine().ToUpper();

			if (input.Equals("Y"))
			{
				Console.WriteLine("Aah, fresh air");
			}
			else if (input.Equals("N"))
			{
				Console.WriteLine("Window is closed");
			}
			else
			{
				Console.WriteLine("Enter 'Y' or 'N'");
			}
		}

		public virtual void OpenRadio()
		{
			Console.WriteLine("Do you want to turn on the radio? (Y/N)");
			string input = Console.ReadLine().ToUpper();

			if (input.Equals("Y"))
			{
				Console.WriteLine("Open car radio");
				Console.WriteLine("Jeeee, rock'n roll!");
			}
			else if (input.Equals("N"))
			{
				Console.WriteLine("the radio stays off");
			}
			else
			{
				Console.WriteLine("Enter 'Y' or 'N'");
			}
		}
		public void RefillTank()
		{
			Console.WriteLine("Do you wanna fill up the tank? y/n");
			string input = Console.ReadLine().ToUpper();
			if (input.Equals("Y"))
			{
				while (gasLevel < 1 && gasLevel < 11)
				{
					while (gasLevel < 10)
					{
						gasLevel++;
						Console.WriteLine($"the tank is filling up, currently at {gasLevel} liters");


					}
					if (gasLevel == 10)
					{
						Console.WriteLine("the tank is now full, ready to roll again!");
					}
					else
					{
						Console.WriteLine("....");
					}
				}
			}
		}
	}

	class Car : Vehicle
	{
		public string model;
		public string color;
		public int year;
		public override void Drive()
		{
			Console.WriteLine("The car accelerates smoothly.");
			base.Drive();
		}

	}
	

	class Motorcycle : Vehicle
	{
		public string model;
		public string color;
		public int year;
		public override void Drive()
		{
			Console.WriteLine("Wanna drive? (Y/N)");
			string input = Console.ReadLine().Trim().ToUpper();

			if (input == "Y" && gasLevel != 0)
			{
				while (gasLevel >= 0 && DistanceTraveled < 10 && input == "Y")
				{
					Console.WriteLine("bike goes vrooooom");
					Console.WriteLine($"You just spent {DistanceTraveled} km on the road");
					Console.WriteLine($"You have {gasLevel} liters left in the tank");

					DistanceTraveled++;
					gasLevel--;
					Console.WriteLine("Continue driving? (Y/N)");
					input = Console.ReadLine().Trim().ToUpper();
					if (gasLevel == 0)
					{
						Console.WriteLine("insufficient gaslevel");
						RefillTank();
						base.Drive();
						break;
					}
				}
			}
		} 
		public void PutHelmetOn() 
		{
		
			Console.WriteLine("do you want to put the helmet on? Y/N");
			string input2 = Console.ReadLine().ToUpper();
			if (input2.Equals("Y"))
			{
				Console.WriteLine("helmet suits well....");
				Console.WriteLine("nice and safe!");
			}
			else
			{
				Console.WriteLine("fine who needs helmets anyway..");
			}
		}
	}
	class Ecar : Vehicle
	{
		public override void Drive()
		{
			base.Drive();
			Console.WriteLine("E-car goes Ssssssshhhhhh");
		}
	}
}
