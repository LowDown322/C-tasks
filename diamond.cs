using System;

namespace MyFirstProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter the number of rows and *: ");

			if (int.TryParse(Console.ReadLine(), out int fixedRows))
			{
				for (int i = 1; i <= fixedRows; i++)
				{
					for (int j = 1; j <= fixedRows - i; j++)
					{
						Console.Write(" ");
					}
					for (int k = 1; k <= 2 * i - 1; k++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
				for (int i = fixedRows - 1; i >= 1; i--)
				{
					for (int j = 1; j <= fixedRows - i; j++)
					{
							Console.Write(" ");
					}
					for (int k = 1; k <= 2 * i - 1; k++)
					{
							Console.Write("*");
					}
					Console.WriteLine();
				}
			}
				else
				{
					Console.WriteLine("invalid input");
				}
			Console.ReadKey();
		}


	}
}

