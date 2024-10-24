namespace Product
{
    public class LongParameterList
    {
        public void RegisterProduct(ProductInfo product)
        {
            //zarejestrowanie produktu
            Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.Price:C}, Stock: {product.Stock}, Supplier: {product.SupplierName}, Contact: {product.SupplierContact}");
        }
    }

    public class ProductInfo //przeniesienie klasy ProductInfo poza LongParameterList
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }

        //konstruktor klasy ProductInfo
        public ProductInfo(string productName, string category, decimal price, int stock, string supplierName, string supplierContact)
        {
            ProductName = productName;
            Category = category;
            Price = price;
            Stock = stock;
            SupplierName = supplierName;
            SupplierContact = supplierContact;
        }
    }
}
