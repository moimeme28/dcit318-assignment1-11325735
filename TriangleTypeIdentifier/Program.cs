using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        double side1 = GetSideInput();

        Console.Write("Enter side 2: ");
        double side2 = GetSideInput();

        Console.Write("Enter side 3: ");
        double side3 = GetSideInput();

        // Check if it's a valid triangle
        if (IsValidTriangle(side1, side2, side3))
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
    }

    static double GetSideInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double side) && side > 0)
                return side;
            else
                Console.Write("Invalid input. Please enter a positive number: ");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
