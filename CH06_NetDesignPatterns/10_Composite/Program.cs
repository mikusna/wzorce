using _10_Composite;

class Program
{
    static void Main(string[] args)
    {
        Dish kimchi = new Dish("Kimchi", 15.00m);
        Dish bibimbap = new Dish("Bibimbap", 25.00m);
        Dish bulgogi = new Dish("Bulgogi", 30.00m);
        Dish japchae = new Dish("Japchae", 28.00m);
        Dish tteokbokki = new Dish("Tteokbokki", 18.00m);
        Dish bingsu = new Dish("Bingsu", 22.00m);
        Dish hotteok = new Dish("Hotteok", 12.00m);
        Dish yakgwa = new Dish("Yakgwa", 10.00m);

        Category appetizers = new Category("Przystawki:");
        Category mainDishes = new Category("Dania główne:");
        Category desserts = new Category("Desery:");

        appetizers.AddItem(kimchi);
        appetizers.AddItem(tteokbokki);

        mainDishes.AddItem(bibimbap);
        mainDishes.AddItem(bulgogi);
        mainDishes.AddItem(japchae);

        desserts.AddItem(bingsu);
        desserts.AddItem(hotteok);
        desserts.AddItem(yakgwa);

        Category menu = new Category("Menu");

        menu.AddItem(appetizers);
        menu.AddItem(mainDishes);
        menu.AddItem(desserts);

        Console.WriteLine("Restauracja koreańska");
        menu.Display(0);

        Console.ReadKey();
    }
}