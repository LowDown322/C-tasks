using System;

class Program
{
    static void Main()
    {
        int gasLevel = 10;
        int distanceTraveled = 0;

        Car car = new Car();
        Motorcycle bike = new Motorcycle();

        if (!car.UserWantsToDrive)
        {
            Console.WriteLine("function not called");
        }
        else
        {
            car.Drive();
            car.OpenWindow();
            car.OpenRadio();
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

            if (input == "Y" && GasLevel != 0)
            {
                while (GasLevel >= 0 && DistanceTraveled < 10 && input == "Y")
                {
                    Console.WriteLine("Car goes wroooom");
                    Console.WriteLine($"You just spent {DistanceTraveled} km on the road");
                    Console.WriteLine($"You have {GasLevel} liters left in the tank");

                    DistanceTraveled++;
                    GasLevel--;
                    Console.WriteLine("Drive again? (Y/N)");
                    input = Console.ReadLine().Trim().ToUpper();
                }

            }
            else if (input == "N" && DistanceTraveled != 0)
            {
                Console.WriteLine("Enter 'Y' to drive");
                UserWantsToDrive = false;
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
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The car accelerates smoothly.");
            base.Drive();
        }
    }

    class Motorcycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The motorcycle revs up.");
            base.Drive();
            Console.WriteLine("The motorcycle goes vrooooooom");
        }
    }
}
