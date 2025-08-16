using System;
class QuizScoreUpdater
{
    static void Main()
    {
        int score = 50;
        Console.WriteLine($"Initial Score: {score}");
        CorrectAnswer(ref score);
        WrongAnswer(ref score);
        BonusRound(ref score);
        Penalty(ref score);
        CorrectAnswer(ref score);
        WrongAnswer(ref score);
    }
    static void CorrectAnswer(ref int score)
    {
        score += 10;
        Console.WriteLine($"Correct Answer: {score}");
    }
    static void WrongAnswer(ref int score)
    {
        score -= 5;
        Console.WriteLine($"Wrong Answer: {score}");
    }
    static void BonusRound(ref int score)
    {
        score *= 2;
        Console.WriteLine($"Bonus Round: {score}");
    }
    static void Penalty(ref int score)
    {
        score /= 5;
        Console.WriteLine($"Penalty: {score}");
    }
}
