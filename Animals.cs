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