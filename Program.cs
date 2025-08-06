// Activity 1

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// End of Activity 1 

// Activity 2

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int roll4 = dice.Next();

// Console.WriteLine($"Fourth roll: {roll4}");

// End of Activity 2

// Activity 3

// int firstvalue = 500;
// int secondvalue = 600;
// int largervalue = Math.Max(firstvalue, secondvalue);

// Console.WriteLine(largervalue);

// End of Activity 3

// Activity 4

// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 6;
// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total.");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total.");
//         total += 2;   
//     }
// }


// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// End of Activity 4

// Activity 5

// string message = "The quick brown fox jumpsover the lazy dog";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

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

string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string suspectedOrder in orders)
{
    if (suspectedOrder.StartsWith("B"))
    {
        Console.WriteLine(suspectedOrder);
    }
}