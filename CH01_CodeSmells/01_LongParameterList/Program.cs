using Product;

class Program
{
    static void Main(string[] args)
    {
        //utworzenie obiektu ProductInfo
        ProductInfo product = new ProductInfo("Bed", "Furniture", 213, 7, "Ikea", "123-456-789");

        //utworzenie obiektu LongParameterList aby wywołać metodę RegisterProduct
        LongParameterList longParameterList = new LongParameterList();
        longParameterList.RegisterProduct(product);

        Console.ReadKey();

    }
}