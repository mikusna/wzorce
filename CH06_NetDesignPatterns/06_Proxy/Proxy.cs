using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IUserInterface
    {
        void AccessFile();
    }

    //obiekt dostępny bez ograniczeń
    public class PublicFile : IUserInterface
    {
        public void AccessFile()
        {
            Console.WriteLine("Public File. Press enter to go back to main menu.");
        }
    }

    //obiekt zastrzeżony
    public class RestrictedFile : IUserInterface
    {
        public void AccessFile()
        {
            Console.WriteLine("Restriced file. Press enter to go back to main menu.");
        }
    }

    //proxy - kontrola dostępu do plików poprzez sprawdzenie czy hasło zwrócone zostało poprawnie
    public class Proxy : IUserInterface
    {
        private readonly IUserInterface _file;
        private readonly string _password;

        public Proxy(IUserInterface file, string password)
        {
            _file = file;
            _password = password;
        }

        public void AccessFile()
        {
            Console.Write("Password: ");
            string input = Console.ReadLine();

            if (input == _password)
            {
                _file.AccessFile();
            }
            else
            {
                Console.WriteLine("Access denied. Incorrect password.");
            }
        }
    }



}

