using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Composite
{
    public class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth * 2) + $" {Name} - {Price} PLN");
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public List<object> Items { get; set; }

        public Category(string name)
        {
            Name = name;
            Items = new List<object>();
        }

        public void AddItem(object item)
        {
            Items.Add(item);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth * 2) + Name);
            foreach (var item in Items)
            {
                if (item is Category category)
                {
                    category.Display(depth + 1);
                }
                else if (item is Dish dish)
                {
                    dish.Display(depth + 1);
                }
            }
        }
    }
}
