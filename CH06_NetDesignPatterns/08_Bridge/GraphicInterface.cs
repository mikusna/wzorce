using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GraphicInterface : Interface
    {
        void Interface.DisplayMenu()
        {
            Console.WriteLine("Graphic Interface.");
        }
    }
}
