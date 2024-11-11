using WarriorBuilderZadanie;
class Program
{
    static void Main(string[] args)
    {
        Garnizon garnizon = new Garnizon();
        //dodanie 2 piechurów
        WarriorBuilder piechurBuilder = new PiechurBuilder();
        garnizon.WyszkolWojownika(piechurBuilder);
        garnizon.WyszkolWojownika(piechurBuilder);

        //dodanie 2 strzelców
        WarriorBuilder strzelecBuilder = new StrzelecBuilder();
        garnizon.WyszkolWojownika(strzelecBuilder);
        garnizon.WyszkolWojownika(strzelecBuilder);

        //dodanie 2 konnych
        WarriorBuilder konnyBuilder = new KonnyBuilder();
        garnizon.WyszkolWojownika(konnyBuilder);
        garnizon.WyszkolWojownika(konnyBuilder);
        // Wyświetlenie wojowników
        garnizon.PokazWojownikow();

        Console.ReadKey();
    }
}