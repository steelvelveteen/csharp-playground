using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Talking to Hubaloo API");
            GetData();
            // Login();

        }

        static async void GetData()
        {
            HttpClient _http = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/todos/1";
            // string url = "http://localhost:5000/weatherforecast";

            Task<HttpResponseMessage> httpResponse = _http.GetAsync(url);
            HttpResponseMessage response = httpResponse.Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Is your api running? Is your postgres db service up and running?");
                Console.WriteLine($"{response.ReasonPhrase} | {(int)response.StatusCode}");
            }

            var customerJsonString = await response.Content.ReadAsStringAsync();
            var deserialized = JsonConvert.DeserializeObject(customerJsonString);

            Console.WriteLine(deserialized);
            _http.Dispose();
        }

         static async void Login()
        {
            HttpClient _http = new HttpClient();
            string url = "http://localhost:5000/auth/login";

            var payload = "{\"email\": \"joeyvico@gmail.com\",\"password\": \"passwordhere\"}";
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> httpResponse = _http.PostAsync(url, c);
            HttpResponseMessage response = httpResponse.Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Is your api running? Is your postgres db service up and running?");
                Console.WriteLine($"{response.ReasonPhrase} | {(int)response.StatusCode}");
            }

            var customerJsonString = await response.Content.ReadAsStringAsync();
            var deserialized = JsonConvert.DeserializeObject(customerJsonString);

            Console.WriteLine(deserialized);
            _http.Dispose();
        }
    }
}
