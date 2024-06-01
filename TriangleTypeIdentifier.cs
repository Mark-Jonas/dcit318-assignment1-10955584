using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        double side1 = GetSideLength();
        
        Console.Write("Enter the length of side 2: ");
        double side2 = GetSideLength();
        
        Console.Write("Enter the length of side 3: ");
        double side3 = GetSideLength();

        string triangleType = DetermineTriangleType(side1, side2, side3);

        Console.WriteLine("The type of the triangle is: " + triangleType);
    }

    // Method to get the side length and ensure it's a valid number
    static double GetSideLength()
    {
        double sideLength;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out sideLength) && sideLength > 0)
            {
                return sideLength;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid positive number for the side length.");
                Console.Write("Enter the length again: ");
            }
        }
    }

    // Method to determine the type of the triangle based on side lengths
    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
