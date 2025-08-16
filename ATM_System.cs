using System;
class ATMSystem
{
    static void Main()
    {
        const int correctPIN = 1234;
        int attempts = 0;
        bool accessGranted = false;

        while (attempts < 3)
        {
            Console.Write("Enter your PIN: ");
            string input = Console.ReadLine();
            int enteredPIN;
            if (int.TryParse(input, out enteredPIN))
            {
                if (enteredPIN == correctPIN)
                {
                    Console.WriteLine("Access Granted");
                    accessGranted = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Incorrect PIN");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numeric PIN.");
            }
        }
        if (!accessGranted)
        {
            Console.WriteLine("Card Blocked");
        }
    }
}
