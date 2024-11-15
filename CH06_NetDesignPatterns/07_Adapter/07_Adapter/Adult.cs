using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adult : Person
    {
        public Adult(string name, int age) : base(name, age) { }

        public virtual bool IsAdult()
        {
            return Age >= 18;
        }
    }
}

