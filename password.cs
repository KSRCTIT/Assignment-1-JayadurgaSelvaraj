using System;

class Program
{
    static void Main()
    {
        bool isUsernameValid = true;
        bool isPasswordValid = false;

        Console.WriteLine("Login System\n");
        if (isUsernameValid && isPasswordValid)
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }

        bool anyValid = isUsernameValid || isPasswordValid;
        Console.WriteLine("\nAt least one is valid (username or password)? " + anyValid);

        Console.WriteLine("Username valid? " + isUsernameValid + " | Opposite: " + !isUsernameValid);
        Console.WriteLine("Password valid? " + isPasswordValid + " | Opposite: " + !isPasswordValid);
    }
}
