using System;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace OpenWeatherMapExample {
    class Program {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args) {
            string city = "Foz do Iguacu";
            string countryCode = "BR";
            string apiKey = "e0e2bd8dadd9fd3294abcf39204db1c4";
            //string url = "http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=e0e2bd8dadd9fd3294abcf39204db1c4";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city},{countryCode}&appid={apiKey}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {
                string responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
            } else {
                Console.WriteLine($"Erro ao fazer a solicitação:  {response.StatusCode}");
            }
            Console.ReadLine();
        }
    }
}