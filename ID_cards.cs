using System;
using System.Text.RegularExpressions;
class IDCardNameValidator
{
    static bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (IsValidName(name))
        {
            Console.WriteLine("Valid name. Proceed to print ID card.");
        }
        else
        {
            Console.WriteLine("Invalid name. Names must not contain digits or special characters.");
        }
    }
}
