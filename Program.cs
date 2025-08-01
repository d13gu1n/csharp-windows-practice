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

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 6;
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total.");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total.");
        total += 2;   
    }
}


if (total >= 15)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry, you lose.");
}

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