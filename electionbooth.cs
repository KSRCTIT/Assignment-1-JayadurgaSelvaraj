using System;
class ElectionBooth
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter age of person {i}: ");
            string input = Console.ReadLine();
            int age;
            if (int.TryParse(input, out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("Eligible to Vote\n");
                }
                else
                {
                    Console.WriteLine("Not Eligible\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
                i--; 
            }
        }
    }
}
