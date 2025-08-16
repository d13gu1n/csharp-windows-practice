class Activity5
{
    public void Act5()
    {
        string message = "The quick brown fox jumpsover the lazy dog";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}

class Activity14
{
    public void Act14()
    {
        string str = "The quick brown fox jumps over the lazy dog";

        // convert the message into a char array
        char[] charMessage = str.ToCharArray();

        // Reverse the chars
        Array.Reverse(charMessage);

        // count the o's
        int x = 0;
        foreach (char i in charMessage)
        {
            if (i == 'o')
            {
                x++;
            }
        }

        // convert it back to a string
        string new_message = new String(charMessage);

        // print it out
        Console.WriteLine(new_message);
        Console.WriteLine($"'o' appears {x} times.");
    }
}