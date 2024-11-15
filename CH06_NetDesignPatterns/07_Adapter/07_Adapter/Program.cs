using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Adapter;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
            {
                new Adult("Ania", 22), //dorosła osoba
                new FakeAdult("Krzyś", 17),//nastolatek udający dorosłego
                new Adult("Tomek", 15)//nastolatek nieudający dorosłego
            };

        foreach (var person in people)
        {
            if (person is Adult adult && adult.IsAdult())
            {
                Console.WriteLine($"{person.Name}, wiek: {person.Age} - Wpuszczony do klubu.");
            }
            else
            {
                Console.WriteLine($"{person.Name}, wiek: {person.Age} - Nie wpuszczony do klubu.");
            }
        }

        Console.ReadKey();
    }
}