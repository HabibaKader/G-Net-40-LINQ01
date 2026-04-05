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

            #region Question02: list of only the product names
            var productNames = ProductList
                               .Select(p => p.ProductName);

            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region Question03: Sort all products by UnitPrice
            var sortedProducts = ProductList
                                .OrderBy(p => p.UnitPrice);

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            #endregion

            #region Question04: all products where UnitPrice is between 10 and 30
            var midRangeProducts = ProductList
                                   .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var p in midRangeProducts)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            #endregion

            #region Question05: all products that are in stock and belong to the "Condiments" category
            var condimentsInStock = ProductList
                                    .Where(p => p.Category == "Condiments" && p.UnitsInStock > 0);

            foreach (var p in condimentsInStock)
            {
                Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            }
            #endregion

            #region Question06: Create a new anonymous type
            var productInfo = ProductList
                            .Select(p => new
                            {
                                Name = p.ProductName,
                                Price = p.UnitPrice,
                                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
                            });

            foreach (var item in productInfo)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            }
            #endregion

            #region Question07: product's name along with its position
            var indexedProducts = ProductList
                                .Select((p, index) => new
                                {
                                    Position = index + 1,
                                    Name = p.ProductName
                                });

            foreach (var item in indexedProducts)
            {
                Console.WriteLine($"{item.Position}. {item.Name}");
            }
            #endregion

            #region Question08: Sort ProductList by Category ascending
            var SortedProducts = ProductList
                                .OrderBy(p => p.Category)
                                .ThenByDescending(p => p.UnitPrice);

            foreach (var p in SortedProducts)
            {
                Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            }
            #endregion

            #region Question09: products from the "Beverages" category
            var beverages = ProductList
                            .Where(p => p.Category == "Beverages")
                            .OrderByDescending(p => p.UnitsInStock);

            foreach (var p in beverages)
            {
                Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            }
            #endregion

            #region Question10: list all orders
            var Customers = new[]
{
                new
                {
                    CustomerID = "1234",
                    Orders = new List<Order>
                    {
                        new Order { OrderID = 1, CustomerID = "1234", OrderDate = new DateTime(1996, 5, 1) },
                        new Order { OrderID = 2, CustomerID = "1234", OrderDate = new DateTime(1998, 3, 15) }
                    }
                },
                new
                {
                    CustomerID = "5678",
                    Orders = new List<Order>
                    {
                        new Order { OrderID = 3, CustomerID = "5678", OrderDate = new DateTime(1997, 7, 10) }
                    }
                }
            };
            #endregion
        }
    }
}
