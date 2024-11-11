using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Ork
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Health { get; set; }

    public Ork(string name, int strength, int health)
    {
        Name = name;
        Strength = strength;
        Health = health;
    }
}

public class Program
{

    static void Main()
    {
        //tworzymy orka
        Ork originalOrk = new Ork("Tadeusz", 5, 100);

        //lista kolekcji klonów
        List<Ork> orkClones = new List<Ork>();
        Random random = new Random();

        //serializujemy i deserializujemy aby stworzyc klony
        for (int i = 0; i < 5; i++)
        {
            //serializacja
            string jsonOrk = JsonConvert.SerializeObject(originalOrk);

            //deserializacja
            Ork cloneOrk = JsonConvert.DeserializeObject<Ork>(jsonOrk);

            //zmieniamy losowo parametr siły dla każdego klona od 5 do 50
            cloneOrk.Strength = random.Next(5, 50);

            //dodajemy klona do kolekcji
            orkClones.Add(cloneOrk);
        }

        //wyświetlamy klony
        foreach (var ork in orkClones)
        {
            Console.WriteLine($"Name: {ork.Name}, Strength: {ork.Strength}, Health: {ork.Health}");
        }

        Console.ReadKey();
    }
}
