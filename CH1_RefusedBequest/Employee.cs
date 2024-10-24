using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefusedBequest
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"{Name} is attending meeting.");
        }
    }
}
