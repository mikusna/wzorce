using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var weather = new Weather();

        Console.WriteLine("Aplikacja pogodowa.");

        while (true)
        {
            Console.Write("Podaj nazwę miasta (lub wpisz 'exit' aby zakończyć): ");
            var cityName = Console.ReadLine();

            if (cityName?.ToLower() == "exit")  //warunek 'exit' dla zakończenia programu
            {
                break;
            }

            if (!string.IsNullOrEmpty(cityName))
            {
                try
                {
                    var temperature = await weather.GetTemperatureAsync(cityName);
                    if (double.IsNaN(temperature))
                    {
                        Console.WriteLine($"Nie udało się sprawdzić temperatury w {cityName}.");
                    }
                    else
                    {
                        Console.WriteLine($"Aktualna temperatura w {cityName} wynosi {temperature}°C.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Nazwa miasta nie może być pusta.");
            }
        }

        Console.WriteLine("Zakończenie programu.");
    }
}
