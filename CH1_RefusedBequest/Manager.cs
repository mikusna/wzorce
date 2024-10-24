using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Wprowadź interfejs IEmployee do klasy Manager i przenieś do niej tylko te metody, które są używane.

namespace RefusedBequest
{
    public class Manager : Employee
    {
        public void ManageTeam() 
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }
}
