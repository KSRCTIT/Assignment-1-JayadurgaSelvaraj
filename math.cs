using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        Console.WriteLine("Kids' Math Calculator \n");

        int totalApples = a + b;
        Console.WriteLine("Total apples (10 + 5): " + totalApples);

        int pencilDifference = a - b;
        Console.WriteLine("Difference of pencils (10 - 5): " + pencilDifference);

        int totalPages = a * b;
        Console.WriteLine("Total pages copied (10 x 5): " + totalPages);

        int chocolatesPerKid = a / b;
        Console.WriteLine("Chocolates per kid (10 ÷ 5): " + chocolatesPerKid);
        int leftoverCandies = a % b;
        Console.WriteLine("Leftover candies (10 % 5): " + leftoverCandies);
    }
}

