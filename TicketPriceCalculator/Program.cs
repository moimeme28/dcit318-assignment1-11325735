using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
                Console.WriteLine("You qualify for a discounted ticket.");
            }
            else
            {
                ticketPrice = 10;
            }

            Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for your age.");
        }
    }
}
