using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of minutes:");
        int minutes = int.Parse(Console.ReadLine());

        int seconds = ConvertMinutesToSeconds(minutes);

        Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");
    }

    static int ConvertMinutesToSeconds(int minutes)
    {
        return minutes * 60;
    }
}
