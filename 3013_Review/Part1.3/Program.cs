/*
 Create a list containing the inventory quantities for several products:

12, 4, 0, 18, 3, 9, 0, 6
Loop through the inventory and determine:

How many products are out of stock
How many have low inventory (1–5)
How many have sufficient inventory (>5)
Total number of items in inventory

 */
//                                               0  1  2  3   4  5  6  7
List<int> inventoryQuantities = new List<int> { 12, 4, 0, 18, 3, 9, 0, 6 };
int numberOfOutOfStockProducts = 0;
int numberOfLowInventoryProducts = 0;
int numberOfSufficientInventoryProducts = 0;
int totalNumberOfItemsInInventory = 0;
foreach (var item in inventoryQuantities)
{
    if (item == 0)
    {
        numberOfOutOfStockProducts++;
        //numberOfOutOfStockProducts = numberOfOutOfStockProducts + 1;
    }
    else if (item >= 1 && item <= 5)
    {
        numberOfLowInventoryProducts++;
    }
    else if (item > 5)
    {
        numberOfSufficientInventoryProducts++;
    }

    totalNumberOfItemsInInventory += item;
}

Console.WriteLine($"Number of out-of-stock products: {numberOfOutOfStockProducts}");
Console.WriteLine($"Number of low-inventory products: {numberOfLowInventoryProducts}");
Console.WriteLine($"Number of sufficient-inventory products: {numberOfSufficientInventoryProducts}");
Console.WriteLine($"Total number of items in inventory: {totalNumberOfItemsInInventory}");

//inventoryQuantities.Add(12);
//inventoryQuantities.Add(4); 