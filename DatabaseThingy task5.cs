using System;
using Microsoft.Data.SqlClient;
using System.Text;

namespace sqltest
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
				builder.DataSource = "johannes-project.database.windows.net";
				builder.UserID = "johannes-project";
				builder.Password = "Bangladesh1";
				builder.InitialCatalog = "BikeStores";

				using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
				{
					Console.WriteLine("\nQuery data example:");
					Console.WriteLine("=========================================\n");

					String sql = "SELECT brand_name FROM production.brands";

					using (SqlCommand command = new SqlCommand(sql, connection))
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								//Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
								Console.WriteLine("{0}", reader.GetString(0));
							}
						}
					}
				}
			}
			catch (SqlException e)
			{
				Console.WriteLine(e.ToString());
			}
			Console.ReadLine();
		}
	}
}