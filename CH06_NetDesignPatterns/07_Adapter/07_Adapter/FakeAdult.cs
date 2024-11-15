using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FakeAdult : Adult
    {
        public FakeAdult(string name, int actualAge) : base(name, actualAge)
        {
            //FakeAdult udaje dorosłego
        }

        public override bool IsAdult()
        {
            return true; //nadpisujemy walidację
        }
    }
}
