﻿internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");
        Console.WriteLine("Contents of RockPaperScissorsTournament.txt = ");

        int totalScoreOfRounds = 0;
        int totalSumOfEveryRound = 0;

        foreach (string line in lines)
        {
            Console.WriteLine("\t" + line);
            if (line == "A X")
            {
                totalScoreOfRounds = 3 + 0;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "A Y")
            {
                totalScoreOfRounds = 1 + 3;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "A Z")
            {
                totalScoreOfRounds = 2 + 6;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "B X")
            {
                totalScoreOfRounds = 1 + 0;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "B Y")
            {
                totalScoreOfRounds = 2 + 3;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "B Z")
            {
                totalScoreOfRounds = 3 + 6;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "C X")
            {
                totalScoreOfRounds = 2 + 0;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "C Y")
            {
                totalScoreOfRounds = 3 + 3;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
            else if (line == "C Z")
            {
                totalScoreOfRounds = 1 + 6;
                totalSumOfEveryRound += totalScoreOfRounds;
            }
        }

        Console.WriteLine("The sum of points foreach round:");
        Console.WriteLine(totalSumOfEveryRound);
        Console.ReadLine();
    }
}