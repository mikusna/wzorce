


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Wojownik
    {
        //Profesja, którą każda klasa dziedzicząca musi nadpisać, aby zwrócić jej nazwę
        public abstract string Profesja { get; }
    }

    //klasa Pierchur dziedziczy po Wojowniku
    class Piechur : Wojownik
    {
        public override string Profesja => "Piechur";
    }

    //klasa Strzelec dziedziczy po Wojowniku
    class Strzelec : Wojownik
    {
        public override string Profesja => "Strzelec";
    }

    ////klasa Konny dziedziczy po Wojowniku
    class Konny : Wojownik
    {
        public override string Profesja => "Konny";
    }

    //klasa garnizon tworzy wojowników na podstawie ich profesji
    class Garnizon
    {
        //metoda factory
        public Wojownik WyszkolWojownika(string profesja)
        {
            //weryfikuje jaka profesja została wskazana i tworzy odpowiedni obiekt
            switch (profesja)
            {
                case "Piechur":
                    return new Piechur();//zwraca obiekt klasy Piechur
                case "Strzelec":
                    return new Strzelec();//zwraca obiekt klasy Strzelec
                case "Konny":
                    return new Konny();//zwraca obiekt klasy Konny
                default:
                    throw new InvalidOperationException("Brak profesji");//zwraca błąd w przypadku nieistniejącej profesji
            }
        }
    }
}