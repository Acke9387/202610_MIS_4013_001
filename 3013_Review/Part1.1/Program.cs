/*
 Restaurant Order Total
Create a console application for a restaurant.

Ask the user for:

Customer name
Number of entrées ordered
Price per entrée
Whether they have a coupon (yes/no)

Calculate the subtotal. 
If they have a coupon, apply a 15% discount. Then calculate 8.625% sales tax and display a formatted receipt.
 */

string customerName;
int numberOfEntrees;
double pricePerEntree;
string coupon;
double subtotal;
double tax;
double total;
double couponDiscount;

Console.WriteLine("What is the customer's name? <<");
customerName = Console.ReadLine();

Console.WriteLine("How many entrées are being ordered? <<");
string numberOfEntreesInput = Console.ReadLine();
//numberOfEntrees = int.Parse(numberOfEntreesInput);
//numberOfEntrees = Convert.ToInt32(numberOfEntreesInput);
bool isValid = int.TryParse(numberOfEntreesInput, out numberOfEntrees);

while (isValid == false)
{
    Console.WriteLine("Invalid input. Please enter a valid number of entrées.");
    numberOfEntreesInput = Console.ReadLine();
    isValid = int.TryParse(numberOfEntreesInput, out numberOfEntrees);
}

Console.WriteLine("What is the price per entrée? <<");
pricePerEntree = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Do they have a coupon? (yes/no)");
coupon = Console.ReadLine();

subtotal = numberOfEntrees * pricePerEntree;
tax = subtotal * 0.08625;

if (coupon.ToLower() == "yes")
{
    couponDiscount = subtotal * 0.15;
}
else
{
    couponDiscount = 0;
}

// subtotal -= couponDiscount;
//subtotal = subtotal -  couponDiscount;

total = subtotal + tax - couponDiscount;

Console.WriteLine($"Customer: {customerName} ");
Console.WriteLine($"Subtotal: ${subtotal:C2}");
Console.WriteLine($"Tax: ${tax:C2}");
Console.WriteLine($"Coupon Discount: ${couponDiscount:C2}");
Console.WriteLine($"Total: ${total:C2}");