// Activity 1

/* Activity1 activity1 = new Activity1();
activity1.Act1(); */

// End of Activity 1 

// Activity 2

/* Activity2 activity2 = new Activity2();
activity2.Act2(); */

// End of Activity 2

// Activity 3

/* Activity3 activity3 = new Activity3();
activity3.Act3(); */

// End of Activity 3

// Activity 4

/* Activity4 activity4 = new Activity4();
activity4.Act4(); */

// End of Activity 4

// Activity 5

Activity5 activity5 = new();
activity5.Act5();

// End of Activity 5

// Activity 6

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine("Your subscription expires within a day!");
//     Console.WriteLine("Renew now and save 20%!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
//     Console.WriteLine("Renew now and save 10%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// Console.Write($"Discount percentage: {discountPercentage}%");

// End of Activity 6

/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

/* string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");
*/
// Activity 7

/* string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
} */

// End of Activity 7

// Activity 8

/* int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory."); */

// End of Activity 8

// Activity 9

/* string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string suspectedOrder in orders)
{
    if (suspectedOrder.StartsWith("B"))
    {
        Console.WriteLine(suspectedOrder);
    }
} */

// End of Activity 9