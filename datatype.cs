using System;

class Program
{
        static void Main()
    {
        int age = 25;
        float temperature = 98.6f;
        char grade = 'A';
        bool isPassed = true;
        Console.WriteLine("Age: " + age + " (Type: " + age.GetType() + ")");
        Console.WriteLine("Temperature: " + temperature + " (Type: " + temperature.GetType() + ")");
        Console.WriteLine("Grade: " + grade + " (Type: " + grade.GetType() + ")");
        Console.WriteLine("Is Passed: " + isPassed + " (Type: " + isPassed.GetType() + ")");
    }
}
