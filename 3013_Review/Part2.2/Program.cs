
using Part2._2;

List<Product> products = new List<Product>();

products.Add(new Product { Name = "Laptop", Price = 1000, Category = "Electronics", Quantity = 5 });
products.Add(new Product { Name = "Smartphone", Price = 800, Category = "Electronics", Quantity = 10 });
products.Add(new Product { Name = "Desk Chair", Price = 150, Category = "Furniture", Quantity = 20 });
products.Add(new Product { Name = "Coffee Table", Price = 200, Category = "Furniture", Quantity = 15 });
products.Add(new Product { Name = "Headphones", Price = 100, Category = "Electronics", Quantity = 30 });
products.Add(new Product { Name = "Monitor", Price = 300, Category = "Electronics", Quantity = 8 });
products.Add(new Product { Name = "Keyboard", Price = 50, Category = "Electronics", Quantity = 25 });


double totalInventoryValue = 0;
foreach (var product in products)
{
    totalInventoryValue += product.GetInventoryValue();
}

Console.WriteLine($"Total Inventory Value: {totalInventoryValue.ToString("C")}");



Console.WriteLine("What category of products would you like to view?");
string categoryInput = Console.ReadLine();

DisplayProductsByCategory(products, categoryInput);

Console.WriteLine("What is the maximum price of products you would like to view?");
string priceInput = Console.ReadLine();
if (double.TryParse(priceInput, out double maxPrice))
{
    DisplayProductsUnderPrice(products, maxPrice);
}
else
{
    Console.WriteLine("Invalid price entered.");
}

void DisplayProductsByCategory(List<Product> products, string category)
{
    Console.WriteLine($"Products in category '{category}':");
    foreach (var product in products)
    {
        if (product.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"- {product.Name}: {product.Price.ToString("C")} (Quantity: {product.Quantity})");
        }
    }
}

void DisplayProductsUnderPrice(List< Product > products, double price)
{
    Console.WriteLine($"Products under {price.ToString("C")}:");
    foreach (var product in products)
    {
        if (product.Price < price)
        {
            Console.WriteLine($"- {product.Name}: {product.Price.ToString("C")}");
        }
    }

}