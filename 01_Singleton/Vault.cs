using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonVault
{
    sealed class Vault
    {
        private Vault() //tylko klasa Vault może tworzyć instancję
        {
            //stworzenie unikalnego klucza dostępu w zakresie od-do
            _accessKey = createKey(100, 100000);
        }

        private static Vault? _instance;//zmienna przechowująca jedyną instancję klasy
        private static readonly object _lock = new object();//obiekt w celu zapewnienia bezpieczeństwa wątkowego
        private static readonly Random _random = new Random();//obiekt do generowania losowych liczb
        private int _accessKey;//klucz dostępu
        private bool _keyAccessed = false;//flaga czy klucz był już wygenerowany

        //metoda do uzyskania instancji Vault
        public static Vault Instance()
        {
            if (_instance == null)//sprawdzenie czy istnieje instancja
            {
                lock (_lock)//blokada do zapewnienia bezpieczeństwa wątkowego
                {
                    if (_instance == null)//dla zablokowanej instancji sprawdzenie czy jest nullowa
                    {
                        _instance = new Vault();//utworzenie instancji
                    }
                }
            }
            return _instance;//zwrocenie instancji Vault
        }

        //metoda do generowania losowego klucza dostępu w zakresie od-do
        public static int createKey(int min, int max)
        {
            lock (_random)//blokada do zapewnienia bezpieczeństwa wątkowego
            {
                return _random.Next(min, max);//zwrocenie losowej liczby w zakresie od-do
            }
        }

        //metoda do generowania klucza dostępu
        public void generateKey()
        {
            if (_keyAccessed)//weryfikacja czy klucz został wygenerowany
            {
                //wyjątek dla już wygenerowanego klucza
                throw new InvalidOperationException("Klucz został już wygenerowany.");
            }
            _keyAccessed = true;//oznaczenie uzyskania klucza
            Console.WriteLine($"Klucz dostępu: {_accessKey}");//zwraca klucz dostępu
        }
    }
}
