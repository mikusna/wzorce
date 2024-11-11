using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class Weather
{
    private const string ApiKey = "d13ede1e3b55d3f48df865d64dff094f"; //klucz API
    private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric"; //URL API

    private readonly HttpClient _httpClient;

    public Weather()
    {
        _httpClient = new HttpClient();
    }

    public async Task<double> GetTemperatureAsync(string cityName)
    {
        var url = string.Format(ApiUrl, cityName, ApiKey); //URL z nazwą miasta i kluczem API
        //Console.WriteLine("Request URL: " + url);  //debugowanie URL

        try
        {
            //zapytanie HTTP do API
            var response = await _httpClient.GetAsync(url);

            //sprawdzamy odpowiedź
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Błąd HTTP: {response.StatusCode} - {response.ReasonPhrase}");
                return double.NaN;
            }

            //odczytanie odpowiedzi
            var responseString = await response.Content.ReadAsStringAsync();
            var weatherData = JObject.Parse(responseString);

            //wyciąganie temperatury z odpowiedzi JSON
            var temperature = weatherData["main"]?["temp"]?.ToObject<double>() ?? double.NaN;

            return temperature;
        }
        catch (Exception ex)
        {
            //logowanie wyjątków
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            return double.NaN;
        }
    }
}
