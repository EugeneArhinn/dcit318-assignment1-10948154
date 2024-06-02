using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        decimal ticketPrice;
        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7.00m;
            Console.WriteLine("You are eligible for a discounted ticket price of GHC7.00.");
        }
        else
        {
            ticketPrice = 10.00m;
            Console.WriteLine("You are not eligible for a discounted ticket price.");
        }

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice:F2}");
        Console.ReadLine(); // wait for user to press Enter
    }
}
