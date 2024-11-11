using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace WarriorBuilderZadanie
{
    //interfejs wojownikow
    public interface IWarrior
    {
        //metoda ataku
        void Atak();
        //wlasciwosci opisujace wojownika
        string Klasa { get; set; }
        string Bron { get; set; }
        string Trening { get; set; }
    }
    public abstract class WarriorBuilder
    {
        protected IWarrior warrior;
        //zwraca obiekt wojownika
        public IWarrior GetWarrior() => warrior;
        //builder - szkolenie dla wojownika
        public void WyszkolWojownika()
        {
            ZapiszDoArmii();
            PobierzBron();
            TrenujDoWalki();
        }
        //co jest do zaimplementowane w konkretnych builderach
        protected abstract void ZapiszDoArmii();
        protected abstract void PobierzBron();
        protected abstract void TrenujDoWalki();
    }
    //PiechurBuilder
    public class PiechurBuilder : WarriorBuilder
    {
        protected override void ZapiszDoArmii()
        {
            warrior = new Piechur { Klasa = "Piechur" };
        }
        protected override void PobierzBron()
        {
            warrior.Bron = "Miecz";
        }
        protected override void TrenujDoWalki()
        {
            warrior.Trening = "Trening walki na miecze";
        }
    }
    //StrzelecBuilder
    public class StrzelecBuilder : WarriorBuilder
    {
        protected override void ZapiszDoArmii()
        {
            warrior = new Strzelec { Klasa = "Strzelec" };
        }
        protected override void PobierzBron()
        {
            warrior.Bron = "Łuk";
        }
        protected override void TrenujDoWalki()
        {
            warrior.Trening = "Trening strzelania z łuku";
        }
    }
    //KonnyBuilder
    public class KonnyBuilder : WarriorBuilder
    {
        protected override void ZapiszDoArmii()
        {
            warrior = new Konny { Klasa = "Konny" };
        }
        protected override void PobierzBron()
        {
            warrior.Bron = "Lanca";
        }
        protected override void TrenujDoWalki()
        {
            warrior.Trening = "Trening z lancą na koniu";
        }
    }
    ////implementacja wojownikow jako klasy wojownika
    //Piechur
    public class Piechur : IWarrior
    {
        public string Klasa { get; set; }
        public string Bron { get; set; }
        public string Trening { get; set; }
        public void Atak()
        {
            Console.WriteLine("Piechur atakuje");
        }
    }
    //Strzelec
    public class Strzelec : IWarrior
    {
        public string Klasa { get; set; }
        public string Bron { get; set; }
        public string Trening { get; set; }
        public void Atak()
        {
            Console.WriteLine("Strzelec atakuje");
        }
    }
    //Konny
    public class Konny : IWarrior
    {
        public string Klasa { get; set; }
        public string Bron { get; set; }
        public string Trening { get; set; }
        public void Atak()
        {
            Console.WriteLine("Konny atakuje");
        }
    }
    //Garnizon
    public class Garnizon
    {
        //lista wojownikow
        private List<IWarrior> warriors = new List<IWarrior>();
        //szkolenie i dodawanie do garnizonu
        public void WyszkolWojownika(WarriorBuilder builder)
        {
            builder.WyszkolWojownika();
            warriors.Add(builder.GetWarrior());
        }
        //wyswietlenie wojownikow w garnizonie
        public void PokazWojownikow()
        {
            Console.WriteLine("Wojownicy w garnizonie:");
            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Klasa: {warrior.Klasa}, Broń: {warrior.Bron}, Trening: {warrior.Trening}");
                warrior.Atak();//wywolanie ataku dla każdego wojownika
            }
        }
    }
}