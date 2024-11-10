using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Usuń dziedziczenie w klasie Manager
//Utwórz interfejs IEmployee zawierający metody Work, AttendMeeting

namespace RefusedBequest
{
    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }
}