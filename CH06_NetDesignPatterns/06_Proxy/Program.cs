using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterface publicResource = new PublicFile();
            IUserInterface privateResource = new Proxy(new RestrictedFile(), "123");

            while (true)
            {
                Console.WriteLine("Select file:");
                Console.WriteLine("1. Public file.");
                Console.WriteLine("2. Private file.");
                Console.WriteLine("0. Exit");
                
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        publicResource.AccessFile();
                        break;
                    case "2":
                        privateResource.AccessFile();
                        break;
                    case "0":
                        Console.WriteLine("Exit.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                
                Console.ReadKey();
            }
        }
    }
}
