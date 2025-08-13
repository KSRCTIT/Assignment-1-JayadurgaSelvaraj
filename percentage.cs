using System;

class Program
{
    static void Main()
    {
        double price = 1000.0;
        double discountPercentage = 10.0;
        double discountAmount = (discountPercentage / 100.0) * price;
        double finalPrice = price - discountAmount;
        Console.WriteLine("Original Price: " + price);
        Console.WriteLine("Discount: " + discountPercentage + "%");
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
