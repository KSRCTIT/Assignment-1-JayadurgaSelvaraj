using System;
class SchoolApp
{
    static void Main()
    {
        string repeat;
        do
        {
            Console.Write("Enter a number to print its multiplication table: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"\nMultiplication Table of {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
            Console.Write("\nDo you want to try another number? (Y/N): ");
            repeat = Console.ReadLine().Trim().ToUpper();
        } while (repeat == "Y");
        
        Console.Write("\n Enter electricity units consumed: ");
        string unitInput = Console.ReadLine();
        int units;
        double bill = 0;

        if (int.TryParse(unitInput, out units) && units >= 0)
        {
            if (units <= 100)
            {
                bill = units * 2;
            }
            else if (units <= 200)
            {
                bill = (100 * 2) + ((units - 100) * 3);
            }
            else
            {
                bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
            }

            Console.WriteLine($"Total Electricity Bill: ₹{bill}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number for units.");
        }
    }
}
