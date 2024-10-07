using Factory;

class Program
{
    static void Main(string[] args)
    {
        Garnizon garnizon = new Garnizon();

        //utworzenie tablicy wojowników i dodanie odpowiednich obiektów
        Wojownik[] wojownik = new Wojownik[]
        {
            garnizon.WyszkolWojownika("Piechur"),
            garnizon.WyszkolWojownika("Piechur"),
            garnizon.WyszkolWojownika("Piechur"),
            garnizon.WyszkolWojownika("Konny"),
            garnizon.WyszkolWojownika("Konny"),
            garnizon.WyszkolWojownika("Konny"),
            garnizon.WyszkolWojownika("Strzelec"),
            garnizon.WyszkolWojownika("Strzelec"),
            garnizon.WyszkolWojownika("Strzelec"),
            garnizon.WyszkolWojownika("Strzelec")
        };

        //dla każdego wojownika wyświetlenie jego profesji
        foreach (var woj in wojownik)
        {
            Console.WriteLine(woj.Profesja);
        }
    }
}