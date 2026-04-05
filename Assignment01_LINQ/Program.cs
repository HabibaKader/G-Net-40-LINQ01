namespace Assignment01_LINQ
{
    internal class Program
    {
        #region MyRegion
        static List<Product> ProductList = new List<Product>
        {
            new Product { ProductName = "Chai", Category = "Beverages", UnitPrice = 18, UnitsInStock = 39 },
            new Product { ProductName = "Chang", Category = "Beverages", UnitPrice = 19, UnitsInStock = 17 },
            new Product { ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10, UnitsInStock = 13 },
            new Product { ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22, UnitsInStock = 0 },
            new Product { ProductName = "Ikura", Category = "Seafood", UnitPrice = 31, UnitsInStock = 20 },
            new Product { ProductName = "Konbu", Category = "Seafood", UnitPrice = 6, UnitsInStock = 24 },
            new Product { ProductName = "Tofu", Category = "Produce", UnitPrice = 23, UnitsInStock = 0 },
            new Product { ProductName = "Pavlova", Category = "Confections", UnitPrice = 17, UnitsInStock = 29 }
        };
        #endregion
        static void Main(string[] args)
        {
            #region Question01: products from the "Seafood" category
            var seafoodProducts = ProductList
                                .Where(p => p.Category == "Seafood");

            foreach (var p in seafoodProducts)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            #endregion
        }
    }
}
