using Newtonsoft;
using Newtonsoft.Json;

namespace Json_6_task
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var httpClient = new HttpClient();
			string url = "https://mocki.io/v1/d4867d8b-b5d5-4a48-a4ab-79131b5809b8";
			// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

			string jsonString = "[{\"name\":\"Harry Potter\",\"city\":\"London\"},{\"name\":\"Don Quixote\",\"city\":\"Madrid\"},{\"name\":\"Joan of Arc\",\"city\":\"Paris\"},{\"name\":\"Rosa Park\",\"city\":\"Alabama\"}]";
			try
			{
				var httpResponseMessage = await httpClient.GetAsync(url);
				
				string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

				Console.WriteLine(jsonResponse);

				var characters = JsonConvert.DeserializeObject<List<Root>>(jsonResponse);

				foreach (var character in characters) 
				{
					Console.WriteLine("Name:" + character.name);
					Console.WriteLine("City:" + character.city + "\n");
				}
				Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				httpClient.Dispose();
			}
				Console.WriteLine("Hello, World!");

		}
		public class Root
		{
			public string name { get; set; }
			public string city { get; set; }
		}
	}
}