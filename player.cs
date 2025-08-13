using System;
class Program
{
    static void Main()
    {
        int playerA = 20;
        int playerB = 15;

        Console.WriteLine("🎮 Game Score Comparison 🎮\n");

        bool aMoreThanB = playerA > playerB;
        Console.WriteLine("Did Player A score more than Player B? " + aMoreThanB);

        bool scoresEqual = playerA == playerB;
        Console.WriteLine("Are both scores equal? " + scoresEqual);

        bool aFailedToBeatB = playerA <= playerB;
        bool bFailedToBeatA = playerB <= playerA;

        Console.WriteLine("Did Player A fail to beat Player B? " + aFailedToBeatB);
        Console.WriteLine("Did Player B fail to beat Player A? " + bFailedToBeatA);
    }
}
