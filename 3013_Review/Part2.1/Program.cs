Console.WriteLine("Type 'done' when you are finished.");

do
{
    Console.WriteLine("What is the order total?");
    double orderTotal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Would you like expedited shipping? (y/n)");
    string input = Console.ReadLine();
    bool isExpedited = input.ToLower() == "y";

    double shippingCost = CalculateShipping(orderTotal, isExpedited);
    Console.WriteLine($"The shipping cost is: {shippingCost.ToString("C")}");

} while (Console.ReadLine().ToLower() != "done");

double CalculateShipping(double orderTotal, bool isExpedited)
{
    double shippingCost = 0;

    if (orderTotal < 25)
    {
        shippingCost = 7.99;
    }
    else if (orderTotal < 50)
    {
        shippingCost = 4.99;
    }
    else
    {
        shippingCost = 0; // Free shipping for orders $50 and above
    }

    //if (orderTotal>= 50)
    //{

    //}

    if (isExpedited)
    {
        shippingCost += 10.00; // Add $10 for expedited shipping
    }

    return shippingCost;
}